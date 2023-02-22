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
    public partial class Stock_in : Form
    {
        public Stock_in()
        {
            InitializeComponent();
        }
        BindingSource bindingSource = new BindingSource();
        private void Stock_in_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        public void CargarTabla()
        {
            Controlador.ProductoCtrl control = new Controlador.ProductoCtrl();
            bindingSource.DataSource = control.Mostrar();
            gridSelect.DataSource = bindingSource;

            gridSelect.CellFormatting += (sender, e) =>
            {
                if (e.ColumnIndex == gridSelect.Columns["Costo"].Index ||
                    e.ColumnIndex == gridSelect.Columns["Precio"].Index)
                {
                    if (e.Value != null && float.TryParse(e.Value.ToString(), out float value))
                    {
                        e.Value = value.ToString("C2");
                    }
                }
            };
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Controlador.ProductoCtrl control = new Controlador.ProductoCtrl();
            if (gridSelect.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridSelect.SelectedRows[0];                
                control.AgregarStock(txtUStock.Text,selectedRow.Cells[0].Value.ToString().Trim(), selectedRow.Cells[1].Value.ToString().Trim(), selectedRow.Cells[2].Value.ToString().Trim(), selectedRow.Cells[3].Value.ToString().Trim(), selectedRow.Cells[4].Value.ToString().Trim());
                CargarTabla();
            }
            else
            {
                MessageBox.Show("ERROR! Debe elegir un producto...");
            }
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFiltro.Text) || cmbFiltro.SelectedIndex == -1)
            {
                bindingSource.RemoveFilter();
                return;
            }

            string filterColumn = cmbFiltro.SelectedItem.ToString();
            string filterText = txtFiltro.Text;

            // Filtrar los datos utilizando la propiedad Filter del BindingSource
            bindingSource.Filter = $"{filterColumn} LIKE '%{filterText}%'";
        }

        private void txtUStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtUStock.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
