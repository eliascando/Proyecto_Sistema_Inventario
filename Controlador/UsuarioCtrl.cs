using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class UsuarioCtrl
    {
        public void Guardar(string id, string nombre, string apellido, string telefono, string usuario, string password)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("ERROR!: Debe Ingresar Todos Los Campos");
                return;
            }
            else
            {
                Modelo.Usuario persona = new Modelo.Usuario();
                Modelo.CRUD guardar = new Modelo.CRUD();
                persona.Nombre = nombre;
                persona.Apellido = apellido;
                persona.Id = int.Parse(id);
                persona.Telefono = telefono;
                persona.User = usuario;
                persona.Pass = password;
                persona.Estado = "activo";
                guardar.GuardarUsuario(persona);
            }
                
        }
        public DataTable Mostrar()
        {
            Modelo.CRUD datos = new CRUD();
            return datos.DatosUsuario();
        }
        public void Actualizar(string id, string nombre, string apellido, string telefono, string estado)
        {
            CRUD actualizar= new CRUD();
            Usuario usuario = new Usuario();
            usuario.Id = int.Parse(id);
            usuario.Nombre = nombre;
            usuario.Apellido = apellido;
            usuario.Telefono = telefono;
            usuario.Estado = estado;
            actualizar.ActualizarUsuario(usuario);
        }
        public bool Login(string username, string password)
        {
            CRUD login=new CRUD();
            if(string.IsNullOrEmpty(username)||string.IsNullOrEmpty(password))
            {
                MessageBox.Show("ERROR!: Debe Ingresar Usuario y Contraseña!");
                return false;
            }
            else
            {
                if (login.IsValidUser(username, password))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("ERROR!: Usuario o Contraseña Incorrectos!");
                    return false;
                }
            }
            

        }
    }
}
