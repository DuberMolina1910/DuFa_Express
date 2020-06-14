using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuFa_express
{
    class Cache
    {
        public static string NomUsu { set; get; }
        public static int NumIdUsu { set; get; }
        public static DateTime FechNacUsu { set; get; }
        public static string TelUsu { set; get; }
        public static string CorreoUsu { set; get; }
        public static string DirDomUsu { set; get; }
        public static string Contrasena { set; get; }
        public static string SucursalOperarios { set; get; }
        public static string IdTipoId { set; get; }
        public static string IdTipoPer { set; get; }
        public static string CiudadUsu { set; get; }
        public static string NomTipoPer { set; get; }
        public static string NomTipoId { set; get; }
    }

    class CacheRegEnvio
    {
        public static string NomUsu { set; get; }
        public static string TelUsu { set; get; }
        public static string CorreoUsu { set; get; }
        public static string DirDomUsu { set; get; }        
        public static string ValTotalEnvio { set; get; }

    }
}
