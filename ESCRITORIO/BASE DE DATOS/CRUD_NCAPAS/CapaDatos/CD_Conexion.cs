using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class CD_Conexion
    {
        private string cadenaConexionPractica = "Server=(localdb)\\MSSQLLocalDB;Database=Practica;Integrated Security=true";

        public SqlConnection AbrirConexion() 
        {
            SqlConnection conexion = new SqlConnection(cadenaConexionPractica);
            conexion.Open();
            return conexion;
        }
    }
}