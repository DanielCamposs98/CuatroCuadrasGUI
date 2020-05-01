using Soporte.Cache;
using System.Data;
using System.Data.SqlClient;


namespace Persistencia
{
    public class ConsUser : ConexionSQL
    {
        public bool IniciaSesion(string user, string pass)
        {
            using (var connection = GetConnection())
            {

                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText
                        = "SELECT Nickname,Nombre,Apellidos,Sexo,Fecha_Nacimiento,Email,Contrasena,ID_Ciudad FROM USUARIO " +
                        "WHERE Nickname=@user AND Contrasena= @pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioCache.nickname = reader.GetString(0);
                            UsuarioCache.nombre = reader.GetString(1);
                            UsuarioCache.apellidos = reader.GetString(2);
                            //    UsuarioCache.sexo = reader.GetChar(3);
                            UsuarioCache.fechaNacimiento = reader.GetDateTime(4);
                            UsuarioCache.email = reader.GetString(5);
                            UsuarioCache.contraseña = reader.GetString(6);
                            UsuarioCache.ciudad = reader.GetInt32(7);
                        }
                        return true;
                    }
                    return false;
                }

            }
        }


        public bool existeUsuario(string nickname, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = " SELECT * FROM Usuario where nickname=@nick AND contrasena=@pass";
                    command.Parameters.AddWithValue("@nick", nickname);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

    }
}

  


    
