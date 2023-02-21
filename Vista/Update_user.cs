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
    public partial class Update_user : Form
    {
        Admin_Users consultaForm;
        public Update_user(Admin_Users consultaForm)
        {
            InitializeComponent();
            this.consultaForm = consultaForm;
        }

        private void Update_user_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas actualizar el usuario?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                UsuarioCtrl control = new UsuarioCtrl();
                control.Actualizar(txtUId.Text.Trim(),txtUNombre.Text.Trim(),txtUApellido.Text.Trim(),txtUTelefono.Text.Trim(),cmbEstado.Text.Trim());
                consultaForm.CargarTabla();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
