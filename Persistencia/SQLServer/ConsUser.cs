using Soporte.Cache;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace Persistencia
{
    public class ConsUser : ConexionSQL
    {
        SqlDataReader reader;
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

                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioCache.nickname = reader.GetString(0);
                            UsuarioCache.nombre = reader.GetString(1);
                            UsuarioCache.apellidos = reader.GetString(2);
                            var sexo = Convert.ToChar(reader.GetValue(3).ToString());
                            UsuarioCache.sexo = Convert.ToChar(sexo);
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

        public bool existeUsuario(string nk, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = " SELECT * FROM Usuario WHERE Nickname = @nick  AND contrasena=@pass";
                    command.Parameters.AddWithValue("@nick", nk);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
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

        public string RecuperarContrasena(string solicitud)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM USUARIO WHERE Nickname= @nick OR Email=@mail";
                    command.Parameters.AddWithValue("@nick", solicitud);
                    command.Parameters.AddWithValue("@mail", solicitud);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string nick = reader.GetString(3) + "," + reader.GetString(1);
                        string mail = reader.GetString(5);
                        string pass = reader.GetString(6);
                        string user = reader.GetString(0);

                        var mailService = new ServiciosMail.SoporteMail();

                        mailService.sendMail(
                            recipientMail: new List<string> { mail },
                            subject: "Solicitud de recuperación de contraseña",
                            body: "Hola," + nick + ".\n Esta es una solicitud de recuperacion de contraseña.\n Tu usuario es: " + user + ".\n Tu contraseña es: " + pass + "."
                    );
                        return "T";
                    }
                    else
                    {
                        return "F";
                    }



                }
            }
        }
    }
}





