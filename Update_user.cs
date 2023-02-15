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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.VisualBasic;
using System.Reflection;

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
            string nombre = txtUNombre.Text;
            string apellido = txtUApellido.Text;
            string telefono = txtUTelefono.Text;
            string estado = cmbEstado.Text;

            try
            {
                using (var connection = new SqlConnection("Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True"))
                {
                    connection.Open();
                    var command = new SqlCommand($"UPDATE Usuario SET nombre = '{nombre}', apellido = '{apellido}', telefono = '{telefono}', estado = '{estado}' FROM Usuario INNER JOIN Credenciales_Acceso ON Usuario.id = Credenciales_Acceso.id_usuario WHERE Usuario.id = '{id_buscar}'", connection);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario Actualizado Correctamente!");
                        Admin_user admin = new Admin_user();
                        admin.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún usuario con el ID especificado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            admin.ShowDialog();
            this.Close();
        }
    }
}
