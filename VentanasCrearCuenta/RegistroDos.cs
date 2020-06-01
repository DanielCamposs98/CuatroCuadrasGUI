using Dominio;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CuatroCuadras.VentanasCrearCuenta
{
    public partial class CreaCuentaV2 : Form
    {
        private string user;
        private string nombre;
        private string apellido;
        private char sexo;
        private string correo, contraseña;
        private int ciudad;
        private string dia, mes, año;

        public CreaCuentaV2(string user, string nombre, string apellido, char sexo)
        {
            InitializeComponent();
            this.user = user;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            new VentanasEmergentes.MBCancelarCrearUsuario().ShowDialog();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (validarCamposVacios())
            {
                lblMensError.Text = "Se deben rellenar todos los campos";
            }
            else
            {
                if (existeCorreo())
                {
                    lblMensError.Visible = true;
                    lblMensError.Text = "El correo ya está registrado";
                }
                else
                {
                    correo = txtCorreo.Text;
                    ciudad = obtenCiudad();
                    dia = dpFechaNac.Value.Day.ToString();
                    mes = dpFechaNac.Value.Month.ToString();
                    año = dpFechaNac.Value.Year.ToString();
                    if (txtContraseña.Text.Equals(txtRepCont.Text))
                    {
                        contraseña = txtContraseña.Text;
                        agregarUsuario();
                    }
                    else
                    {
                        lblMensError.Visible = true;
                        lblMensError.Text = "Las contraseñas no concuerdan";
                    }
                }
            }


        }

        private bool existeCorreo()
        {
            SqlDataReader reader;
            string correo = txtCorreo.Text;

            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT * FROM USUARIO WHERE email='{0}'", correo);
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

        private int obtenCiudad()
        {
            string ciudad = cmbCiudad.GetItemText(cmbCiudad.SelectedItem);
            SqlDataReader reader;
            int aux = -1;
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Obtener nombre ciudad
                    command.Connection = connection;
                    command.CommandText = String.Format("SELECT ID_Ciudad FROM Ciudad WHERE ciudad='{0}'", ciudad);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        aux = Convert.ToInt32(reader.GetValue(0));
                    }
                }
            }
            return aux;
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            string aux = txtCorreo.Text;
            if (aux.Equals(""))
            {
                txtCorreo.Text = "Correo";
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            string aux = txtCorreo.Text;
            if (aux.Equals("Correo"))
            {
                txtCorreo.Text = "";
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            string aux = txtContraseña.Text;
            if (aux.Equals(""))
            {
                txtContraseña.isPassword = false;
                txtContraseña.Text = "Contraseña";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            string aux = txtContraseña.Text;
            if (aux.Equals("Contraseña"))
            {
                txtContraseña.isPassword = true;
                txtContraseña.Text = "";
            }
        }

        private void txtRepCont_Leave(object sender, EventArgs e)
        {
            string aux = txtRepCont.Text;
            if (aux.Equals(""))
            {
                txtRepCont.isPassword = false;
                txtRepCont.Text = "Repite Contraseña";
            }
        }

        private void txtRepCont_Enter(object sender, EventArgs e)
        {
            string aux = txtRepCont.Text;
            if (aux.Equals("Repite Contraseña"))
            {
                txtRepCont.isPassword = true;
                txtRepCont.Text = "";
            }
        }

        private void agregarUsuario()
        {
            using (var connection = ModeloUsuario.GetConsUser().GetConnection())
            {
                SqlDataReader reader;
                connection.Open();
                string fecha = String.Format("{0}-{1}-{2}", año, mes, dia);
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = String.Format("exec USP_InsertUsuarioLogro '{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7}", user, nombre, apellido, sexo, fecha, correo, contraseña, ciudad);
                    command.CommandType = CommandType.Text;
                    reader = command.ExecuteReader();
                }
                Hide();
                new VentanasEmergentes.MBRegistroExitoso().Show();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs pE)
        {
            lblMensError.Text = "";
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
                        lblMensError.Text = "Correo Invalido";
                    }
                }
                else if (Char.IsDigit(pE.KeyChar))
                {
                    pE.Handled = false;
                    if (!email_bien_escrito(txtCorreo.Text))
                    {
                        lblMensError.Text = "Correo Invalido";
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

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs pE)
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


        private void txtContraseñaR_KeyPress(object sender, KeyPressEventArgs pE)
        {
            lblMensError.Text = "";
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
                { 
}
                if (!txtContraseña.Text.Equals(txtRepCont.Text))
                {
                    lblMensError.Text = "Las contraseñas no coinciden";
                }
                else
                {
                    lblMensError.Text = "";
                }
            }
            else if (Char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
                if (!txtContraseña.Text.Equals(txtRepCont.Text))
                {
                    lblMensError.Text = "Las contraseñas no coinciden";
                }
                else
                {
                    lblMensError.Text = "";
                }
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
                if (!txtContraseña.Text.Equals(txtRepCont.Text))
                {
                    lblMensError.Text = "Las contraseñas no coinciden";
                }
                else
                {
                    lblMensError.Text = "";
                }
            }
            else
            {
                pE.Handled = true;
            }
        }
    

    private void CreaCuentaV2_Load(object sender, EventArgs e)
    {
        obtenListaCiudades();
        cmbCiudad.SelectedIndex = 0;

    }

    private void obtenListaCiudades()
    {
        using (var connection = ModeloUsuario.GetConsUser().GetConnection())
        {
            SqlDataReader reader;
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = String.Format("SELECT ciudad FROM Ciudad");
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbCiudad.Items.Add(reader.GetValue(0));
                }
            }
        }
    }

    private bool validarCamposVacios()
    {
        bool aux = false;
        if (txtCorreo.Text.Equals("Correo") || txtContraseña.Text.Equals("Contraseña") || txtRepCont.Text.Equals("Repite Contraseña"))
        {
            aux = true;
        }
        else
        {
            aux = false;
        }
        return aux;
    }
}
}
