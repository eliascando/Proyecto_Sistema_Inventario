﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Sistema_Inventario
{
    public partial class Create_user : Form
    {
        public Create_user()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mostrarPass_CheckedChanged(object sender, EventArgs e)
        {     
            if (mostrarPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }

        }

        private void TxtPass_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Nombre = txtNombre.Text;
            user.Apellido= txtApellido.Text;
            user.Id= txtId.Text;
            user.Telefono= txtTelefono.Text;
            user.User= txtUser.Text;
            user.Pass= txtPass.Text;
            user.Estado = "activo";



            List<Usuario> usuarios = new List<Usuario>();

            string[] lines = File.ReadAllLines("usuarios.csv");
            bool existe = false;
            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                if (values[2] == txtId.Text)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                // Agrega el usuario al archivo
                using (StreamWriter sw = new StreamWriter("usuarios.csv", true))
                {
                    string row = string.Format("{0},{1},{2},{3},{4},{5},{6}", user.Nombre, user.Apellido, user.Id, user.Telefono, user.User, user.Pass,user.Estado);
                    sw.WriteLine(row);
                }
                MessageBox.Show("Usuario Registrado Exitosamente!");

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        c.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR! Usuario ya registrado!");
            }

            //bool existe = usuarios.Any(x => x.User == user.User);
            //if (!existe)
            //{
            //    usuarios.Add(user);
            //    using (StreamWriter sw = new StreamWriter("usuarios.csv", true))
            //    {
            //        foreach (Usuario usua in usuarios)
            //        {
            //            // Crea una línea de texto con los valores de cada propiedad del usuario
            //            string row = string.Format("{0},{1},{2},{3},{4},{5}", usua.Nombre, usua.Apellido, usua.Id, usua.Telefono, usua.User, usua.Pass);

            //            // Escribe la línea en el archivo
            //            sw.WriteLine(row);
            //        }
            //    }
            //    MessageBox.Show("Usuario Registrado Exitosamente!");

            //    foreach (Control c in this.Controls)
            //    {
            //        if (c is TextBox)
            //        {
            //            c.Text = "";
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("ERROR! Usuario ya registrado!");
            //}



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "usuarios.csv";
            using (var sw = new StreamWriter(filePath))
            {
                sw.Write("");
            }
            var users = new List<Usuario>();
            //gridUsers.DataSource = users;
            //gridUsers.AutoGenerateColumns = true;
        }
    }
}
