using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Modelo
{
    public class CRUD
    {
        public void GuardarProducto(Producto producto)
        {
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    string query = "INSERT INTO Producto (codigo, nombre, stock, precio, costo) VALUES (@codigo, @nombre, @stock, @precio, @costo)";
                    using (SqlCommand cmd = new SqlCommand(query, ConexionBD.cn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                        cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@stock", producto.Stock);
                        cmd.Parameters.AddWithValue("@precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@costo", producto.Costo);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto registrado exitosamente!");
                            GuardarActividad(GlobalVariables.id_usuario,"Nuevo Producto", producto);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        public void GuardarUsuario(Usuario usuario)
        {
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuario WHERE id=@id", ConexionBD.cn);
                    cmd.Parameters.AddWithValue("@id", usuario.Id);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("ERROR! Usuario ya registrado...");
                        return;
                    }
                    else
                    {
                        //Cifrar la contraseña
                        string password = usuario.Pass;
                        using (var sha256 = SHA256.Create())
                        {
                            byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                            string hashedPassword = Convert.ToBase64String(hash);
                            usuario.Pass = hashedPassword;
                        }
                        //Insertar datos del usuario en la tabla Usuario
                        string query = "INSERT INTO Usuario (id, nombre, apellido, telefono) VALUES (@id, @nombre, @apellido, @telefono)";
                        SqlCommand command = new SqlCommand(query, ConexionBD.cn);
                        command.Parameters.AddWithValue("@id", usuario.Id);
                        command.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        command.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        command.Parameters.AddWithValue("@telefono", usuario.Telefono);
                        command.ExecuteNonQuery();

                        //Insertar datos de credenciales de usuario en la tabla Credenciales_Acceso
                        string query2 = "INSERT INTO Credenciales_Acceso (usuario, password, id_usuario, estado) VALUES (@usuario, @password, @id_usuario, @estado)";
                        SqlCommand command2 = new SqlCommand(query2, ConexionBD.cn);
                        command2.Parameters.AddWithValue("@usuario", usuario.User);
                        command2.Parameters.AddWithValue("@password", usuario.Pass);
                        command2.Parameters.AddWithValue("@id_usuario", usuario.Id);
                        command2.Parameters.AddWithValue("@estado", usuario.Estado);
                        command2.ExecuteNonQuery();

                        MessageBox.Show("Usuario Registrado Exitosamente!");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        public void GuardarActividad(int id_usuario,string tipo_actividad,Producto producto)
        {
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    Actividad actividad = new Actividad();
                    actividad.Fechayhora = DateTime.Now;
                    actividad.Ingreso_stock = producto.Stock;
                    actividad.Tipo_actividad = tipo_actividad;
                    actividad.Codigo_producto = producto.Codigo;
                    actividad.Nombre_producto = producto.Nombre;
                    actividad.Id_usuario = id_usuario;
                    string query = "INSERT INTO Actividad (fechayhora, ingreso_stock,tipo_actividad, codigo_producto, nombre_producto, id_usuario) VALUES (@fechayhora, @ingreso_stock,@tipo_actividad, @codigo_producto,@nombre_producto, @id_usuario)";
                    using (SqlCommand cmd = new SqlCommand(query, ConexionBD.cn))
                    {
                        cmd.Parameters.AddWithValue("@fechayhora", actividad.Fechayhora);
                        cmd.Parameters.AddWithValue("@ingreso_stock", actividad.Ingreso_stock);
                        cmd.Parameters.AddWithValue("@tipo_actividad", actividad.Tipo_actividad);
                        cmd.Parameters.AddWithValue("@codigo_producto", actividad.Codigo_producto);
                        cmd.Parameters.AddWithValue("@nombre_producto", actividad.Nombre_producto);
                        cmd.Parameters.AddWithValue("@id_usuario", actividad.Id_usuario);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected <= 0)
                        {
                            MessageBox.Show("ERROR!: No se pudo registrar la actividad...");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        public DataTable DatosProducto()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Codigo");
                    dt.Columns.Add("Stock");
                    dt.Columns.Add("Costo");
                    dt.Columns.Add("Precio");

                    SqlCommand cmd = new SqlCommand("SELECT codigo, nombre, stock, costo, precio FROM Producto", ConexionBD.cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["Codigo"] = reader.GetInt32(0).ToString();
                        row["Nombre"] = reader.GetString(1);
                        row["Stock"] = reader.GetInt32(2).ToString();
                        row["Costo"] = reader.GetFloat(3).ToString();
                        row["Precio"] = reader.GetFloat(4).ToString();
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return dt;
        }
        public DataTable DatosUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    dt.Columns.Add("Id");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Teléfono");
                    dt.Columns.Add("Usuario");
                    dt.Columns.Add("Estado");

                    SqlCommand cmd = new SqlCommand("SELECT Usuario.id, nombre, apellido, telefono, usuario, estado FROM Usuario INNER JOIN Credenciales_Acceso ON Usuario.id = Credenciales_Acceso.id_usuario", ConexionBD.cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["Id"] = reader.GetInt32(0).ToString();
                        row["Nombre"] = reader.GetString(1);
                        row["Apellido"] = reader.GetString(2);
                        row["Teléfono"] = reader.GetString(3);
                        row["Usuario"] = reader.GetString(4);
                        row["Estado"] = reader.GetString(5);
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return dt;
        }
        public DataTable DatosActividad()
        {
            DataTable dt = new DataTable();
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    dt.Columns.Add("Fecha y Hora");
                    dt.Columns.Add("Id");
                    dt.Columns.Add("Nombre");
                    dt.Columns.Add("Apellido");
                    dt.Columns.Add("Actividad");
                    dt.Columns.Add("Codigo Producto");
                    dt.Columns.Add("Nombre Producto");
                    dt.Columns.Add("Stock Ingresado");

                    SqlCommand cmd = new SqlCommand("SELECT Actividad.fechayhora, Usuario.id, Usuario.nombre, Usuario.apellido,Actividad.tipo_actividad, Actividad.codigo_producto, Actividad.nombre_producto, Actividad.ingreso_stock FROM Actividad INNER JOIN Usuario ON Actividad.id_usuario = Usuario.id", ConexionBD.cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DataRow row = dt.NewRow();
                        row["Fecha y Hora"] = reader.GetDateTime(0);
                        row["Id"] = reader.GetInt32(1);
                        row["Nombre"] = reader.GetString(2);
                        row["Apellido"] = reader.GetString(3);
                        row["Actividad"] = reader.GetString(4);
                        row["Codigo Producto"] = reader.GetInt32(5);
                        row["Nombre Producto"] = reader.GetString(6);
                        row["Stock Ingresado"] = reader.GetInt32(7);
                        dt.Rows.Add(row);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return dt;
        }
        public void ActualizarProducto(Producto producto)
        {
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    string query = "UPDATE Producto SET nombre = @nombre, stock = @stock, precio = @precio, costo = @costo WHERE codigo = @codigo";
                    SqlCommand command = new SqlCommand(query, ConexionBD.cn);
                    command.Parameters.AddWithValue("@nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@stock", producto.Stock);
                    command.Parameters.AddWithValue("@precio", producto.Precio);
                    command.Parameters.AddWithValue("@costo", producto.Costo);
                    command.Parameters.AddWithValue("@codigo", producto.Codigo);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto Actualizado Correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("ERROR!: No se pudo actualizar correctamente...");

                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        public void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    var command = new SqlCommand($"UPDATE Usuario SET nombre = '{usuario.Nombre}', apellido = '{usuario.Apellido}', telefono = '{usuario.Telefono}' FROM Usuario INNER JOIN Credenciales_Acceso ON Usuario.id = Credenciales_Acceso.id_usuario WHERE Usuario.id = '{usuario.Id}'", ConexionBD.cn);
                    command.ExecuteNonQuery();
                    command = new SqlCommand($"UPDATE Credenciales_Acceso SET estado = '{usuario.Estado}' WHERE id_usuario = '{usuario.Id}'", ConexionBD.cn);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario Actualizado Correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("ERROR!: No se pudo actualizar correctamente...");

                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        public void IngresoProducto(Producto producto, int ingreso)
        {
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    SqlCommand cmdStockActual = new SqlCommand("SELECT stock FROM Producto WHERE codigo = @codigo", ConexionBD.cn);
                    cmdStockActual.Parameters.AddWithValue("@codigo", producto.Codigo);
                    int stockActual = (int)cmdStockActual.ExecuteScalar();
                    int cantidadIngresada = ingreso;
                    int nuevoStock = stockActual + cantidadIngresada;

                    SqlCommand cmdActualizarStock = new SqlCommand("UPDATE Producto SET stock = @stock WHERE codigo = @codigo", ConexionBD.cn);
                    cmdActualizarStock.Parameters.AddWithValue("@stock", nuevoStock);
                    cmdActualizarStock.Parameters.AddWithValue("@codigo", producto.Codigo);
                    int filasActualizadas = cmdActualizarStock.ExecuteNonQuery();

                    if (filasActualizadas > 0)
                    {
                        MessageBox.Show("Stock ingresado en producto!");
                        producto.Stock = cantidadIngresada;
                        GuardarActividad(GlobalVariables.id_usuario, "Ingreso de Stock", producto);
                    }
                    else
                    {
                        MessageBox.Show("ERROR!: No se pudo actualizar correctamente...");
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        public void EliminarProducto(Producto producto)
        {
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    string query = "DELETE FROM Producto WHERE codigo = @codigo";
                    SqlCommand command = new SqlCommand(query, ConexionBD.cn);
                    command.Parameters.AddWithValue("@codigo", producto.Codigo);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro eliminado exitosamente!");
                    }
                    else
                    {
                        MessageBox.Show("ERROR!: No se pudo eliminar correctamente...");

                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Conexion a la base de datos...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        public bool IsValidUser(string username, string password)
        {
            bool isvalid=false;
            try
            {
                var userAdmin = Modelo.UsuarioAdmin.GetInstance();
                if (username == userAdmin.User && password == userAdmin.Pass)
                {
                    GlobalVariables.isAdmin = true;
                    GlobalVariables.user = "Administrador";
                    GlobalVariables.id_usuario = userAdmin.Id;
                    MessageBox.Show("Acceso Exitoso! Bienvenido Administrador...");
                    isvalid = true;
                }
                else
                {
                    if (ConexionBD.AbrirConexion())
                    {
                        var command = new SqlCommand($"SELECT id, nombre, apellido, password FROM Credenciales_Acceso INNER JOIN Usuario ON Usuario.id = Credenciales_Acceso.id_usuario WHERE usuario = '{username}' AND estado ='activo'", ConexionBD.cn);
                        var reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string enteredPassword;
                            GlobalVariables.id_usuario = reader.GetInt32(0);
                            string nombre = reader.GetString(1).Trim();
                            string apellido = reader.GetString(2).Trim();
                            var storedPassword = reader.GetString(3);

                            // Encriptar la contraseña ingresada por el usuario con SHA256
                            using (var sha256 = SHA256.Create())
                            {
                                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                                string hashedPassword = Convert.ToBase64String(hash);
                                enteredPassword = hashedPassword;
                            }
                            // Comparar las contraseñas encriptadas


                            if(enteredPassword == storedPassword)
                            {
                                GlobalVariables.user = nombre + " " + apellido;
                                GlobalVariables.isAdmin = false;
                                MessageBox.Show("Acceso Exitoso! Bienvenido " + nombre);
                                isvalid = true;
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR!: Conexion a la base de datos...");
                        isvalid = false;
                    }
                }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
            return isvalid;
        }
    }

}
