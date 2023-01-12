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
    public partial class Main_windows_user : Form
    {
        public Main_windows_user()
        {
            InitializeComponent();
            Login_user login = new Login_user();
            login.Close();
        }

        private void Main_windows_user_Load(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas Cerrar Sesión?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register_products registrar = new Register_products();
            registrar.Show();
        }
    }
}
