﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                List<Producto> productos = new List<Producto>();

                string[] lines = File.ReadAllLines("productos.csv");
                bool existe = false;
                foreach (string line in lines)
                {
                    string[] values = line.Split(',');
                    if (values[1] == txtCodigo.Text)
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    // Agrega el producto al archivo
                    using (StreamWriter sw = new StreamWriter("productos.csv", true))
                    {
                        string precio = product.Precio.ToString().Replace(',', '.');
                        string costo = product.Costo.ToString().Replace(',', '.');
                        string row = string.Format("{0},{1},{2},{3},{4}", product.Nombre, product.Codigo, product.Stock, precio, costo);
                        sw.WriteLine(row);
                    }
                    MessageBox.Show("Producto Registrado Exitosamente!");
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtStock.Text = "";
                    txtCosto.Text = "";
                    txtPVP.Text = "";
                }
                else
                {
                    MessageBox.Show("ERROR! Producto ya registrado...");
                    txtCodigo.Text = "";
                    txtNombre.Text = "";
                    txtStock.Text = "";
                    txtCosto.Text = "";
                    txtPVP.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR! "+ ex.Message);
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
