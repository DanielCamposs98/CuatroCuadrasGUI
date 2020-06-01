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
    public partial class MBLugaresMasVisitados : Form
    {
        public MBLugaresMasVisitados()
        {
            InitializeComponent();
        }

        private void MBLugaresMasVisitados_Load(object sender, EventArgs e)
        {
            obtenLugares();

        }

        private void obtenLugares()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT TOP(10) L.nombre,Count(V.ID_Lugar) as Contador FROM VISITA V JOIN LUGAR L ON L.ID_Lugar=V.ID_Lugar GROUP BY L.nombre ORDER BY Contador DESC");
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgLugares.Rows.Add(reader.GetValue(0), reader.GetValue(1));
                        }
                    }
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
