using Microsoft.VisualBasic.Logging;
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
    public partial class Consult_products : Form
    {
        private BindingSource bindingSource;

        public Consult_products()
        {
            InitializeComponent();
            if (GlobalVaribales.isAdmin == false)
            {
                btnActualizar.Visible = false;
            }
            else
            {
                btnActualizar.Visible = true;
            }
            try
            {
            // Crear el BindingSource y configurarlo como origen de datos del DataGridView
            bindingSource = new BindingSource();
            gridProducts.DataSource = bindingSource;

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
            }catch(Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }

        private void gridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Consult_products_Load(object sender, EventArgs e)
        {
          

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                    Update_products form = new Update_products();
                    if (gridProducts.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = gridProducts.SelectedRows[0];
                        form.txtUNombre.Text = selectedRow.Cells[0].Value.ToString();
                        form.txtUCodigo.Text = selectedRow.Cells[1].Value.ToString();
                        form.txtUStock.Text = selectedRow.Cells[2].Value.ToString();
                        form.txtUCosto.Text = selectedRow.Cells[3].Value.ToString();
                        form.txtUPVP.Text = selectedRow.Cells[4].Value.ToString();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR! Debe elegir un producto...");
                    }

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR!" + ex);
            }      
           
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltro.Text) || cboFilter.SelectedIndex == -1)
            {
                bindingSource.RemoveFilter();
                return;
            }

            string filterColumn = cboFilter.SelectedItem.ToString();
            string filterText = txtFiltro.Text;

            // Filtrar los datos utilizando la propiedad Filter del BindingSource
            bindingSource.Filter = $"{filterColumn} LIKE '%{filterText}%'";
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void gridProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (gridProducts.Columns[e.ColumnIndex].Name == "Precio" && gridProducts.Columns[e.ColumnIndex].Name == "Costo" && e.Value != null)
            {
                double value = (double)e.Value;
                e.Value = value.ToString("N2");
                e.FormattingApplied = true;
            }
        }
    }
}
