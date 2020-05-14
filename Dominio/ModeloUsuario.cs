using Persistencia;
using Soporte.Cache;

namespace Dominio
{
    public class ModeloUsuario
    {

        private ConsUser aux = new ConsUser();

        public string recuperarContrasena(string solicitud)
        {

            return aux.RecuperarContrasena(solicitud);
        }


        public bool LoginUsuario(string pass, string user)
        {
            return aux.IniciaSesion(user, pass);
        }

        public bool inicioSeguro()
        {
            if (UsuarioCache.nickname != null)
            {
                if (aux.existeUsuario(UsuarioCache.nickname, UsuarioCache.contraseña) == true)
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


    }
}
