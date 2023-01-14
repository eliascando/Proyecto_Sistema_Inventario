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
    public partial class Main_windows : Form
    {
        public Main_windows()
        {
            InitializeComponent();
            lblUser.Text = GlobalVaribales.user;
            if(GlobalVaribales.isAdmin == false)
            {
                usuario_menu.Visible = false;
            }
            else
            {
                usuario_menu.Visible = true;
            }
            
        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_user crear = new Create_user();
            crear.ShowDialog();
        }

        private void administrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin_user admin = new Admin_user();
            admin.ShowDialog();
        }

        private void Main_windows_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ver_ayuda ayuda = new Ver_ayuda();
            ayuda.ShowDialog();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_products registrar = new Register_products();
            registrar.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consult_products consultar = new Consult_products();
            consultar.ShowDialog();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_in ingreso = new Stock_in();
            ingreso.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas Cerrar Sesión?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                GlobalVaribales.user = "";
                this.Hide();
                Login_user login = new Login_user();
                login.ShowDialog();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca_de acerca = new Acerca_de();
            acerca.ShowDialog();
        }
    }
}
