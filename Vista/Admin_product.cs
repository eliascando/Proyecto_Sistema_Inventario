using Controlador;
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

namespace Vista
{
    public partial class Admin_product : Form
    {
        public Admin_product()
        {
            InitializeComponent();
            if (GlobalVariables.isAdmin == false)
            {
                btnActualizar.Visible = false;
                btn_Eliminar.Visible = false;
            }
        }
        BindingSource bindingSource = new BindingSource();
        private void Admin_product_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        public void CargarTabla()
        {
            Controlador.ProductoCtrl control = new Controlador.ProductoCtrl();
            bindingSource.DataSource = control.Mostrar();
            gridProducts.DataSource = bindingSource;

            gridProducts.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == gridProducts.Columns["Costo"].Index ||
                    e.ColumnIndex == gridProducts.Columns["Precio"].Index)
                {
                    if (e.Value != null && float.TryParse(e.Value.ToString(), out float value))
                    {
                        e.Value = value.ToString("C2");
                    }
                }
            };
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Controlador.ProductoCtrl control = new Controlador.ProductoCtrl();
            Update_product form = new Update_product(this);
            if (gridProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridProducts.SelectedRows[0];
                form.txtUNombre.Text = selectedRow.Cells[0].Value.ToString().Trim();
                form.txtUCodigo.Text = selectedRow.Cells[1].Value.ToString().Trim();
                form.txtUStock.Text = selectedRow.Cells[2].Value.ToString().Trim();
                form.txtUCosto.Text = selectedRow.Cells[3].Value.ToString().Trim();
                form.txtUPVP.Text = selectedRow.Cells[4].Value.ToString().Trim();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR! Debe elegir un producto...");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Controlador.ProductoCtrl control = new Controlador.ProductoCtrl();
            if (gridProducts.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas Eliminar este producto?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    DataGridViewRow selectedRow = gridProducts.SelectedRows[0];
                    control.Eliminar(selectedRow.Cells[0].Value.ToString().Trim(), selectedRow.Cells[1].Value.ToString().Trim(), selectedRow.Cells[2].Value.ToString().Trim(), selectedRow.Cells[3].Value.ToString().Trim(), selectedRow.Cells[4].Value.ToString().Trim());
                    CargarTabla();
                }
                
            }
            else
            {
                MessageBox.Show("ERROR! Debe elegir un producto...");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
