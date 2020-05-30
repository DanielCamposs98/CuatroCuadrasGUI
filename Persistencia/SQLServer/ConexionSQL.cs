
using System;
using System.Configuration;
using System.Data.SqlClient;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

namespace Persistencia
{
    public abstract class ConexionSQL
    {
       public readonly string connectionString;

        public ConexionSQL()

        {
            string user = Soporte.Cache.ConServer.Usuario;
            string contrasena = Soporte.Cache.ConServer.Contraseña;
            connectionString = string.Format("Server=tcp:thecc.database.windows.net,1433;Initial Catalog=CuatroCuadras;Persist Security Info=False;User ID={0};Password={1};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", user, contrasena);

        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
