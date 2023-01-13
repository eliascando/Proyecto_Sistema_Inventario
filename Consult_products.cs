using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Sistema_Inventario
{
    public partial class Consult_products : Form
    {
        public Consult_products()
        {
            Login_user login = new Login_user();
            InitializeComponent();
            try
            {
                gridProducts.ReadOnly = true;
                string filePath = "productos.csv";
                var products = new List<Producto>();

                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        var product = new Producto()
                        {
                            Nombre = values[0],
                            Codigo= values[1],
                            Stock = int.Parse(values[2]),
                            Precio = double.Parse(values[3]),
                            Costo = double.Parse(values[4])
                        };
                        products.Add(product);
                    }
                }
                gridProducts.DataSource = products;
                gridProducts.AutoGenerateColumns = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR! " + ex);
            }
            finally { gridProducts.ResumeLayout(); }
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
                if (GlobalVaribales.isAdmin == true)
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
                }
                else
                {
                    MessageBox.Show("Usuario no tiene acceso...");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("ERROR!" + ex);
            }      
           
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var products = new List<Producto>();
                using (var reader = new StreamReader("productos.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        var product = new Producto()
                        {
                            Nombre = values[0],
                            Codigo = values[1],
                            Stock = int.Parse(values[2]),
                            Costo = double.Parse(values[3]),
                            Precio = double.Parse(values[4])
                        };
                        products.Add(product);
                    }
                }
                if (string.IsNullOrEmpty(txtFiltro.Text) || cboFilter.SelectedIndex == -1)
                {
                    gridProducts.DataSource = products;
                    return;
                }

                var filter = txtFiltro.Text.ToLower();
                IEnumerable<Producto> filteredProducts;
                switch (cboFilter.SelectedItem)
                {
                    case "Nombre":
                        filteredProducts = products.Where(x => x.Nombre.ToLower().Contains(filter));
                        break;
                    case "Codigo":
                        filteredProducts = products.Where(x => x.Codigo.ToLower().Contains(filter));
                        break;
                    default:
                        filteredProducts = products;
                        break;
                }
                gridProducts.DataSource = filteredProducts.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex);
            }
            finally { gridProducts.Refresh(); }
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
