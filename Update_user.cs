using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Sistema_Inventario
{
    public partial class Update_user : Form
    {
        public Update_user()
        {
            InitializeComponent();

        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }

        private void txtUId_TextChanged(object sender, EventArgs e)
        {
            txtUId.ReadOnly= true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id_buscar = txtUId.Text;
            try
            {
                string path = "usuarios.csv";
                string tempPath = "temp.csv";
                List<string[]> usuarios = new List<string[]>();
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        if (values[2] == id_buscar)
                        {
                            values[0] = txtUNombre.Text;
                            values[1] = txtUApellido.Text;
                            values[3] = txtUTelefono.Text;
                            values[4] = values[4];
                            values[5] = values[5];
                            values[6] = cmbEstado.Text;
                        }
                        usuarios.Add(values);
                    }
                }
                using (var writer = new StreamWriter(tempPath))
                {
                    foreach (string[] values in usuarios)
                    {
                        writer.WriteLine(string.Join(",", values));
                    }
                }
                File.Replace(tempPath, path, null);
                MessageBox.Show("Usuario Actualizado Correctamente!");
                Admin_user admin = new Admin_user();
                admin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void Update_user_Load(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Admin_user admin = new Admin_user();
            admin.Show();
            this.Close();
        }
    }
}
