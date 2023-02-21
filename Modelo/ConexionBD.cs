using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class ConexionBD
    {
        public static SqlConnection cn;

        public static bool AbrirConexion()
        {
            try
            {
                cn = new SqlConnection();
                //cn.ConnectionString = "Data Source=.;Initial Catalog=BD_PSI;Integrated Security=True";
                cn.ConnectionString = $"Data Source=.;Initial Catalog=BD_PSI;User ID=admin;Password=admin";
                cn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: " + ex);
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
