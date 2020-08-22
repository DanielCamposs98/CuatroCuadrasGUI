using Dominio;
using Soporte.Cache;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CuatroCuadras.VentanasComplementarias
{
    public partial class VentanaConfig : Form
    {
        public VentanaConfig()
        {
            InitializeComponent();
        }

        private void VentanaConfig_Load(object sender, EventArgs e)
        {
            llenaDatosPersonales();
            lblMsgError.Visible = true;
        }

        private void llenaDatosPersonales()
        {
            txtNickname.Text = UsuarioCache.nickname;
            txtNombre.Text = UsuarioCache.nombre;
            txtApellidos.Text = UsuarioCache.apellidos;
            txtCorreo.Text = UsuarioCache.email;
            txtContrasena.Text = UsuarioCache.contraseña;
            cmbCiudades.Items.Add(obtenNombreCiudad(UsuarioCache.ciudad));
            cmbCiudades.SelectedIndex = 0;
            string sexo;
            if (UsuarioCache.sexo.Equals("M"))
            {
                sexo = "Masculino";
            }
            else
            {
                sexo = "Femenino";
            }
            cmbSexo.Items.Add(sexo);
            cmbSexo.SelectedIndex = 0;

            dpFecha.Value = UsuarioCache.fechaNacimiento.Date;
            llenaCmbCiudades();
        }

        private void llenaCmbCiudades()
        {
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = "SELECT ciudad FROM CIUDAD";
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbCiudades.Items.Add(reader.GetValue(0).ToString());
                    }
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            btnEditar.Visible = false;
            txtNombre.Enabled = true;
            txtApellidos.Enabled = true;
            txtCorreo.Enabled = true;
            txtContrasena.Enabled = true;
            txtConfirmaContrasena.Enabled = true;
            txtContrasena.isPassword = false;
            btnConfirmar.Enabled = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (botonesVacios())
            {
                lblMsgError.Text = "No debes dejar campos vacíos";
            }
            else
            {
                string contra = txtConfirmaContrasena.Text;

                if (contra.Equals(""))
                {
                    lblMsgError.Text = "La contraseña de confirmación es invalida";
                }
                else
                {
                    if (contra.Equals(UsuarioCache.contraseña))
                    {
                        SqlDataReader reader;
                        using (var connection = ModeloUsuario.GetConsUser().GetConnection())
                        {
                            connection.Open();
                            using (var command = new SqlCommand())
                            {
                                string nombre = txtNombre.Text;
                                string apellidos = txtApellidos.Text;
                                string correo = txtCorreo.Text;
                                string contrasena = txtContrasena.Text;

                                command.Connection = connection;
                                command.CommandText = string.Format("UPDATE USUARIO SET nombre='{0}',apellidos='{1}',email='{2}',contrasena='{3}' WHERE Nickname='{4}'", nombre, apellidos, correo, contrasena, UsuarioCache.nickname);
                                command.CommandType = CommandType.Text;
                                reader = command.ExecuteReader();

                                UsuarioCache.contraseña = contrasena;
                                UsuarioCache.nombre = nombre;
                                UsuarioCache.email = correo;
                                UsuarioCache.apellidos = apellidos;

                                lblMsgError.Text = "Datos Actualizados Correctamente";

                                btnEditar.Visible = true;
                                txtNombre.Enabled = false;
                                txtApellidos.Enabled = false;
                                txtCorreo.Enabled = false;
                                txtContrasena.Enabled = false;
                                txtConfirmaContrasena.Enabled = false;
                                txtContrasena.isPassword = true;
                                btnConfirmar.Enabled = false;

                                txtNombre.Text = UsuarioCache.nombre;
                                txtApellidos.Text = UsuarioCache.apellidos;
                                txtCorreo.Text = UsuarioCache.email;
                                txtContrasena.Text = UsuarioCache.contraseña;
                                txtConfirmaContrasena.Text = "";

                            }
                        }
                    }
                }
            }
        }

        private bool botonesVacios()
        {
            if (txtNombre.Text.Trim().Equals("") || txtApellidos.Text.Trim().Equals("") || txtCorreo.Text.Trim().Equals("") || txtContrasena.Text.Trim().Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string obtenNombreCiudad(int ciudad)
        {
            string nomCity = "";
            SqlDataReader reader;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    string nombre = txtNombre.Text;
                    string apellidos = txtApellidos.Text;
                    string correo = txtCorreo.Text;
                    string contrasena = txtContrasena.Text;

                    command.Connection = connection;
                    command.CommandText = string.Format("SELECT ciudad FROM Ciudad WHERE ID_Ciudad={0}", ciudad);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        nomCity = reader.GetValue(0).ToString();
                    }

                }
            }
            return nomCity;
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

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs pE)
        {
            if (txtApellidos.Text.Length > 50)
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

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs pE)
        {
            lblMsgError.Text = "";
            if (txtCorreo.Text.Length > 40)
            {
                pE.Handled = true;
            }
            else
            {
                if (Char.IsLetter(pE.KeyChar))
                {
                    pE.Handled = false;
                    if (!email_bien_escrito(txtCorreo.Text))
                    {
                        lblMsgError.Text = "Correo Invalido";
                    }
                }
                else if (Char.IsDigit(pE.KeyChar))
                {
                    pE.Handled = false;
                    if (!email_bien_escrito(txtCorreo.Text))
                    {
                        lblMsgError.Text = "Correo Invalido";
                    }
                }
                else if (Char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;

                }
                else if (Char.IsSymbol(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else if (pE.KeyChar.Equals('@') || pE.KeyChar.Equals('.'))
                {
                    pE.Handled = false;
                }
                else
                {
                    pE.Handled = true;
                }
            }


        }

        private bool email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs pE)
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

