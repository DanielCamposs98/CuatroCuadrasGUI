
using System.Configuration;
using System.Data.SqlClient;

namespace Persistencia
{
    public abstract class ConexionSQL
    {
       public readonly string connectionString;

        public ConexionSQL()
        {
            string user = Soporte.Cache.ConServer.Usuario;
            string contrasena = Soporte.Cache.ConServer.Contraseña;
            connectionString = string.Format("Data Source=thecc.database.windows.net;Initial Catalog=CCBD;User ID={0};Password={1}", user, contrasena);
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
