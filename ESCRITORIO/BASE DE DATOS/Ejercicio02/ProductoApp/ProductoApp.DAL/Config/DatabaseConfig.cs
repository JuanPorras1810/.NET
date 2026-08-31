using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp.DAL.Config
{
    internal class DatabaseConfig
    {
        private string cadenaConexion = "Server=(localdb)\\MSSQLLocalDB;Database=DBProductos;Integrated Security=True;Connection Timeout=30";

        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
    }
}
