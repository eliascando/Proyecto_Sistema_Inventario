using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Sistema_Inventario
{
    internal class Producto
    {
        private int id;
        private string nombre;
        private int stock;
        private double precio;
        private double costo;

        public Producto(int id, string nombre, int stock, double precio, double costo)
        {
            Id = id;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
            Costo = costo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Costo { get => costo; set => costo = value; }



    }
}
