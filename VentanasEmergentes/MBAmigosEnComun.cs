using Dominio;
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

namespace CuatroCuadras.VentanasEmergentes
{
    public partial class MBAmigosEnComun : Form
    {
        private string amigo1, amigo2;
        public MBAmigosEnComun(string A1, string A2)
        {
            this.amigo1 = A1;
            this.amigo2 = A2;
            InitializeComponent();
        }

        private void MBAmigosEnComun_Load(object sender, EventArgs e)
        {
            obtenAmigosComun();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void obtenerDatosAC(string nickname)
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT nickname, nombre, ID_Ciudad FROM USUARIO WHERE Nickname='{0}'", nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgAmigos.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(),obtenNombreCiudad(Convert.ToInt32(reader.GetValue(2))));
                        }
                    }
                }
            }
        }

        private string obtenNombreCiudad(int v)
        {
            string ciudad = null;
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT ciudad FROM CIUDAD WHERE ID_Ciudad={0}", v);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ciudad= reader.GetValue(0).ToString();
                        }
                    }
                }
            }
            return ciudad;
        }

        private void obtenAmigosComun()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("exec USP_AmigosEnComun '{0}','{1}'",amigo1,amigo2);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            obtenerDatosAC(reader.GetValue(0).ToString());
                        }
                    }
                }
            }
        }
    }
}
