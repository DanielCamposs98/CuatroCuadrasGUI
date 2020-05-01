using Persistencia;
using System;
using Soporte.Cache;

namespace Dominio
{
    public class ModeloUsuario
    {

        ConsUser aux  = new ConsUser();

        public bool LoginUsuario(string pass, string user)
        {
                return aux.IniciaSesion(user, pass); 
        }

        public bool inicioSeguro()
        {
            if(UsuarioCache.nickname != null || UsuarioCache.nickname != "")
            {
                if(aux.existeUsuario(UsuarioCache.nickname,UsuarioCache.contraseña) == true)
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
