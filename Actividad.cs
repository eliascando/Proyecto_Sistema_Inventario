using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Sistema_Inventario
{
    internal class Actividad
    {
        private int id_actividad;
        private DateTime fechayhora;
        private int ingreso_stock;
        private int codigo_producto;
        private int id_usuario;
        
        public Actividad()
        {

        }

        public Actividad(int id_actividad, DateTime fechayhora, int ingreso_stock, int codigo_producto, int id_usuario)
        {
            this.Id_actividad = id_actividad;
            this.Fechayhora = fechayhora;
            this.Ingreso_stock = ingreso_stock;
            this.Codigo_producto = codigo_producto;
            this.Id_usuario = id_usuario;
        }

        public int Id_actividad { get => id_actividad; set => id_actividad = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
        public int Ingreso_stock { get => ingreso_stock; set => ingreso_stock = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }
}
