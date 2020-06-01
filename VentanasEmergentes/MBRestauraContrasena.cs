using System;
using System.Windows.Forms;

namespace CuatroCuadras.VentanasEmergentes
{
    public partial class MBRestauraContrasena : Form
    {
        public MBRestauraContrasena()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            var user = new Dominio.ModeloUsuario();

            string a = txtCorreo.Text;
            var res = user.recuperarContrasena(a);
            
            if (res=="T")
            {
                new MBVerificaCorreo(txtCorreo.Text).ShowDialog();
            }
            else
            {
                lblError.Text= "Lo sentimos, no encontramos ninguna cuenta con dicho email ni usuario";
            }
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            string aux = txtCorreo.Text;
            if (aux.Equals(""))
            {
                txtCorreo.Text = "Ingresa Email";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            string aux = txtCorreo.Text;
            if (aux.Equals("Ingresa Email"))
            {
                txtCorreo.Text = "";
            }
        }

        
            private void txtCorreo_KeyPress(object sender, KeyPressEventArgs pE)
            {
               
                if (txtCorreo.Text.Length > 40)
                {
                    pE.Handled = true;
                }
                else
                {
                    if (Char.IsLetter(pE.KeyChar))
                    {
                        pE.Handled = false;
                       
                    }
                    else if (Char.IsDigit(pE.KeyChar))
                    {
                        pE.Handled = false;
                      
                    }
                    else if (Char.IsControl(pE.KeyChar))
                    {
                        pE.Handled = false;

                    }
                    else
                    {
                        pE.Handled = true;
                    }
                }
            }
    }
}
