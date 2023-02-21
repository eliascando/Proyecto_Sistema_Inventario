using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class UsuarioAdmin : Usuario
    {
        public static UsuarioAdmin _instance;

        public UsuarioAdmin()
        {
            Nombre = "admin";
            Apellido = "admin";
            Id = 1234;
            Telefono = "admin";
            User = "admin";
            Pass = "admin";
            Estado = "activo";
        }
        public static UsuarioAdmin GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UsuarioAdmin();
            }
            return _instance;
        }
    }
}