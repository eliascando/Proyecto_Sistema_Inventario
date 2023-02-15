using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Sistema_Inventario
{
    public partial class Register_products : Form
    {
        public Register_products()
        {
            InitializeComponent();            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto product = new Producto();
                product.Nombre = txtNombre.Text;
                product.Codigo = txtCodigo.Text;
                product.Stock = int.Parse(txtStock.Text);
                product.Precio = double.Parse(txtPVP.Text);
                product.Costo = double.Parse(txtCosto.Text);

                if (string.IsNullOrEmpty(txtNombre.Text) ||
                   string.IsNullOrEmpty(txtCodigo.Text) ||
                   string.IsNullOrEmpty(txtStock.Text) ||
                   string.IsNullOrEmpty(txtPVP.Text) ||
                   string.IsNullOrEmpty(txtCosto.Text))
                {
                    MessageBox.Show("ERROR! Debe llenar todos los campos...");
                    return;
                }

                if (ConexionBD.AbrirConexion())
                {
                    MessageBox.Show("Conexion Exitosa!");
                    string query = "INSERT INTO Producto (codigo, nombre, stock, precio, costo) VALUES (@codigo, @nombre, @stock, @precio, @costo)";
                    using (SqlCommand cmd = new SqlCommand(query, ConexionBD.cn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                        cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                        cmd.Parameters.AddWithValue("@precio", double.Parse(txtPVP.Text));
                        cmd.Parameters.AddWithValue("@costo", double.Parse(txtCosto.Text));
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto registrado exitosamente!");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el producto.");
                        }
                        ConexionBD.CerrarConexion();
                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        txtStock.Text = "";
                        txtCosto.Text = "";
                        txtPVP.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Error de Conexion Con la Base de Datos!");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR! "+ ex.Message);
                ConexionBD.CerrarConexion();
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {   
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtStock.Text = "";
            txtCosto.Text = "";
            txtPVP.Text = "";
        }

        private void Register_products_Load(object sender, EventArgs e)
        {

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtPVP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || e.KeyChar !=','))
            {
                e.Handled = true;
            }
        }
    }
}
