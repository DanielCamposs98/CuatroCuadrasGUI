using Dominio;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CuatroCuadras.VentanasComplementarias
{
    public partial class VentanaMuestraLugar : Form
    {
        private int id;
        private GMapOverlay markerOverlay;
        private GMarkerGoogle marker;

        public VentanaMuestraLugar()
        {
        }
        public VentanaMuestraLugar(int lugar)
        {
            this.id = lugar;
            InitializeComponent();
        }

        private void VentanaMuestraLugar_Load(object sender, EventArgs e)
        {
            muestraMapa();
            muestraDatos();
            obtenCheckIns();
            obtenerCalificacion();

        }

        private void obtenerCalificacion()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT CONVERT(DECIMAL,AVG(Valoracion)) FROM VISITA  WHERE ID_Lugar={0}", id);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            lblCalificacion.Text = String.Format("{0}/10",reader.GetValue(0).ToString());

                            double calStar= Convert.ToDouble(reader.GetValue(0).ToString());

                            ratLugar.Value = Convert.ToInt32(Math.Round(calStar/2));
                        }
                    }
                }
            }
        }

        private void muestraMapa()
        {
            double lat = obtenLatitud(id);
            double longi = obtenLongitud(id);

            mapaLugar.DragButton = MouseButtons.Left;
            mapaLugar.CanDragMap = true;
            mapaLugar.MapProvider = GMapProviders.GoogleMap;
            mapaLugar.Position = new PointLatLng(lat, longi);
            mapaLugar.MinZoom = 0;
            mapaLugar.MaxZoom = 24;
            mapaLugar.Zoom = 9;

            markerOverlay = new GMapOverlay("Rosa Morada \n Restaurante");
            marker = new GMarkerGoogle(new PointLatLng(lat, longi), GMarkerGoogleType.red_small);
            markerOverlay.Markers.Add(marker);

            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud : {0} \n Longitud: {1}", lat, longi);
            mapaLugar.Overlays.Add(markerOverlay);
        }

        private void muestraDatos()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT Nombre,Latitud,Longitud,Descripcion,ID_Ciudad,ID_Categoria,ID_Etiqueta FROM LUGAR WHERE ID_Lugar={0}",id);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int idCiu = Convert.ToInt32(reader.GetValue(4));
                            int idCat= Convert.ToInt32(reader.GetValue(5));
                            int idEt= Convert.ToInt32(reader.GetValue(6));
                            lblNombreLugar.Text = reader.GetValue(0).ToString();
                            lblLatitud.Text = reader.GetValue(1).ToString();
                            lblLongitud.Text = reader.GetValue(2).ToString();
                            txtDescripcion.Text = reader.GetValue(3).ToString();
                            lblCiudad.Text = obtenNombreCiudad(idCiu);
                            lblCategoria.Text = obtenCategoria(idCat);
                            lblEtiqueta.Text = obtenEtiqueta(idEt);
                        }
                    }
                }
            }
        }

        private void obtenCheckIns()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT Nickname,Valoracion,Comentario FROM VISITA  WHERE ID_Lugar={0}", id);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dgVisitas.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
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
                    command.CommandText = String.Format("SELECT ciudad FROM CIUDAD WHERE ID_Ciudad={0}",id);
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

        private string obtenEtiqueta(int id)
        {
            string etiqueta = "";
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT Nombre_eti FROM ETIQUETA WHERE ID_Etiqueta={0}",id);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        etiqueta = reader.GetValue(0).ToString();
                    }
                }
                return etiqueta;

            }
        }

        private string obtenCategoria(int id)
        {
            string categoria = "";
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT Descripcion FROM Categoria WHERE ID_Categoria={0}", id);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                       categoria = reader.GetValue(0).ToString();
                    }
                }
                return categoria;

            }
        }

        private double obtenLatitud(int id)
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                double lat = 0;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT Latitud FROM LUGAR WHERE ID_Lugar={0}", id);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lat = Convert.ToDouble(reader.GetValue(0));
                    }
                }
                return lat;

            }
        }

        private double obtenLongitud(int id)
        { 
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                double longi = 0;
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT Longitud FROM LUGAR WHERE ID_Lugar={0}", id);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        longi = Convert.ToDouble(reader.GetValue(0));
                    }
                }
                return longi;

            }
        }

    }
}
