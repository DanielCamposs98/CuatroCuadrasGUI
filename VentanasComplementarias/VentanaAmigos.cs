using Dominio;
using Soporte.Cache;
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

namespace CuatroCuadras.VentanasComplementarias
{
    public partial class VentanaAmigos : Form
    {
        public VentanaAmigos()
        {
            InitializeComponent();
        }

        private void VentanaAmigos_Load(object sender, EventArgs e)
        {
            llenarListaAmigos();
            llenarListaSugerencias();
            llenarListaSolicitudes();
        }

        private void llenarListaSolicitudes()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT U.nickname FROM AMIGO A JOIN USUARIO U ON A.Nickname1=U.nickname JOIN USUARIO U2 ON A.nickname2=U2.nickname WHERE A.nickname2='{0}' AND A.Estado='P'", UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgSolicitudes.Rows.Add(reader.GetValue(0).ToString());
                        }
                    }
                }
            }
        }

        private void llenarListaSugerencias()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("exec USP_AmigosSugeridos '{0}'",UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgSugerencias.Rows.Add(reader.GetValue(0).ToString());
                        }
                    }
                }
            }
        }

        private void llenarListaAmigos()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT U.nickname, CONCAT(U.nombre,' ',U.apellidos), C.ciudad FROM AMIGO A JOIN USUARIO U ON A.Nickname2=U.nickname JOIN CIUDAD C ON U.ID_Ciudad=C.ID_Ciudad WHERE A.nickname1='{0}' AND A.Estado='A'", UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgAmigos.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                        }
                    }
                    reader.Close();

                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT U.nickname, CONCAT(U.nombre,' ',U.apellidos), C.ciudad FROM AMIGO A JOIN USUARIO U ON A.Nickname1= U.nickname JOIN CIUDAD C ON U.ID_Ciudad = C.ID_Ciudad WHERE A.nickname2 ='{0}' AND A.Estado='A'", UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgAmigos.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                        }
                    }
                }
            }
        }
    }
}
