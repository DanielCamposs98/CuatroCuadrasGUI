using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuatroCuadras.Ventanas_Iniciales
{
    public partial class BienvenidaForm : Form
    {
        public BienvenidaForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
                barraProgreso.Value += 5;
            }
            if (barraProgreso.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.03;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();

            }
        }

        private void BienvenidaForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            barraProgreso.Value = 0;
            barraProgreso.Minimum = 0;
            barraProgreso.Maximum = 100;
            timer1.Start();
        }
    }
}
