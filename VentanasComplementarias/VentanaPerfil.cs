using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;
using Dominio;
namespace CuatroCuadras.VentanasComplementarias
{
    public partial class VentanaPerfil : Form
    {
        SqlDataReader reader;
        public VentanaPerfil()
        {
            InitializeComponent();
        }

        private void VentanaPerfil_Load(object sender, EventArgs e)
        {
            obtenDatosPersonales();
            obtenLogrosObtenidos();
            obtenCheckins();
        }

        private void obtenDatosPersonales()
        {
            lblNickname.Text = UsuarioCache.nickname;
            lblNombre.Text = String.Concat(UsuarioCache.nombre, " ", UsuarioCache.apellidos);
            lblCorreo.Text = String.Concat("Email: ", UsuarioCache.email,".");

            if (UsuarioCache.sexo.Equals('M'))
            {
                lblSexo.Text = "Sexo: Masculino.";
            }
            else
            {
                lblSexo.Text = "Sexo: Femenino.";
            }

            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT C.ciudad FROM USUARIO U JOIN CIUDAD C ON C.ID_Ciudad=U.ID_Ciudad WHERE U.Nickname='{0}'",UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lblCiudad.Text = String.Format("Ciudad: {0}.", reader.GetValue(0).ToString());
                    }

                    reader.Close();

                    //Obtener Edad
                    string fecha = String.Format("{0}-{1}-{2}", UsuarioCache.fechaNacimiento.Year, UsuarioCache.fechaNacimiento.Month, UsuarioCache.fechaNacimiento.Day);
                    command.CommandText = String.Format("SELECT DATEDIFF(YEAR,'{0}',GETDATE()) FROM USUARIO WHERE nickname='{1}'", fecha, UsuarioCache.nickname);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lblEdad.Text = String.Format("Edad: {0}.", reader.GetValue(0).ToString());
                    }
 
                }
            }
        }

        private void obtenLogrosObtenidos()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection() )
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT L.nombre, CONVERT(DATE,LU.fecha) FROM LOGRO_USUARIO LU JOIN LOGRO L ON LU.ID_Logro=L.ID_Logro WHERE LU.Nickname='{0}'", UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgLogros.Rows.Add(reader.GetValue(0).ToString(),reader.GetValue(1).ToString());
                        }
                    }
                }
            }
        }

        private void obtenCheckins()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT L.Nombre,V.Valoracion, V.Comentario, CONVERT(DATE,V.fecha) FROM Visita V JOIN USUARIO U ON U.Nickname=V.Nickname JOIN Lugar L ON L.ID_Lugar=V.ID_Lugar WHERE U.Nickname='{0}'", UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgVisitas.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                        }
                    }
                }
            }
        }
    }
}
