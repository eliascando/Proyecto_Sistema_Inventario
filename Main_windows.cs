using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Proyecto_Sistema_Inventario
{
    public partial class Main_windows : Form
    {
        public Main_windows()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_user crear = new Create_user();
            crear.ShowDialog();

        }
    }
}
