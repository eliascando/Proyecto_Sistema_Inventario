using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Sistema_Inventario
{
    public partial class Admin_user : Form
    {
        public Admin_user()
        {
            InitializeComponent();
            try
            {
                gridUsers.ReadOnly = true;
                string filePath = "usuarios.csv";
                var users = new List<Usuario>();

                using (var reader = new StreamReader(filePath))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        var user = new Usuario()
                        {
                            Nombre = values[0],
                            Apellido = values[1],
                            Id = values[2],
                            Telefono = values[3],
                            User = values[4],
                            Estado = values[6],
                        };
                        users.Add(user);
                    }
                }
                gridUsers.DataSource = users;
                gridUsers.AutoGenerateColumns = true;
            }catch (Exception ex)
            {
                MessageBox.Show("ERROR! "+ ex);
            }finally { gridUsers.ResumeLayout(); }
            
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
            try
            {
                var users = new List<Usuario>();
                using (var reader = new StreamReader("usuarios.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        var user = new Usuario()
                        {
                            Nombre = values[0],
                            Apellido = values[1],
                            Id = values[2],
                            Telefono = values[3],
                            User = values[4],
                            Estado = values[6],
                        };
                        users.Add(user);
                    }
                }
                if (string.IsNullOrEmpty(txtFiltro.Text) || cboFilter.SelectedIndex == -1)
                {
                    gridUsers.DataSource = users;
                    return;
                }

                var filter = txtFiltro.Text;
                IEnumerable<Usuario> filteredUsers;
                switch (cboFilter.SelectedItem)
                {
                    case "Nombre":
                        filteredUsers = users.Where(x => x.Nombre.Contains(filter));
                        break;
                    case "Apellido":
                        filteredUsers = users.Where(x => x.Apellido.Contains(filter));
                        break;
                    case "Id":
                        filteredUsers = users.Where(x => x.Id.Contains(filter));
                        break;
                    default:
                        filteredUsers = users;
                        break;
                }
                gridUsers.DataSource = filteredUsers.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!" + ex);
            }finally { gridUsers.Refresh(); }   
           

    }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Update_user form = new Update_user();
            if (gridUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridUsers.SelectedRows[0];
                form.txtUNombre.Text = selectedRow.Cells[0].Value.ToString();
                form.txtUApellido.Text = selectedRow.Cells[1].Value.ToString();
                form.txtUId.Text = selectedRow.Cells[2].Value.ToString();
                form.txtUTelefono.Text = selectedRow.Cells[3].Value.ToString();
                form.ShowDialog();
                string estado = selectedRow.Cells[6].Value.ToString();
                if (estado == "activo")
                {
                    form.cmbEstado.SelectedIndex = 0;
                }else if(estado == "inactivo")
                {
                    form.cmbEstado.SelectedIndex = 1;
                }
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

        internal void ActualizadoCorrecto()
        {
            gridUsers.Refresh();
        }
    }
}