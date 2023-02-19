using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Sistema_Inventario
{
    public partial class Update_products : Form
    {
        private Consult_products consultaForm;

        public Update_products(Consult_products consultaForm)
        {
            InitializeComponent();
            txtUCodigo.ReadOnly= true;
            this.consultaForm = consultaForm;
        }

        private void Update_products_Load(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try 
            {
                Producto u_producto = new Producto();
                u_producto.Codigo = txtUCodigo.Text;
                u_producto.Nombre = txtUNombre.Text.Trim();
                u_producto.Stock = int.Parse(txtUStock.Text.Trim());
                u_producto.Precio = double.Parse(txtUPVP.Text.Trim());
                u_producto.Costo = double.Parse(txtUCosto.Text.Trim());
                using (SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = BD_PSI; Integrated Security = True"))
                {
                    cn.Open();
                    string query = "UPDATE Producto SET nombre = @nombre, stock = @stock, precio = @precio, costo = @costo WHERE codigo = @codigo";
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@nombre", u_producto.Nombre);
                    command.Parameters.AddWithValue("@stock", u_producto.Stock);
                    command.Parameters.AddWithValue("@precio", u_producto.Precio);
                    command.Parameters.AddWithValue("@costo", u_producto.Costo);
                    command.Parameters.AddWithValue("@codigo", u_producto.Codigo);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto Actualizado Correctamente!");
                        consultaForm.ActualizarTabla();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún producto con el código especificado!");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas Eliminar este producto?", "Confirmación", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection("Data Source =.; Initial Catalog = BD_PSI; Integrated Security = True"))
                    {
                        cn.Open();
                        string query = "DELETE FROM Producto WHERE codigo = @codigo";
                        SqlCommand command = new SqlCommand(query, cn);
                        command.Parameters.AddWithValue("@codigo", txtUCodigo.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro eliminado exitosamente!");
                            consultaForm.ActualizarTabla();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún producto con el código especificado");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR!"+ex.Message);
                }
                
            }
            
        }

        private void txtUNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUCosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUPVP_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
