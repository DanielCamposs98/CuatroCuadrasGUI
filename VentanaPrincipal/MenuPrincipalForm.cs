using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Soporte.Cache;
using Dominio;


namespace CuatroCuadras
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            aplicarSeguridad();
            string user = UsuarioCache.nombre + " " + UsuarioCache.apellidos;
            this.lblBienvenida.Text = "Hola, " + user;
        }

        private void aplicarSeguridad()
        {
            var ModeloUsuario = new ModeloUsuario();
            if (ModeloUsuario.inicioSeguro()== false)
            {
                VentanasEmergentes.MBErrorSeguridad aux = new VentanasEmergentes.MBErrorSeguridad();
                aux.Show();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraSuperiorPane_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptureLibb.ReleaseCapture();
            ReleaseCaptureLibb.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

        }
    }
}
