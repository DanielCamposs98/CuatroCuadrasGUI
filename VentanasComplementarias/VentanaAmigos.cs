using Dominio;
using Soporte.Cache;
using System;
using System.Data;
using System.Data.SqlClient;
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
                    command.CommandText = string.Format("exec USP_AmigosSugeridos '{0}'", UsuarioCache.nickname);
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

        private void dgAmigos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgAmigos.Columns["btnMostrarPerfil"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgAmigos.Rows[e.RowIndex];
                string nicknameAmigo = dgv.Cells[0].Value.ToString();

                CuatroCuadras.panelP.Controls.Clear();

                Otros.UsoFormulario.AbrirFormularioParametrosPerfil<VentanaPerfil>(CuatroCuadras.panelP,nicknameAmigo);
            }


            if (e.ColumnIndex == dgAmigos.Columns["btnAmigosComun"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgAmigos.Rows[e.RowIndex];
                string nombreL = dgv.Cells[0].Value.ToString();

                new VentanasEmergentes.MBAmigosEnComun(UsuarioCache.nickname, nombreL).ShowDialog();

            }
        }

        private void dgSugerencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgSugerencias.Columns["btnAgregar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgSugerencias.Rows[e.RowIndex];
                string nicknameSug = dgv.Cells[0].Value.ToString();

                SqlDataReader reader;
                using (var connection = ModeloUsuario.GetConsUser().GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("exec USP_SolicitudAmistad '{0}','{1}'", UsuarioCache.nickname,nicknameSug);
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                    }
                }
                CuatroCuadras.panelP.Controls.Clear();
                Otros.UsoFormulario.AbrirFormulario<VentanaAmigos>(CuatroCuadras.panelP);
            }
        }

        private void dgSolicitudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgSolicitudes.Columns["btnAceptarSol"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgSolicitudes.Rows[e.RowIndex];
                string nicknameAmigo = dgv.Cells[0].Value.ToString();

                SqlDataReader reader;
                using (var connection = ModeloUsuario.GetConsUser().GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("UPDATE AMIGO SET estado='A' WHERE nickname1='{0}' AND nickname2='{1}'",nicknameAmigo,UsuarioCache.nickname);
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                    }
                }

                CuatroCuadras.panelP.Controls.Clear();

                Otros.UsoFormulario.AbrirFormulario<VentanaAmigos>(CuatroCuadras.panelP);
            }


            if (e.ColumnIndex == dgSolicitudes.Columns["btnRechazarSol"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgSolicitudes.Rows[e.RowIndex];
                string nicknameAmigo = dgv.Cells[0].Value.ToString();

                SqlDataReader reader;
                using (var connection = ModeloUsuario.GetConsUser().GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = string.Format("UPDATE AMIGO SET estado='R' WHERE nickname1='{0}' AND nickname2='{1}'", nicknameAmigo, UsuarioCache.nickname);
                        command.CommandType = CommandType.Text;
                        reader = command.ExecuteReader();
                    }
                }

                CuatroCuadras.panelP.Controls.Clear();

                Otros.UsoFormulario.AbrirFormulario<VentanaAmigos>(CuatroCuadras.panelP);

            }
        }
    }
}
