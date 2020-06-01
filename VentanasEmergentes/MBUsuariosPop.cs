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
    public partial class MBUsuariosPop : Form
    {
        public MBUsuariosPop()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }


        private void obtenUsuarios()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT TOP(5) Count(ID_Lugar) as Contador, nickname FROM VISITA GROUP BY nickname ORDER BY Contador DESC");
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgUsuarios.Rows.Add(reader.GetValue(1), reader.GetValue(0));
                        }
                    }
                }
            }
        }

        private void MBUsuariosPop_Load(object sender, EventArgs e)
        {
            obtenUsuarios();
        }
    }
}
