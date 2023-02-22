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
                    using (SqlCommand cmd = new SqlCommand("GuardarProducto", ConexionBD.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                        cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@stock", producto.Stock);
                        cmd.Parameters.AddWithValue("@precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@costo", producto.Costo);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto registrado exitosamente!");
                            GuardarActividad(GlobalVariables.id_usuario, "Nuevo Producto", producto);
                        }
                        else
                        {
                            MessageBox.Show("ERROR!: Producto ya existe...");
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
                    string password = usuario.Pass;
                    using (var sha256 = SHA256.Create())
                    {
                        byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                        string hashedPassword = Convert.ToBase64String(hash);
                        usuario.Pass = hashedPassword;
                    }
                    using (SqlCommand cmd = new SqlCommand("GuardarUsuario", ConexionBD.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", usuario.Id);
                        cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        cmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                        cmd.Parameters.AddWithValue("@usuario", usuario.User);
                        cmd.Parameters.AddWithValue("password", usuario.Pass);
                        cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado exitosamente!");
                        }
                        else
                        {
                            MessageBox.Show("ERROR!: Usuario ya existe...");
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
        public void GuardarActividad(int id_usuario,string tipo_actividad,Producto producto)
        {
            try
            {
                if (ConexionBD.AbrirConexion())
                {
                    Actividad actividad = new Actividad();
                    actividad.Fechayhora = DateTime.Now;
                    actividad.Stock = producto.Stock;
                    actividad.Tipo_actividad = tipo_actividad;
                    actividad.Codigo_producto = producto.Codigo;
                    actividad.Nombre_producto = producto.Nombre;
                    actividad.Id_usuario = id_usuario;
                    using (SqlCommand cmd = new SqlCommand("GuardarActividad", ConexionBD.cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fechayhora", actividad.Fechayhora);
                        cmd.Parameters.AddWithValue("@stock", actividad.Stock);
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

                    SqlCommand cmd = new SqlCommand("ObtenerProductos", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
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

                    SqlCommand cmd = new SqlCommand("ObtenerUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
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
                    dt.Columns.Add("Stock");

                    SqlCommand cmd = new SqlCommand("ObtenerActividad", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
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
                        row["Stock"] = reader.GetInt32(7);
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
                    SqlCommand cmd = new SqlCommand("ActualizarProducto", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@stock", producto.Stock);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@costo", producto.Costo);
                    cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                    int rowsAffected = cmd.ExecuteNonQuery();
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
                    var cmd = new SqlCommand("ActualizarUsuario", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", usuario.Id);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@telefono", usuario.Telefono);
                    cmd.Parameters.AddWithValue("@estado", usuario.Estado);
                    int rowsAffected = cmd.ExecuteNonQuery();
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
                    SqlCommand cmdObtenerStockActual = new SqlCommand("ObtenerStockActual", ConexionBD.cn);
                    cmdObtenerStockActual.CommandType = CommandType.StoredProcedure;
                    cmdObtenerStockActual.Parameters.AddWithValue("@codigo", producto.Codigo);

                    SqlParameter stockActualParameter = new SqlParameter("@stockActual", SqlDbType.Int);
                    stockActualParameter.Direction = ParameterDirection.Output;
                    cmdObtenerStockActual.Parameters.Add(stockActualParameter);
                    cmdObtenerStockActual.ExecuteNonQuery();

                    int stockActual = (int)stockActualParameter.Value;
                    int nuevoStock = stockActual + ingreso;

                    SqlCommand cmdActualizarStock = new SqlCommand("ActualizarStock", ConexionBD.cn);
                    cmdActualizarStock.CommandType = CommandType.StoredProcedure;
                    cmdActualizarStock.Parameters.AddWithValue("@codigo", producto.Codigo);
                    cmdActualizarStock.Parameters.AddWithValue("@cantidad", ingreso);
                    SqlParameter filasActualizadasParameter = new SqlParameter("@filasActualizadas", SqlDbType.Int);
                    filasActualizadasParameter.Direction = ParameterDirection.Output;
                    cmdActualizarStock.Parameters.Add(filasActualizadasParameter);
                    cmdActualizarStock.ExecuteNonQuery();
                    int filasActualizadas = (int)filasActualizadasParameter.Value;
                    if (filasActualizadas > 0)
                    {
                        MessageBox.Show("Stock ingresado en producto!");
                        producto.Stock = ingreso;
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
                    SqlCommand cmd = new SqlCommand("EliminarProducto", ConexionBD.cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro eliminado exitosamente!");
                        GuardarActividad(GlobalVariables.id_usuario, "Eliminar Producto", producto);
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
                        var cmd = new SqlCommand("ValidarUsuario", ConexionBD.cn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario", username);
                        var reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string enteredPassword;
                            GlobalVariables.id_usuario = reader.GetInt32(0);
                            string nombre = reader.GetString(1).Trim();
                            string apellido = reader.GetString(2).Trim();
                            var storedPassword = reader.GetString(3);

                            using (var sha256 = SHA256.Create())
                            {
                                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                                string hashedPassword = Convert.ToBase64String(hash);
                                enteredPassword = hashedPassword;
                            }

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
