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
using CuatroCuadras.VentanasEmergentes;

namespace CuatroCuadras
{
    public partial class CuatroCuadras : Form
    {
        public static Panel panelP;
        public CuatroCuadras()
        {
            InitializeComponent();
            panelP = panelPrincipal;
        }

       
        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            aplicarSeguridad();
            Otros.UsoFormulario.AbrirFormulario<VentanasComplementarias.VentanaInicio>(panelPrincipal);
        }

        private void aplicarSeguridad()
        {
            var ModeloUsuario = new ModeloUsuario();
            if (ModeloUsuario.inicioSeguro() == false)
            {
                VentanasEmergentes.MBErrorSeguridad aux = new VentanasEmergentes.MBErrorSeguridad();
                aux.ShowDialog();
            }
        }

      

        private void BarraSuperiorPane_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptureLibb.ReleaseCapture();
            ReleaseCaptureLibb.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new MBConfirmarLogout().ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Otros.UsoFormulario.AbrirFormularioParametrosPerfil<VentanasComplementarias.VentanaPerfil>(panelPrincipal,UsuarioCache.nickname);
        }

        private void btnAmigos_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Otros.UsoFormulario.AbrirFormulario<VentanasComplementarias.VentanaAmigos>(panelPrincipal);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Clear();
            Otros.UsoFormulario.AbrirFormulario<VentanasComplementarias.VentanaInicio>(panelPrincipal);
        }

        private void btnVisitas_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Otros.UsoFormulario.AbrirFormulario<VentanasComplementarias.VentanaLugares>(panelPrincipal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Otros.UsoFormulario.AbrirFormulario<VentanasComplementarias.VentanaConfig>(panelPrincipal);
        }
    }
    }
