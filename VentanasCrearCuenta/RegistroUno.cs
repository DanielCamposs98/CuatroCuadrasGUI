using Dominio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CuatroCuadras.VentanasCrearCuenta
{
    public partial class CreaCuentaV1 : Form
    {
        public CreaCuentaV1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            new VentanasEmergentes.MBCancelarCrearUsuario().ShowDialog();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
                lblMensError.Text = "Debes rellenar todos los campos";
            }
            else
            {
                if (existeUsuario())
                {
                    lblMensError.Visible = true;
                    lblMensError.Text = "El usuario ya existe";
                }
                else
                {
                    string user = txtUsuario.Text;
                    string nombre = txtNombre.Text;
                    string apellido = txtApellido.Text;
                    char sexo = ' ';
                    string sexoo = cmbSexo.GetItemText(cmbSexo.SelectedItem);
                    if (sexoo.Equals("Masculino"))
                    {
                        sexo = 'M';
                    }
                    else if (sexoo.Equals("Femenino"))
                    {
                        sexo = 'F';
                    }

                    Hide();
                    new VentanasCrearCuenta.CreaCuentaV2(user, nombre, apellido, sexo).Show();

                }
            }


        }

        private bool existeUsuario()
        {
            SqlDataReader reader;
            string user = txtUsuario.Text;

            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT * FROM USUARIO WHERE nickname='{0}'", user);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                }
            }
        }

        private void CreaCuentaV1_Load(object sender, EventArgs e)
        {
            cmbSexo.SelectedIndex = 0;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            string aux = txtUsuario.Text;
            if (aux.Equals("Usuario"))
            {
                txtUsuario.Text = "";
            }
        }



        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            string aux = txtUsuario.Text;
            if (aux.Equals(""))
            {
                txtUsuario.Text = "Usuario";
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            string aux = txtNombre.Text;
            if (aux.Equals(""))
            {
                txtNombre.Text = "Nombre";
            }

        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            string aux = txtNombre.Text;
            if (aux.Equals("Nombre"))
            {
                txtNombre.Text = "";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            string aux = txtApellido.Text;
            if (aux.Equals("Apellido"))
            {
                txtApellido.Text = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            string aux = txtApellido.Text;
            if (aux.Equals(""))
            {
                txtApellido.Text = "Apellido";
            }
        }

        private bool validarCamposVacios()
        {
            bool aux = false;
            if (txtUsuario.Text.Equals("Usuario") || txtNombre.Text.Equals("Nombre") || txtApellido.Text.Equals("Apellidos"))
            {
                aux = true;
            }
            else
            {
                aux = false;
            }
            return aux;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs pE)
        {
            if (txtUsuario.Text.Length > 30)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs pE)
        {
            if (txtNombre.Text.Length > 40)
            {
                pE.Handled = true;
            }
            else
            {
                if (Char.IsLetter(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (Char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (Char.IsSeparator(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                {
                    pE.Handled = true;
                }
            }

        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs pE)
        {
            if (txtApellido.Text.Length > 50)
            {
                pE.Handled = true;
            }
            else
            {
                if (Char.IsLetter(pE.KeyChar))
                {
                    pE.Handled = false;
                }

                else if (Char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (Char.IsSeparator(pE.KeyChar))
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


