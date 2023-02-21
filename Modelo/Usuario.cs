using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private String nombre;
        private String apellido;
        private int id;
        private String telefono;
        private String user;
        private String pass;
        private String estado;

        public Usuario()
        {

        }
        public Usuario(string nombre, string apellido, int id, string telefono, string user, string pass, string estado)
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
        public int Id { get => id; set => id = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
