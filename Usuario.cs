using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace Proyecto_Sistema_Inventario
{
    public class Usuario
    {
        private String nombre;
        private String apellido;
        private String id;
        private String telefono;
        private String user;
        private String pass;
        private String estado;

        public Usuario()
        {

        }
        public Usuario(string nombre, string apellido, string id, string telefono, string user, string pass, string estado)
        {
            Nombre = nombre;
            Apellido = apellido;
            Id = id;
            Telefono = telefono;
            User = user;
            Pass = pass;
            Estado = estado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Id { get => id; set => id = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Estado { get => estado; set => estado = value; }

        public bool IsValidUser(string username, string password)
        {
            bool isvalid;
            using (var connection = new SqlConnection("Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True"))
            {
                connection.Open();
                var command = new SqlCommand($"SELECT nombre, apellido, password FROM Credenciales_Acceso INNER JOIN Usuario ON Usuario.id = Credenciales_Acceso.id_usuario WHERE usuario = '{username}' AND estado ='activo'", connection);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string enteredPassword;
                    string nombre = reader.GetString(0).Trim();
                    string apellido = reader.GetString(1).Trim();
                    var storedPassword = reader.GetString(2);

                    // Encriptar la contraseña ingresada por el usuario con SHA256
                    using (var sha256 = SHA256.Create())
                    {
                        byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                        string hashedPassword = Convert.ToBase64String(hash);
                        enteredPassword = hashedPassword;
                    }
                    // Comparar las contraseñas encriptadas

                    isvalid = enteredPassword == storedPassword;
                    MessageBox.Show("Acceso Exitoso! Bienvenido " + nombre);
                    GlobalVaribales.user = nombre+" "+apellido;
                    return isvalid;
                }
                else
                {
                    return false;
                }

            }

        }
    }
}
