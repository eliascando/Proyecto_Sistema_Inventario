using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            checkVerPass.CheckedChanged += checkVerPass_CheckedChanged;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioCtrl usuario = new UsuarioCtrl();
            if (usuario.Login(txtUser.Text.Trim(), txtPass.Text.Trim()))
            {
                Main_window main= new Main_window(this);
                main.Show();
                checkVerPass.Checked = false;
                this.Hide();
            }
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desa Salir?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
                this.Dispose();
                Environment.Exit(0);
            }
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private bool passwordHidden = true;
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = passwordHidden;
        }

        private void checkVerPass_CheckedChanged(object sender, EventArgs e)
        {
            passwordHidden = !checkVerPass.Checked;
            txtPass.UseSystemPasswordChar = passwordHidden;
        }
    }
}
