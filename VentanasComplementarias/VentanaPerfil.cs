using Dominio;
using Soporte.Cache;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CuatroCuadras.VentanasComplementarias
{
    public partial class VentanaPerfil : Form
    {
        SqlDataReader reader;
        string nickname;

        public VentanaPerfil()
        {
        }
        public VentanaPerfil(string nick)
        {
            nickname = nick;
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
            DateTime? fecha = null;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT nickname, nombre,apellidos, email, sexo, fecha_nacimiento FROM USUARIO WHERE Nickname='{0}'", nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lblNickname.Text = nickname;
                        lblNombre.Text = String.Concat(reader.GetValue(1), " ", reader.GetValue(2));
                        lblCorreo.Text = String.Concat("Email: ", reader.GetValue(3));
                        if (reader.GetValue(4).Equals("M"))
                        {
                            lblSexo.Text = "Sexo: Masculino.";
                        }
                        else
                        {
                            lblSexo.Text = "Sexo: Femenino.";
                        }
                        fecha = Convert.ToDateTime(reader.GetValue(5));
                    }
                    reader.Close();

                    //Obtener Edad
                    string fec = String.Format("{0}-{1}-{2}", fecha.Value.Year, fecha.Value.Month, fecha.Value.Day);
                    command.CommandText = String.Format("SELECT DATEDIFF(YEAR,'{0}',GETDATE()) FROM USUARIO WHERE nickname='{1}'", fec, nickname);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        lblEdad.Text = String.Format("Edad: {0}.", reader.GetValue(0).ToString());
                    }

                    reader.Close();


                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT C.ciudad FROM USUARIO U JOIN CIUDAD C ON C.ID_Ciudad=U.ID_Ciudad WHERE U.Nickname='{0}'", nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lblCiudad.Text = String.Format("Ciudad: {0}.", reader.GetValue(0).ToString());
                    }

                    reader.Close();

                   
                }
            }
        }

        private void obtenLogrosObtenidos()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT L.nombre, CONVERT(DATE,LU.fecha) FROM LOGRO_USUARIO LU JOIN LOGRO L ON LU.ID_Logro=L.ID_Logro WHERE LU.Nickname='{0}'",nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgLogros.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString());
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
                    command.CommandText = string.Format("SELECT L.Nombre,V.Valoracion, V.Comentario, CONVERT(DATE,V.fecha) FROM Visita V JOIN USUARIO U ON U.Nickname=V.Nickname JOIN Lugar L ON L.ID_Lugar=V.ID_Lugar WHERE U.Nickname='{0}'", nickname);
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
