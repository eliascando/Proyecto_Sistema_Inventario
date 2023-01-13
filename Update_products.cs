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
    public partial class Update_products : Form
    {
        public Update_products()
        {
            InitializeComponent();
            txtUCodigo.ReadOnly= true;
        }

        private void Update_products_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string codigo_buscar = txtUCodigo.Text;
            try
            {
                string path = "productos.csv";
                string tempPath = "temp.csv";
                List<string[]> products = new List<string[]>();
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (values[1] == codigo_buscar)
                        {
                            values[0] = txtUNombre.Text;
                            values[1] = values[1];
                            values[2] = txtUStock.Text;
                            values[3] = txtUCosto.Text;
                            values[4] = txtUPVP.Text;
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
                MessageBox.Show("Producto Actualizado Correctamente!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Consult_products consult = new Consult_products();
                consult.ShowDialog();
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Consult_products consult = new Consult_products();
            consult.ShowDialog();
            this.Close();
        }

        private void txtUCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas Eliminar este producto?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines("productos.csv");
                    List<string> linesToKeep = new List<string>();
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');
                    }
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');
                        if (values[1] != txtUCodigo.Text)
                        {
                            linesToKeep.Add(line);
                        }
                        File.WriteAllLines("productos.csv", linesToKeep);
                        MessageBox.Show("Registro eliminado exitosamente!");
                        Consult_products consult = new Consult_products();
                        consult.ShowDialog();
                        this.Close();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("ERROR!"+ex.Message);
                }
                
            }
            
        }
    }
}
