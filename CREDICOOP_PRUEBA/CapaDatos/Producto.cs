using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Producto
    {
        private readonly ConexionString _conexion = new ConexionString();

        public DataTable Mostrar()
        {
            using (var conexion = _conexion.CrearConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand("MostrarProductos", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    using (var adapter = new SqlDataAdapter(comando))
                    {
                        var tabla = new DataTable();
                        adapter.Fill(tabla);
                        return tabla;
                    }
                }
            }
        }

        public void Insertar(CapaModelo.Producto producto)
        {
            using (var conexion = _conexion.CrearConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand("InsertarProducto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = producto.Nombre;
                    comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100).Value = producto.Descripcion;
                    comando.Parameters.Add("@Marca", SqlDbType.NVarChar, 50).Value = producto.Marca;
                    comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.precio;
                    comando.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.Stock;

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Editar(CapaModelo.Producto producto)
        {
            using (var conexion = _conexion.CrearConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand("EditarProducto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@Id", SqlDbType.Int).Value = producto.IdProducto;
                    comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = producto.Nombre;
                    comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 100).Value = producto.Descripcion;
                    comando.Parameters.Add("@Marca", SqlDbType.NVarChar, 100).Value = producto.Marca;
                    comando.Parameters.Add("@Precio", SqlDbType.Decimal).Value = producto.precio;
                    comando.Parameters.Add("@Stock", SqlDbType.Int).Value = producto.Stock;

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(CapaModelo.Producto producto)
        {
            using (var conexion = _conexion.CrearConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand("EliminarProducto", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.Add("@Id", SqlDbType.Int).Value = producto.IdProducto;
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
