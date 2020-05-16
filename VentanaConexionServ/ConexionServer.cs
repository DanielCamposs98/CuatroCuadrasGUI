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

namespace CuatroCuadras.VentanaConexionServ
{
    public partial class ConexionServer : Form
    {
        public ConexionServer()
        { 
            InitializeComponent();
        }

        public bool VerifyConnection()
        {

            string user = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            string connectionString;
            SqlConnection cnn;
            connectionString = String.Format("Data Source=thecc.database.windows.net;Initial Catalog=CCBD;User ID={0};Password={1};", user, contrasena);

           
            try
            {
               cnn = new SqlConnection(connectionString);
                cnn.Open();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (VerifyConnection())
            {
                ConServer.Usuario = txtUsuario.Text;
                ConServer.Contraseña = txtContrasena.Text;
                this.Hide();
                new InicioSesionForm().Show();
            }
            else
            {
                this.Hide();
                new VentanasEmergentes.MBNoConnection().Show();
            }
        }
    }
}
