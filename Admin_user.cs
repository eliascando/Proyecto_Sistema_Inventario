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

                    var user = new Usuario("","","","","","")
                    {
                        Nombre = values[0],
                        Apellido = values[1],
                        Id = values[2],
                        Telefono = values[3],
                        User = values[4],
                        Pass = values[5]
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

            if (txtFiltro.Text == "")
            {
                gridUsers.DataSource = users;
            }
            else
            {
                string filter = txtFiltro.Text;
                List<Usuario> filteredUsers = users.Where(x => x.Nombre.Contains(filter)).ToList();
                gridUsers.DataSource = filteredUsers;
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}