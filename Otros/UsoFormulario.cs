using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuatroCuadras.Otros
{
    class UsoFormulario
    {
        public static void AbrirFormulario<MiForm>(Panel m) where MiForm : Form, new()
        {
            Form formulario;
            formulario = m.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                m.Controls.Add(formulario);
                m.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
    }
}
