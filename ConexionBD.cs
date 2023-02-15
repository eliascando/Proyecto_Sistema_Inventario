using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Proyecto_Sistema_Inventario
{
    internal class ConexionBD
    {
        public static SqlConnection cn;

        public static bool AbrirConexion()
        {
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = "Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True";
                cn.Open();
                return true;


            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static void CerrarConexion()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
    }
}
