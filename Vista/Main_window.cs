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
using Modelo;

namespace Vista
{
    public partial class Main_window : Form
    {
        Login loginForm;
        public Main_window(Login loginForm)
        {
            InitializeComponent();
            lblUser.Text = Modelo.GlobalVariables.user;
            this.FormClosing += Main_windows_FormClosing;
            this.loginForm = loginForm;
            if (GlobalVariables.isAdmin == false)
            {
                actividades_menu.Visible = false;
                usuario_menu.Visible = false;
            }
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_product crear = new Create_product();
            crear.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_product admin = new Admin_product();
            admin.ShowDialog();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_in stock = new Stock_in();
            stock.ShowDialog();
        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_user crear = new Create_user();
            crear.ShowDialog();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_Users admin = new Admin_Users();
            admin.ShowDialog();
        }

        private void Main_window_Load(object sender, EventArgs e)
        {

        }
        private void Main_windows_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Close();
            loginForm.Dispose();
            Environment.Exit(0);
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Cerrar Sesión?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Dispose();
                loginForm.Show();
            }
        }

        private void registro_actividades_Click(object sender, EventArgs e)
        {
            Activity_log activity_Log = new Activity_log();
            activity_Log.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de acerca = new Acerca_de();
            acerca.ShowDialog();
        }

        private void registroDeInicioDeSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_log inicio = new Login_log();
            inicio.ShowDialog();
        }
    }
}
