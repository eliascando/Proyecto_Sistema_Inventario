using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Sistema_Inventario
{
    public partial class Create_user : Form
    {
        public Create_user()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mostrarPass_CheckedChanged(object sender, EventArgs e)
        {     
            if (mostrarPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }

        }

        private void TxtPass_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("usuarios.csv"))
                {
                    File.Create("usuarios.csv").Close();
                }
                Usuario user = new Usuario();
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellido.Text;
                user.Id = txtId.Text;
                user.Telefono = txtTelefono.Text;
                user.User = txtUser.Text;
                user.Pass = txtPass.Text;
                user.Estado = "activo";

                if (string.IsNullOrEmpty(txtNombre.Text) ||
                   string.IsNullOrEmpty(txtApellido.Text) ||
                   string.IsNullOrEmpty(txtId.Text) ||
                   string.IsNullOrEmpty(txtTelefono.Text) ||
                   string.IsNullOrEmpty(txtUser.Text) ||
                   string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("ERROR! Debe llenar todos los campos...");
                    return;
                }

                List<Usuario> usuarios = new List<Usuario>();

                string[] lines = File.ReadAllLines("usuarios.csv");
                bool existe = false;
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    if (values[2] == txtId.Text)
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    // Agrega el usuario al archivo
                    using (StreamWriter sw = new StreamWriter("usuarios.csv", true))
                    {
                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6}", user.Nombre, user.Apellido, user.Id, user.Telefono, user.User, user.Pass, user.Estado);
                        sw.WriteLine(row);
                    }
                    MessageBox.Show("Usuario Registrado Exitosamente!");

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtId.Text = "";
                    txtTelefono.Text = "";
                    txtUser.Text = "";
                    txtPass.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR! Usuario ya registrado...");
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtId.Text = "";
                    txtTelefono.Text = "";
                    txtUser.Text = "";
                    txtPass.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!" + ex);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtId.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Create_user_Load(object sender, EventArgs e)
        {

        }
    }
}
