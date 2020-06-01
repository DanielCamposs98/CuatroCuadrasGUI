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
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = String.Format("Hola, {0}", UsuarioCache.nickname);
            obtenAvanceLogros();
        }

        private void obtenAvanceLogros()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("exec USP_AvanceLogros '{0}'", UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgAvanceLogros.Rows.Add(reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), String.Format("{0} %", reader.GetValue(4)));
                        }
                    }
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            new VentanaCheckIn().ShowDialog();
        }

        private void btnLugVis_Click(object sender, EventArgs e)
        {
            new VentanasEmergentes.MBLugaresMasVisitados().ShowDialog();
        }

        private void btnUsuariosPop_Click(object sender, EventArgs e)
        {
            new VentanasEmergentes.MBUsuariosPop().ShowDialog();
        }
    }
}
