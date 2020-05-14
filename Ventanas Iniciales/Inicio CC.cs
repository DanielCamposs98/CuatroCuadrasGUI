using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuatroCuadras.Ventanas_Iniciales;
using Dominio;
using Soporte.Cache;

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
            //  RegistroUsuarioForm ru = new RegistroUsuarioForm();
            // ru.Show();
        }

        #region ArrastrarVentana
        private void panInicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptureLibb.ReleaseCapture();
            ReleaseCaptureLibb.SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PanLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCaptureLibb.ReleaseCapture();
            ReleaseCaptureLibb.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            string aux = this.txtUsuario.Text;
            if (aux.Equals("USUARIO"))
            {
                this.txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            string aux = this.txtUsuario.Text;
            if (aux.Equals(""))
            {
                this.txtUsuario.Text = "USUARIO";
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            string aux = this.txtPass.Text;
            if (aux.Equals("CONTRASEÑA"))
            {
                this.txtPass.Text = "";
                this.txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            string aux = this.txtPass.Text;
            if (aux.Equals(""))
            {
                this.txtPass.Text = "CONTRASEÑA";
                this.txtPass.UseSystemPasswordChar = false;
            }
        }

        private void pbEye_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtPass.UseSystemPasswordChar = false;
        }

        private void pbEye_MouseUp(object sender, MouseEventArgs e)
        {
            string aux = this.txtPass.Text;
            if (aux.Equals("CONTRASEÑA"))
            {
                this.txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPass.UseSystemPasswordChar = true;
            }

        }

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
                        this.Hide();
                        BienvenidaForm welcome = new BienvenidaForm();
                        welcome.ShowDialog();
                        CuatroCuadras mainMenu = new CuatroCuadras();
                        mainMenu.Show();
                        mainMenu.FormClosed += cerrarSesion;

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

        private void mostrarError(string cad)
        {
            lblMensError.Text = cad;
            lblMensError.Visible = true;
        }

        private void lkFPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var oc = new VentanasEmergentes.MBRestauraContrasena();
            oc.ShowDialog();
        }

        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "CONTRASEÑA";
            txtPass.UseSystemPasswordChar = false;
            txtUsuario.Text = "USUARIO";
            lblMensError.Visible = false;
            this.Show();
        }

    }
}