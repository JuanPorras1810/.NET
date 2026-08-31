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
    public class ProductoDAL
    {
        DatabaseConfig conexion = new DatabaseConfig();
        public List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection con = conexion.AbrirConexion())
            using (SqlCommand comando = new SqlCommand("sp_ListarProductos", con))
            {
                comando.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader leer = comando.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        productos.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(leer["IdProducto"]),
                            Nombre = Convert.ToString(leer["Nombre"]),
                            Precio = Convert.ToDecimal(leer["Precio"]),
                            Stock = Convert.ToInt32(leer["Stock"]),
                            FechaRegistro = Convert.ToDateTime(leer["FechaRegistro"])
                        });
                    }
                }
            }

            return productos;
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
            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_InsertarProducto", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@Stock", producto.Stock);

                    var resultado = comando.ExecuteScalar();
                    if (resultado != null) //&& resultado != DBNull.Value
                    {
                        nuevoId = Convert.ToInt32(resultado);
                    }
                }
            }
            return nuevoId;
        }

        public bool Actualizar(Producto producto) 
        {
            bool actualizado = false;

            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_ActualizarProducto", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                    comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@Stock", producto.Stock);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    actualizado = filasAfectadas > 0;
                }
            }
            return actualizado;
        }

        public bool Eliminar(int idProducto) 
        {
            bool eliminado = false;

            using (SqlConnection con = conexion.AbrirConexion())
            {
                using (SqlCommand comando = new SqlCommand("sp_EliminarProducto", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@IdProducto", idProducto);

                    int filasAfectadas = comando.ExecuteNonQuery();
                    eliminado = filasAfectadas > 0;
                }
            }
            return eliminado;
        }
    }
}
