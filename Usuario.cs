using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

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
            string filePath = "usuarios.csv";

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    if (values[4] == username && values[5] == password && values[6] == "activo")
                    {
                        MessageBox.Show("Acceso Exitoso! Bienvenido " + values[0]); 
                        return true;
                    }
                }
            }

            return false;
        }


    }
}
