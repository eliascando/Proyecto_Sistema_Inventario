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

namespace Vista
{
    public partial class Create_user : Form
    {
        public Create_user()
        {
            InitializeComponent();
            mostrarPass.CheckedChanged += mostrarPass_CheckedChanged;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            UsuarioCtrl control = new UsuarioCtrl();
            control.Guardar(txtId.Text.Trim(),txtNombre.Text.Trim(),txtApellido.Text.Trim(),txtTelefono.Text.Trim(),txtUser.Text.Trim(),txtPass.Text.Trim());
            LimpiarControles(this);
        }
        private void LimpiarControles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                else if (c.HasChildren)
                {
                    LimpiarControles(c);
                }
            }
        }
        private bool passwordHidden = true;

        private void mostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            passwordHidden = !mostrarPass.Checked;
            txtPass.UseSystemPasswordChar = passwordHidden;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = passwordHidden;
        }

        private void Create_user_Load(object sender, EventArgs e)
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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTelefono.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
