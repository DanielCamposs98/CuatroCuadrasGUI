using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Soporte.Cache;

namespace Persistencia
{
    public class ConsUser : ConexionSQL
    {

        public bool IniciaSesion(string user, string pass)
        {
            if (existeNickname(user))
            {
                string contra = desencriptarContrasena(user);

                if (contra.Equals(pass))
                {
                    UsuarioCache.nickname = user;
                    UsuarioCache.contraseña = contra;
                    obtenDatosUsuario(user);
                    return true;
                }
                return false;
            }
            return false;
        }
        #region IniciaSesionExtras

        private bool existeNickname(string user)
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText
                        = String.Format("SELECT * FROM USUARIO WHERE Nickname='{0}' ", user);
                    command.CommandType = CommandType.Text;

                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    return false;
                }
            }
        }

        private string desencriptarContrasena(string user)
        {
            SqlDataReader reader;
            string contraseña = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT Convert(VARCHAR(MAX),DECRYPTBYPASSPHRASE('contrasena',Contrasena)) FROM USUARIO WHERE Nickname='{0}'", user);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            contraseña = reader.GetValue(0).ToString();
                        }
                    }
                    return contraseña;
                }
            }
        }

        private string obtenerContrasenaEncriptada(string user)
        {
            SqlDataReader reader;
            string contraseña = null;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT contraseña FROM USUARIO WHERE Nickname='{0}'", user);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            contraseña = reader.GetValue(0).ToString();
                        }
                    }
                    return contraseña;
                }
            }
        }

        private bool obtenDatosUsuario(string user)
        {
            SqlDataReader reader;
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Connection = connection;
                    command.CommandText
                        = String.Format("SELECT nombre,apellidos,sexo,fecha_nacimiento,email,ID_ciudad FROM USUARIO WHERE Nickname='{0}' ", user);
                    command.CommandType = CommandType.Text;

                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UsuarioCache.nombre = reader.GetString(0);
                            UsuarioCache.apellidos = reader.GetString(1);
                            var sexo = Convert.ToChar(reader.GetValue(2).ToString());
                            UsuarioCache.sexo = Convert.ToChar(sexo);
                            UsuarioCache.fechaNacimiento = reader.GetDateTime(3);
                            UsuarioCache.email = reader.GetString(4);
                            UsuarioCache.ciudad = reader.GetInt32(5);
                        }
                        return true;
                    }
                    return false;
                   
                }
            }
        }
       
        
        
        #endregion IniciaSesionExtras
        public bool existeUsuario(string nk)
        {
                SqlDataReader reader;
                using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = " SELECT * FROM Usuario WHERE Nickname = @nick";
                    command.Parameters.AddWithValue("@nick", nk);
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
                SqlDataReader reader;
                using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT nickname,nombre,apellidos,email, CONVERT(VARCHAR(MAX),DECRYPTBYPASSPHRASE('contrasena',contrasena)) FROM USUARIO WHERE Email= @email ";
                    command.Parameters.AddWithValue("@email", solicitud);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string nick = reader.GetString(2) + "," + reader.GetString(1);
                        string mail = reader.GetString(3);
                        string pass = reader.GetString(4);
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





