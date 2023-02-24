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
    public partial class Login_log : Form
    {
        public Login_log()
        {
            InitializeComponent();
        }

        private void Login_log_Load(object sender, EventArgs e)
        {
            CargarTabla();
        }
        BindingSource bindingSource = new BindingSource();
        private DataTable tablaOriginal;
        public void CargarTabla()
        {
            Controlador.ActividadCtrl control = new Controlador.ActividadCtrl();
            tablaOriginal = control.DatosInicioSesion();
            bindingSource.DataSource = tablaOriginal;
            gridActividades.DataSource = bindingSource;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Filtrar()
        {
            try
            {
                string filterColumn = cboFilter.SelectedItem.ToString().Trim();
                string filterText = txtFiltro.Text;

                if (cboFilter.SelectedItem != null)
                {
                    filterColumn = cboFilter.SelectedItem.ToString().Trim();
                    if (dateTime.Value != null)
                    {
                        DateTime fechaSeleccionada = dateTime.Value;
                        string fechaCorta = fechaSeleccionada.ToShortDateString();
                        bindingSource.Filter = $"CONVERT( [Fecha y Hora], 'System.String') LIKE '{fechaCorta}%' AND [{filterColumn}] LIKE '%{filterText}%'";
                    }
                    else
                    {
                        bindingSource.Filter = $"[{filterColumn}] LIKE '%{filterText}%'";
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!: Debe elegir un parámetro de busqueda");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!:" + ex);
            }

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
