using Dominio;
using Soporte.Cache;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CuatroCuadras.VentanasComplementarias
{
    public partial class VentanaConfig : Form
    {
        public VentanaConfig()
        {
            InitializeComponent();
        }

        private void VentanaConfig_Load(object sender, EventArgs e)
        {
            llenaDatosPersonales();
        }

        private void llenaDatosPersonales()
        {
            SqlDataReader reader;
            txtNickname.Text = UsuarioCache.nickname;
            txtNombre.Text = UsuarioCache.nombre;
            txtApellidos.Text = UsuarioCache.apellidos;
            txtCorreo.Text = UsuarioCache.email;
            txtContrasena.Text = UsuarioCache.contraseña;
            llenaCmbCiudades();



        }

        private void llenaCmbCiudades()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = "SELECT ciudad FROM CIUDAD";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbCiudades.Items.Add(reader.GetValue(0).ToString());
                    }
                }
            }
        }


    }
}
