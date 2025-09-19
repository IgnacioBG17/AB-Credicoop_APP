using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionString
    {
        private readonly string _connectionString;

        public ConexionString()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public SqlConnection CrearConexion()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
