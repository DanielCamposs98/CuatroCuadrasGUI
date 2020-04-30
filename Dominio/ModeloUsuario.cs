using Persistencia;
using System;

namespace Dominio
{
    public class ModeloUsuario
    {

        ConsUser aux  = new ConsUser();

        public bool LoginUsuario(string pass, string user)
        {
                return aux.IniciaSesion(user, pass); 
        }
    }
}
