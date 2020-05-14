
using System.Data.SqlClient;

namespace Persistencia
{
    public abstract class ConexionSQL
    {
        public readonly string connectionString;
        
        public ConexionSQL()
        {
            connectionString = "Data Source=DESKTOP-ODCAGRJ\\SQLEXPRESS;Initial Catalog=CuatroCuadras;Integrated Security=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
