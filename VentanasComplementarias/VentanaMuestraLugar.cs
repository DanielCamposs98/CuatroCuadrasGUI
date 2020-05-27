using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Device.Location;
using GMap.NET.MapProviders;
using GMap.NET.Internals;
using GMap.NET.Projections;
using GMap.NET.ObjectModel;

namespace CuatroCuadras.VentanasComplementarias
{
    public partial class VentanaMuestraLugar : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        double lat= 24.763375, longi= -107.699523;
        public VentanaMuestraLugar()
        {
            InitializeComponent();
        }

        private void VentanaMuestraLugar_Load(object sender, EventArgs e)
        {
            muestraMapa( );

        }

        private void muestraMapa()
        {


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

            var addresses = GetAddress();
       //     textBox1.Text = String.Join("", "", addresses.ToArray());

        }
       
        private List<String> GetAddress()
        {
            List<Placemark> placemarks = null;

            var statusCode= GMapProviders.GoogleMap.GetPlacemarks(new PointLatLng(lat,longi), out placemarks);
            if(statusCode==GeoCoderStatusCode.G_GEO_SUCCESS && placemarks != null)
            {

                List<String> addresses = new List<string>();
                foreach(var placemark in placemarks)
                {
                    addresses.Add(placemark.Address);
                }
                return addresses;
            }
            return null;

        }
        
       


    }
}
