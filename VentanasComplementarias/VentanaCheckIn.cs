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
    public partial class VentanaCheckIn : Form
    {
        public VentanaCheckIn()
        {
            InitializeComponent();
            llenarCmbLugares();
        }

        private void llenarCmbLugares()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT C.ciudad, L.nombre FROM LUGAR L JOIN Ciudad C ON C.ID_Ciudad=L.ID_Ciudad");
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbLugares.Items.Add(reader.GetValue(0).ToString());
                    }

                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRegistrarCI_Click(object sender, EventArgs e)
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("INSERT INTO Visita VALUES(@lugar,@nick,@comentario,@valoracion,GETDATE())'");
                    command.Parameters.AddWithValue("@lugar",obtenLugar());
                    command.Parameters.AddWithValue("@nick", UsuarioCache.nickname);
                    command.Parameters.AddWithValue("@comentario", txtComentario.Text);
                    command.Parameters.AddWithValue("@valoracion", Convert.ToInt32(numUpValoracion.Value));
                    command.CommandType = CommandType.Text;

                    try
                    {
                        command.ExecuteNonQuery();
                    }catch(SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                        return;
                    }
                }
            }
        }

        private int obtenLugar()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                SqlDataReader reader;
                int id =-1;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT ID_Lugar FROM Lugar WHERE Nombre='{0}'", cmbLugares.SelectedItem.ToString()); 
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader.GetValue(0).ToString()); 
                    }

                    return id;
                }
            }
        }
    }
}
