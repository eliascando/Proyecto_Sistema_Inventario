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
    public partial class Stock_in : Form
    {
        public Stock_in()
        {
            InitializeComponent();
            try
            {
                gridSelect.ReadOnly = true;
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
                            Codigo = values[1],
                            Stock = int.Parse(values[2]),
                            Precio = double.Parse(values[3]),
                            Costo = double.Parse(values[4])
                        };
                        products.Add(product);
                    }
                }
                gridSelect.DataSource = products;
                gridSelect.AutoGenerateColumns = true;

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
                if (string.IsNullOrEmpty(txtFiltro.Text) || cmbFiltro.SelectedIndex == -1)
                {
                    gridSelect.DataSource = products;
                    return;
                }

                var filter = txtFiltro.Text;
                IEnumerable<Producto> filteredProducts;
                switch (cmbFiltro.SelectedItem)
                {
                    case "Nombre":
                        filteredProducts = products.Where(x => x.Nombre.Contains(filter));
                        break;
                    case "Código":
                        filteredProducts = products.Where(x => x.Codigo.Contains(filter));
                        break;
                    default:
                        filteredProducts = products;
                        break;
                }
                gridSelect.DataSource = filteredProducts.ToList();
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
                string nombre_buscar;
                string codigo_buscar;
                if (gridSelect.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = gridSelect.SelectedRows[0];
                    nombre_buscar = selectedRow.Cells[0].Value.ToString();
                    codigo_buscar = selectedRow.Cells[1].Value.ToString();
                    string path = "productos.csv";
                    string tempPath = "temp.csv";
                    List<string[]> products = new List<string[]>();
                    using (var reader = new StreamReader(path))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var values = line.Split(',');
                            if (values[1] == codigo_buscar && values[0] == nombre_buscar)
                            {
                                int valor_actual = int.Parse(values[2]);
                                int agregar= int.Parse(txtUStock.Text);
                                int agregado = valor_actual + agregar;

                                values[0] = values[0];
                                values[1] = values[1];
                                values[2] = agregado.ToString();
                                values[3] = values[3];
                                values[4] = values[4];
                            }
                            products.Add(values);
                        }
                    }
                    using (var writer = new StreamWriter(tempPath))
                    {
                        foreach (string[] values in products)
                        {
                            writer.WriteLine(string.Join(",", values));
                        }
                    }
                    File.Replace(tempPath, path, null);
                    MessageBox.Show("Stock Ingresado en Producto!");
                    txtUStock.Text = "";
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

            }
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
