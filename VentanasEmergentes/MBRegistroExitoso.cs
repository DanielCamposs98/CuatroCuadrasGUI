﻿using System;
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
    public partial class MBRegistroExitoso : Form
    {
        public MBRegistroExitoso()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            FormCollection formulariosApp = Application.OpenForms;
            foreach (Form f in formulariosApp)
            {
                f.Hide();
            }
            InicioSesionForm cc = new InicioSesionForm();
            cc.Show();
        }
    }
}
