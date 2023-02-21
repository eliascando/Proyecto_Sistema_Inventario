using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private string nombre;
        private int codigo;
        private int stock;
        private double precio;
        private double costo;

        public Producto()
        {

        }
        public Producto(string nombre, int codigo, int stock, double precio, double costo)
        {
            Nombre = nombre;
            Codigo = codigo;
            Stock = stock;
            Precio = precio;
            Costo = costo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Costo { get => costo; set => costo = value; }
    }

}
