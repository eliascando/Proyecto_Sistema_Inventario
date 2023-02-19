using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Sistema_Inventario
{
    public partial class Registro_de_Actividades : Form
    {
        private BindingSource bindingSource;
        public Registro_de_Actividades()
        {
            ConexionBD.AbrirConexion();
            try
            {
                InitializeComponent();
                // Realizar consulta SQL para obtener los datos necesarios
                string query = "SELECT Actividad.id_actividad, Actividad.fechayhora, Usuario.id, Usuario.nombre, Usuario.apellido, Producto.nombre, Actividad.ingreso_stock " +
                    "FROM Actividad " +
                    "INNER JOIN Usuario ON Actividad.id_usuario = Usuario.id " +
                    "INNER JOIN Producto ON Actividad.codigo_producto = Producto.codigo";

                // Crear adaptador de datos y llenar DataTable con resultado de consulta
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, ConexionBD.cn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Configurar columnas en el DataGridView
                    gridActividades.AutoGenerateColumns = false;

                    DataGridViewTextBoxColumn colIdActividad = new DataGridViewTextBoxColumn();
                    colIdActividad.DataPropertyName = "id_actividad";
                    colIdActividad.HeaderText = "ID Actividad";
                    gridActividades.Columns.Add(colIdActividad);

                    DataGridViewTextBoxColumn colFechaHora = new DataGridViewTextBoxColumn();
                    colFechaHora.DataPropertyName = "fechayhora";
                    colFechaHora.HeaderText = "Fecha y Hora";
                    gridActividades.Columns.Add(colFechaHora);

                    DataGridViewTextBoxColumn colIdUsuario = new DataGridViewTextBoxColumn();
                    colIdUsuario.DataPropertyName = "id";
                    colIdUsuario.HeaderText = "ID Usuario";
                    gridActividades.Columns.Add(colIdUsuario);

                    DataGridViewTextBoxColumn colNombreUsuario = new DataGridViewTextBoxColumn();
                    colNombreUsuario.DataPropertyName = "nombre";
                    colNombreUsuario.HeaderText = "Nombre Usuario";
                    gridActividades.Columns.Add(colNombreUsuario);
                        
                    DataGridViewTextBoxColumn colApellidoUsuario = new DataGridViewTextBoxColumn();
                    colApellidoUsuario.DataPropertyName = "apellido";
                    colApellidoUsuario.HeaderText = "Apellido Usuario";
                    gridActividades.Columns.Add(colApellidoUsuario);

                    DataGridViewTextBoxColumn colNombreProducto = new DataGridViewTextBoxColumn();
                    colNombreProducto.DataPropertyName = "nombre1";
                    colNombreProducto.HeaderText = "Nombre Producto";
                    gridActividades.Columns.Add(colNombreProducto);

                    DataGridViewTextBoxColumn colIngresoStock = new DataGridViewTextBoxColumn();
                    colIngresoStock.DataPropertyName = "ingreso_stock";
                    colIngresoStock.HeaderText = "Ingreso Stock";
                    gridActividades.Columns.Add(colIngresoStock);

                    // Asignar DataTable al DataGridView
                    gridActividades.DataSource = dt;
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
        private void cargarDatos()
        {
            try
            {
                // Obtener los valores seleccionados en los controles
                DateTime fecha = dateTime.Value;
                string parametroBusqueda = txtFiltro.Text;
                string campoBusqueda = cboFilter.SelectedItem.ToString();

                // Realizar la consulta SQL con el filtro de búsqueda
                string query = "SELECT Actividad.id_actividad, Actividad.fechayhora, Usuario.id, Usuario.nombre, Usuario.apellido, Producto.nombre, Actividad.ingreso_stock " +
                    "FROM Actividad " +
                    "INNER JOIN Usuario ON Actividad.id_usuario = Usuario.id " +
                    "INNER JOIN Producto ON Actividad.codigo_producto = Producto.codigo " +
                    "WHERE Actividad.fechayhora >= @fecha " +
                    "AND " + campoBusqueda + " LIKE '%' + @parametroBusqueda + '%'";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, ConexionBD.cn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@fecha", fecha);
                    adapter.SelectCommand.Parameters.AddWithValue("@parametroBusqueda", parametroBusqueda);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Configurar columnas en el DataGridView
                    gridActividades.AutoGenerateColumns = false;

                    DataGridViewTextBoxColumn colIdActividad = new DataGridViewTextBoxColumn();
                    colIdActividad.DataPropertyName = "id_actividad";
                    colIdActividad.HeaderText = "ID Actividad";
                    gridActividades.Columns.Add(colIdActividad);

                    DataGridViewTextBoxColumn colFechaHora = new DataGridViewTextBoxColumn();
                    colFechaHora.DataPropertyName = "fechayhora";
                    colFechaHora.HeaderText = "Fecha y Hora";
                    gridActividades.Columns.Add(colFechaHora);

                    DataGridViewTextBoxColumn colIdUsuario = new DataGridViewTextBoxColumn();
                    colIdUsuario.DataPropertyName = "id";
                    colIdUsuario.HeaderText = "ID Usuario";
                    gridActividades.Columns.Add(colIdUsuario);

                    DataGridViewTextBoxColumn colNombreUsuario = new DataGridViewTextBoxColumn();
                    colNombreUsuario.DataPropertyName = "nombre";
                    colNombreUsuario.HeaderText = "Nombre Usuario";
                    gridActividades.Columns.Add(colNombreUsuario);

                    DataGridViewTextBoxColumn colApellidoUsuario = new DataGridViewTextBoxColumn();
                    colApellidoUsuario.DataPropertyName = "apellido";
                    colApellidoUsuario.HeaderText = "Apellido Usuario";
                    gridActividades.Columns.Add(colApellidoUsuario);

                    DataGridViewTextBoxColumn colNombreProducto = new DataGridViewTextBoxColumn();
                    colNombreProducto.DataPropertyName = "nombre1";
                    colNombreProducto.HeaderText = "Nombre Producto";
                    gridActividades.Columns.Add(colNombreProducto);

                    DataGridViewTextBoxColumn colIngresoStock = new DataGridViewTextBoxColumn();
                    colIngresoStock.DataPropertyName = "ingreso_stock";
                    colIngresoStock.HeaderText = "Ingreso Stock";
                    gridActividades.Columns.Add(colIngresoStock);

                    // Asignar DataTable al DataGridView
                    gridActividades.DataSource = dt;
                }
            
            }catch(Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registro_de_Actividades_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
