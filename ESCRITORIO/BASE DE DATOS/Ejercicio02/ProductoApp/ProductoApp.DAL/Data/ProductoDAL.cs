using ProductoApp.DAL.Config;
using ProductoApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductoApp.DAL.Data
{
    internal class ProductoDAL
    {
        DatabaseConfig conexion = new DatabaseConfig();
        public DataTable Mostrar() 
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_ListarProductos", con))
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


        public Producto ObtenerPorId(int idProducto) 
        {
            Producto producto = null;
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_ObtenerProducto", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdProducto", idProducto);
                    using (SqlDataReader leer = comando.ExecuteReader())
                    {
                        if (leer.Read())
                        {
                            producto = new Producto
                            {
                                IdProducto = Convert.ToInt32(leer["IdProducto"]),
                                Nombre = Convert.ToString(leer["Nombre"]),
                                Descripcion = leer["IdProducto"] is DBNull ?"" : Convert.ToString(leer["Descripcion"]),
                                Precio = Convert.ToDecimal(leer["Precio"]),
                                Stock = Convert.ToInt32(leer["Stock"]),
                                FechaRegistro = Convert.ToDateTime(leer["FechaRegistro"]),
                            };
                        }
                    }
                }
            }
            return producto;
        }

        public int Insertar(Producto producto) 
        {
            int nuevoId = 0;
        }
    }
}
