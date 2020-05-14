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

            string a = txtUsuario.Text;
            var res = user.recuperarContrasena(a);
            
            if (res=="T")
            {
                new MBVerificaCorreo().ShowDialog();
            }
            else
            {
                lblError.Text= "Lo sentimos, no encontramos ninguna cuenta con dicho email ni usuario";
            }
         
        }
    }
}
