using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Sistema_Inventario
{
    internal class UsuarioAdmin : Usuario
    {
        private static UsuarioAdmin _instance;

        private UsuarioAdmin()
        {
            Nombre = "admin";
            Apellido= "admin";
            Id = "admin";
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
