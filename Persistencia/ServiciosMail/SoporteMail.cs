using System;
using System.Collections.Generic;
using System.Text;

namespace Persistencia.ServiciosMail
{
    class SoporteMail: ServidorMail
    {
        public SoporteMail()
        {
            remitente = "cuatrocuadrasuser@gmail.com";
            contrasena = "CCAdministrador";
            host = "smtp.gmail.com";
            puerto = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
