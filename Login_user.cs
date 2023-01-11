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
    public partial class Login_user : Form
    {
        public Login_user()
        {
            InitializeComponent();
            checkVerPass.CheckedChanged += checkVerPass_CheckedChanged;

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            Usuario user = new Usuario("", "", "", "", "", "");
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Ingrese un nombre de usuario");
                return;
            }

            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Ingrese una contraseña");
                return;
            }

            if (user.IsValidUser(username, password))
            {
                MessageBox.Show("Acceso Exitoso!");
                Main_windows main = new Main_windows();
                main.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta...");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas Salir?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }          
        }

        private void Login_user_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void checkVerPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !checkVerPass.Checked;
        }
    }
}
