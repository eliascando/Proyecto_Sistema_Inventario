using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Actividad
    {
        private int id_actividad;
        private DateTime fechayhora;
        private int stock;
        private string tipo_actividad;
        private int codigo_producto;
        private string nombre_producto;
        private int id_usuario;

        public Actividad()
        {

        }

        public Actividad(int id_actividad, DateTime fechayhora, int stock,string tipo_actividad, int codigo_producto,string nombre_producto, int id_usuario)
        {
            this.Id_actividad = id_actividad;
            this.Fechayhora = fechayhora;
            this.Stock = stock;
            this.Tipo_actividad = tipo_actividad;
            this.Codigo_producto = codigo_producto;
            this.Nombre_producto= nombre_producto;
            this.Id_usuario = id_usuario;
        }

        public int Id_actividad { get => id_actividad; set => id_actividad = value; }
        public DateTime Fechayhora { get => fechayhora; set => fechayhora = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Tipo_actividad { get => tipo_actividad; set => tipo_actividad = value; }
        public int Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
    }
}