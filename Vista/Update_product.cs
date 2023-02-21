using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class Update_product : Form
    {
        private Admin_product consultaForm;
        public Update_product(Admin_product consultaForm)
        {
            InitializeComponent();
            this.consultaForm = consultaForm;
        }

        private void Update_product_Load(object sender, EventArgs e)
        {

        }

        private void txtUPVP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas guardar estos cambios?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ProductoCtrl control = new ProductoCtrl();
                control.Actualizar(txtUNombre.Text, txtUCodigo.Text, txtUStock.Text, txtUPVP.Text, txtUCosto.Text);
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
