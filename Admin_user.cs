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
            gridUsers.ReadOnly= true;
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
            gridUsers.AutoGenerateColumns= true;
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
                case "Telefono":
                    filteredUsers = users.Where(x => x.Telefono.Contains(filter));
                    break;
                case "Estado":
                    filteredUsers = users.Where(x => x.Estado.Contains(filter));
                    break;
                default:
                    filteredUsers = users;
                    break;
            }
            gridUsers.DataSource = filteredUsers.ToList();
        //var users = new List<Usuario>();
        //using (var reader = new StreamReader("usuarios.csv"))
        //{
        //    while (!reader.EndOfStream)
        //    {
        //        var line = reader.ReadLine();
        //        var values = line.Split(',');
        //        var user = new Usuario()
        //        {
        //            Nombre = values[0],
        //            Apellido = values[1],
        //            Id = values[2],
        //            Telefono = values[3],
        //            User = values[4],
        //            Estado = values[6],
        //        };
        //        users.Add(user);
        //        if (txtFiltro.Text == "")
        //        {
        //            gridUsers.DataSource = users;
        //        }
        //        else
        //        {
        //            string filter = txtFiltro.Text;
        //            var filteredUsers = users.Where(x => x.Nombre.Contains(filter)).ToList();
        //            gridUsers.DataSource = filteredUsers;
        //        }
        //    }

        //}

    }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}