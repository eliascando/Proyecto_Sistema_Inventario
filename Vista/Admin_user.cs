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
    public partial class Admin_Users : Form
    {
        public Admin_Users()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Controlador.UsuarioCtrl control = new Controlador.UsuarioCtrl();
            Update_user form = new Update_user(this);
            if (gridUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridUsers.SelectedRows[0];
                form.txtUId.Text = selectedRow.Cells[0].Value.ToString().Trim();
                form.txtUNombre.Text = selectedRow.Cells[1].Value.ToString().Trim();
                form.txtUApellido.Text = selectedRow.Cells[2].Value.ToString().Trim();
                form.txtUTelefono.Text = selectedRow.Cells[3].Value.ToString().Trim();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR! Debe elegir un producto...");
            }
        }
        BindingSource bindingSource = new BindingSource();

        private void Admin_Users_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        public void CargarTabla()
        {
            UsuarioCtrl control = new UsuarioCtrl();
            gridUsers.DataSource = bindingSource;
            bindingSource.DataSource = control.Mostrar();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltro.Text) || cboFilter.SelectedIndex == -1)
            {
                bindingSource.RemoveFilter();
                return;
            }

            string filterColumn = cboFilter.SelectedItem.ToString();
            string filterText = txtFiltro.Text;

            // Filtrar los datos utilizando la propiedad Filter del BindingSource
            bindingSource.Filter = $"{filterColumn} LIKE '%{filterText}%'";
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
