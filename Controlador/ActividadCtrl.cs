using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ActividadCtrl
    {
        public DataTable Mostrar()
        {
            Modelo.CRUD datos = new Modelo.CRUD();
            return datos.DatosActividad();
        }
        public DataTable DatosInicioSesion()
        {
            Modelo.CRUD datos = new Modelo.CRUD();
            return datos.DatosInicioSesion();
        }
    }
}
