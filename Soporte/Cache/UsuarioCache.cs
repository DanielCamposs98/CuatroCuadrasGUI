using System;
using System.Collections.Generic;
using System.Text;

namespace Soporte.Cache
{
   public static class UsuarioCache
    {
        public static string nickname { get; set; }
        public static string nombre { get; set; }
        public static string apellidos { get; set; }
        public static Char sexo { get; set; }
        public static DateTime fechaNacimiento { get; set; }
        public static string email { get; set; }
        public static string contraseña { get; set; }
        public static int ciudad { get; set; }

    }
}
