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

namespace Proyecto_Sistema_Inventario
{
    public partial class Stock_in : Form
    {
        private BindingSource bindingSource;
        public Stock_in()
        {
            InitializeComponent();
            try
            {
                // Crear el BindingSource y configurarlo como origen de datos del DataGridView
                bindingSource = new BindingSource();
                gridSelect.DataSource = bindingSource;
                gridSelect.ReadOnly = true;
                gridSelect.AllowUserToOrderColumns = false;
                gridSelect.AllowUserToResizeColumns = false;
                gridSelect.AllowUserToResizeRows = false;

                // Crear un DataTable y agregar las columnas correspondientes
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Nombre");
                dataTable.Columns.Add("Codigo");
                dataTable.Columns.Add("Stock");
                dataTable.Columns.Add("Costo");
                dataTable.Columns.Add("Precio");


                // Recuperar los datos de los productos de la base de datos y agregarlos al DataTable
                using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT codigo, nombre, stock, costo, precio FROM Producto", cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        row["Codigo"] = reader.GetInt32(0).ToString();
                        row["Nombre"] = reader.GetString(1);
                        row["Stock"] = reader.GetInt32(2).ToString();
                        row["Costo"] = reader.GetFloat(3).ToString();
                        row["Precio"] = reader.GetFloat(4).ToString();
                        dataTable.Rows.Add(row);
                    }
                }
                // Establecer el DataTable como origen de datos del BindingSource
                bindingSource.DataSource = dataTable;

                // Formato Moneda para las columnas Costo y Precio
                gridSelect.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == gridSelect.Columns["Costo"].Index ||
                        e.ColumnIndex == gridSelect.Columns["Precio"].Index)
                    {
                        if (e.Value != null && float.TryParse(e.Value.ToString(), out float value))
                        {
                            e.Value = value.ToString("C2");
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFiltro.Text) || cmbFiltro.SelectedIndex == -1)
                {
                    bindingSource.RemoveFilter();
                    return;
                }

                string filterColumn = cmbFiltro.SelectedItem.ToString();
                string filterText = txtFiltro.Text;

                // Filtrar los datos utilizando la propiedad Filter del BindingSource
                bindingSource.Filter = $"{filterColumn} LIKE '%{filterText}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex);
            }
            finally { gridSelect.Refresh(); }
        }

        private void Stock_in_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            try
            {
                string codigo_buscar;
                if (gridSelect.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = gridSelect.SelectedRows[0];
                    codigo_buscar = selectedRow.Cells[1].Value.ToString();

                    using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True"))
                    {
                        cn.Open();

                        // Obtener el stock actual del producto
                        SqlCommand cmdStockActual = new SqlCommand("SELECT stock FROM Producto WHERE codigo = @codigo", cn);
                        cmdStockActual.Parameters.AddWithValue("@codigo", codigo_buscar);
                        int stockActual = (int)cmdStockActual.ExecuteScalar();

                        // Sumar la cantidad ingresada al stock actual
                        int cantidadIngresada = int.Parse(txtUStock.Text);
                        int nuevoStock = stockActual + cantidadIngresada;

                        // Actualizar el stock en la base de datos
                        SqlCommand cmdActualizarStock = new SqlCommand("UPDATE Producto SET stock = @stock WHERE codigo = @codigo", cn);
                        cmdActualizarStock.Parameters.AddWithValue("@stock", nuevoStock);
                        cmdActualizarStock.Parameters.AddWithValue("@codigo", codigo_buscar);
                        int filasActualizadas = cmdActualizarStock.ExecuteNonQuery();

                        if (filasActualizadas > 0)
                        {
                            MessageBox.Show("Stock ingresado en producto!");
                            txtUStock.Text = "";
                            ActualizarTabla();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún producto con el código especificado!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR! Debe elegir un producto...");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        public void ActualizarTabla()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nombre");
            dataTable.Columns.Add("Codigo");
            dataTable.Columns.Add("Stock");
            dataTable.Columns.Add("Costo");
            dataTable.Columns.Add("Precio");

            using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True"))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT codigo, nombre, stock, costo, precio FROM Producto", cn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRow row = dataTable.NewRow();
                    row["Codigo"] = reader.GetInt32(0).ToString();
                    row["Nombre"] = reader.GetString(1);
                    row["Stock"] = reader.GetInt32(2).ToString();
                    row["Costo"] = reader.GetFloat(3).ToString();
                    row["Precio"] = reader.GetFloat(4).ToString();
                    dataTable.Rows.Add(row);
                }
                cn.Close();
            }

            bindingSource.DataSource = dataTable;
            gridSelect.DataSource = bindingSource;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDA_Click(object sender, EventArgs e)
        {

        }

        private void gridSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
