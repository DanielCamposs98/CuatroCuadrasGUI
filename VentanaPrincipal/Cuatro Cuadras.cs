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
    public partial class CuatroCuadras : Form
    {
        public CuatroCuadras()
        {
            InitializeComponent();
        }

        private void MenuPrincipalForm_Load(object sender, EventArgs e)
        {
            aplicarSeguridad();
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
            if (MessageBox.Show("Are you sure to log out?", "Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
              this.Close();

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Otros.UsoFormulario.AbrirFormulario<VentanasComplementarias.VentanaPerfil>(panelPrincipal);
        }
    }
    }
