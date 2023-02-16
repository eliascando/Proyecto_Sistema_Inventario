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
        private Admin_user adminUser;
        public Update_user(Admin_user adminUser)
        {
            InitializeComponent();
            this.adminUser = adminUser;
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
                DialogResult result = MessageBox.Show("¿Estás seguro de que desea actualizar Usuario?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    using (var connection = new SqlConnection("Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True"))
                    {
                        connection.Open();
                        var command = new SqlCommand($"UPDATE Usuario SET nombre = '{nombre}', apellido = '{apellido}', telefono = '{telefono}' FROM Usuario INNER JOIN Credenciales_Acceso ON Usuario.id = Credenciales_Acceso.id_usuario WHERE Usuario.id = '{id_buscar}'", connection);
                        command.ExecuteNonQuery();
                        command = new SqlCommand($"UPDATE Credenciales_Acceso SET estado = '{estado}' WHERE id_usuario = '{id_buscar}'", connection);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario Actualizado Correctamente!");
                            adminUser.ActualizarTabla();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún usuario con el ID especificado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: "+ex.Message);
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
            this.Close();
        }
    }
}
