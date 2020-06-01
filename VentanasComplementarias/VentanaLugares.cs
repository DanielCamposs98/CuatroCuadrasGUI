using Dominio;
using Soporte.Cache;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CuatroCuadras.VentanasComplementarias
{
    public partial class VentanaLugares : Form
    {
        public VentanaLugares()
        {
            InitializeComponent();
        }

        private void VentanaLugares_Load(object sender, EventArgs e)
        {
            obtenerLugares();
            obtenerLugaresVisitados();
        }

        private void obtenerLugares()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT nombre, Descripcion,ID_Ciudad FROM LUGAR");
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ciudad = Convert.ToInt32(reader.GetValue(2).ToString());
                            dgLugares.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), obtenNombreCiudad(ciudad));
                        }
                    }
                }
            }
        }

        private void obtenerLugaresVisitados()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT L.nombre, V.valoracion, V.Comentario FROM VISITA V JOIN LUGAR L ON L.ID_Lugar=V.ID_Lugar WHERE V.NICKNAME='{0}'", UsuarioCache.nickname);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgLugaresVisitados.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                        }
                    }
                }
            }
        }



        private string obtenNombreCiudad(int id)
        {
            string ciudad = "";
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT ciudad FROM CIUDAD WHERE ID_Ciudad={0}", id);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ciudad = reader.GetValue(0).ToString();
                    }
                }
                return ciudad;
            }
        }

        private void muestraLugarDG(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.ColumnIndex == dgLugares.Columns["btnMostrar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgLugares.Rows[e.RowIndex];
                string nombreL = dgv.Cells[0].Value.ToString();
                SqlDataReader reader;
                using (var connection = ModeloUsuario.GetConsUser().GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = String.Format("SELECT ID_Lugar FROM LUGAR WHERE nombre='{0}'", nombreL);
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            CuatroCuadras.panelP.Controls.Clear();
                          int idL = Convert.ToInt32(reader.GetValue(0));
                           Otros.UsoFormulario.AbrirFormularioParametros<VentanaMuestraLugar>(CuatroCuadras.panelP, idL);
                        }
                    }
                }
            }

        }

        private void dgLugaresVisitados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgLugaresVisitados.Columns["btnMostrarVisitado"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgLugaresVisitados.Rows[e.RowIndex];
                string nombreL = dgv.Cells[0].Value.ToString();
                SqlDataReader reader;
                using (var connection = ModeloUsuario.GetConsUser().GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = String.Format("SELECT ID_Lugar FROM LUGAR WHERE nombre='{0}'", nombreL);
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            CuatroCuadras.panelP.Controls.Clear();
                            int idL = Convert.ToInt32(reader.GetValue(0));
                            Otros.UsoFormulario.AbrirFormularioParametros<VentanaMuestraLugar>(CuatroCuadras.panelP, idL);
                        }
                    }
                }
            }
        }
    }
}





