using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CapaDatos
{
    public class CD_Productos
    {
        CD_Conexion conexion = new CD_Conexion();

        public DataTable Mostrar() 
        {
            DataTable tabla = new DataTable();
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("MostrarProductos",con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        tabla.Load(leer);
                    }
                }
            }
            return tabla;
        }

        public void Insertar(string nombre, string descripcion, string marca, float precio, int stock) 
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("InsertarProductos",con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@stock", stock);
                    comando.ExecuteNonQuery();
                }

            }
        }


        public void Actualizar(int id, string nombre, string descripcion, string marca, float precio, int stock) 
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("EditarProductos", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@descripcion", descripcion);
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@precio", precio);
                    comando.Parameters.AddWithValue("@stock", stock);
                    comando.ExecuteNonQuery();
                }
            }
        }


        public void Eliminar(int id) 
        {
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("EliminarProducto", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }

            }
        }


    }
}
