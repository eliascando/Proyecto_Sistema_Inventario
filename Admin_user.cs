using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Sistema_Inventario
{
    public partial class Admin_user : Form
    {
        private BindingSource bindingSource;
        public Admin_user()
        {
            InitializeComponent();
            try
            {
                // Crear el BindingSource y configurarlo como origen de datos del DataGridView
                bindingSource = new BindingSource();
                gridUsers.DataSource = bindingSource;

                // Crear un DataTable y agregar las columnas correspondientes
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Id");
                dataTable.Columns.Add("Nombre");
                dataTable.Columns.Add("Apellido");
                dataTable.Columns.Add("Teléfono");
                dataTable.Columns.Add("Usuario");
                dataTable.Columns.Add("Estado");

                // Recuperar los datos de los usuarios y sus credenciales de la base de datos y agregarlos al DataTable
                using (SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True"))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Usuario.id, nombre, apellido, telefono, usuario, estado FROM Usuario INNER JOIN Credenciales_Acceso ON Usuario.id = Credenciales_Acceso.id_usuario", cn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DataRow row = dataTable.NewRow();
                        row["Id"] = reader.GetInt32(0).ToString();
                        row["Nombre"] = reader.GetString(1);
                        row["Apellido"] = reader.GetString(2);
                        row["Teléfono"] = reader.GetString(3);
                        row["Usuario"] = reader.GetString(4);
                        row["Estado"] = reader.GetString(5);
                        dataTable.Rows.Add(row);
                    }
                }
                // Establecer el DataTable como origen de datos del BindingSource
                bindingSource.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!: " + ex.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Inactivar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            Update_user form = new Update_user();
            if (gridUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridUsers.SelectedRows[0];
                form.txtUId.Text = selectedRow.Cells[0].Value.ToString().Trim(); 
                form.txtUNombre.Text = selectedRow.Cells[1].Value.ToString().Trim();
                form.txtUApellido.Text = selectedRow.Cells[2].Value.ToString().Trim();              
                form.txtUTelefono.Text = selectedRow.Cells[3].Value.ToString().Trim();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR! Debe elegir un usuario para actualizar...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void gridUsers_Enter(object sender, EventArgs e)
        {
            
        }

        private void gridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void gridUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}