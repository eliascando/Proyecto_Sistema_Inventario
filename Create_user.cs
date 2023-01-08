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
            int cambio = 1;
        }

        private void mostrarPass_CheckedChanged(object sender, EventArgs e)
        {     
            if (mostrarPass.Checked == false)
            {
                if (txtPass.UseSystemPasswordChar)
                {
                    txtPass.UseSystemPasswordChar = false;
                }
                else
                {
                    txtPass.UseSystemPasswordChar = true;
                }
            }
        }
    }
}
