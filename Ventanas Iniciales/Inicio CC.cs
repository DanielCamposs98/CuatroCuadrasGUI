using CuatroCuadras.Ventanas_Iniciales;
using Dominio;
using System;
using System.Windows.Forms;

namespace CuatroCuadras
{
    public partial class InicioSesionForm : Form
    {

        public InicioSesionForm()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lkCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            VentanasCrearCuenta.CreaCuentaV1 ru = new VentanasCrearCuenta.CreaCuentaV1();
            ru.Show();
            ru.FormClosed += devolverVentana;

        }

        #region ArrastrarVentana
        private void panInicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptureLibb.ReleaseCapture();
            ReleaseCaptureLibb.SendMessage(Handle, 0x112, 0xf012, 0);

        }

        private void PanLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptureLibb.ReleaseCapture();
            ReleaseCaptureLibb.SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region ManejaUsuario
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            string aux = txtUsuario.Text;
            if (aux.Equals("USUARIO"))
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            string aux = txtUsuario.Text;
            if (aux.Equals(""))
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        #endregion ManejaUsuario

        #region manejaPass
        private void txtPass_Enter(object sender, EventArgs e)
        {
            string aux = txtPass.Text;
            if (aux.Equals("CONTRASEÑA"))
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            string aux = txtPass.Text;
            if (aux.Equals(""))
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void pbEye_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pbEye_MouseUp(object sender, MouseEventArgs e)
        {
            string aux = txtPass.Text;
            if (aux.Equals("CONTRASEÑA"))
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }

        }
        #endregion ManejaPass

        #region ManejaBtnIniciaSesion
        private void btnIniciaSesion_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtPass.Text;
            if (user != "USUARIO" && user.Length > 2)
            {
                if (pass != "CONTRASEÑA")
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var sesionValida = usuario.LoginUsuario(pass, user);
                    if (sesionValida == true)
                    {
                        Hide();
                        BienvenidaForm welcome = new BienvenidaForm();
                        welcome.ShowDialog();
                        CuatroCuadras mainMenu = new CuatroCuadras();
                        mainMenu.Show();
                        mainMenu.FormClosed += devolverVentana;

                    }
                    else
                    {
                        mostrarError("Usuario y/o Contraseña incorrecta(s).");
                    }
                }
                else
                {
                    mostrarError("Ingrese la contraseña.");
                }
            }
            else
            {
                mostrarError("Ingrese usuario");
            }
        }
        #endregion ManejaBtnInicioSesion

        private void lkFPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var oc = new VentanasEmergentes.MBRestauraContrasena();
            oc.ShowDialog();
        }

        private void mostrarError(string cad)
        {
            lblMensError.Text = cad;
            lblMensError.Visible = true;
        }

        private void devolverVentana(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensError.Visible = false;
            Show();
        }

    }
}