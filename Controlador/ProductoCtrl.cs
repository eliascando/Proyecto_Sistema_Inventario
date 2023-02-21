using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Controlador
{
    public class ProductoCtrl
    {
        public void Guardar(string nombre, string codigo, string stock, string precio, string costo)
        {
            if (string.IsNullOrEmpty(nombre)||string.IsNullOrEmpty(codigo)||string.IsNullOrEmpty(stock)||string.IsNullOrEmpty(precio)||string.IsNullOrEmpty(costo))
            {
                MessageBox.Show("ERROR!: Debe Ingresar Todos Los Campos");
                return;
            }
            else
            {
                Modelo.Producto producto = new Modelo.Producto();
                Modelo.CRUD guardar = new Modelo.CRUD();
                producto.Nombre = nombre;
                producto.Codigo = int.Parse(codigo);
                producto.Stock = int.Parse(stock);
                producto.Precio = double.Parse(precio);
                producto.Costo = double.Parse(costo);
                guardar.GuardarProducto(producto);

            }
        }
        public DataTable Mostrar()
        {
            Modelo.CRUD datos = new CRUD();
            return datos.DatosProducto();
        }
        public void Actualizar(string nombre, string codigo, string stock, string precio, string costo)
        {
            Modelo.Producto producto = new Modelo.Producto();
            Modelo.CRUD actualizar = new Modelo.CRUD();
            producto.Nombre = nombre;
            producto.Codigo = int.Parse(codigo);
            producto.Stock = int.Parse(stock);
            producto.Precio = double.Parse(precio);
            producto.Costo = double.Parse(costo);
            actualizar.ActualizarProducto(producto);
        }
        public void Eliminar(string nombre, string codigo, string stock, string precio, string costo)
        {
            Modelo.Producto producto = new Modelo.Producto();
            Modelo.CRUD eliminar = new Modelo.CRUD();
            producto.Nombre = nombre;
            producto.Codigo = int.Parse(codigo);
            producto.Stock = int.Parse(stock);
            producto.Precio = double.Parse(precio);
            producto.Costo = double.Parse(costo);
            eliminar.EliminarProducto(producto);
        }
        public void AgregarStock(string stock_in,string nombre, string codigo, string stock, string precio, string costo)
        {
            
            if (string.IsNullOrEmpty(stock_in))
            {
                MessageBox.Show("ERROR!: Debe Ingresar Stock");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas agregar " + stock_in + ", " + nombre + "?", "Confirmación", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                Modelo.Producto producto = new Modelo.Producto();
                Modelo.CRUD ingresar_stock = new Modelo.CRUD();
                producto.Nombre = nombre;
                producto.Codigo = int.Parse(codigo);
                producto.Stock = int.Parse(stock);
                producto.Precio = double.Parse(precio);
                producto.Costo = double.Parse(costo);
                int ingreso = int.Parse(stock_in);
                ingresar_stock.IngresoProducto(producto, ingreso);
                }
            }
           
        }
    }
}
