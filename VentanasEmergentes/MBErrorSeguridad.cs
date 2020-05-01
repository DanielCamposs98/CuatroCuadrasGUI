using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuatroCuadras.VentanasEmergentes
{
    public partial class MBErrorSeguridad : Form
    {
        public MBErrorSeguridad()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
