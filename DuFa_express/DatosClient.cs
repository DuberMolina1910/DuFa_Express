using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DuFa_express
{
    public class DatosClient
    {
        public string NomUsu { set; get; }
        public string NumIdUsu { set; get; }
        public string FechNacUsu { set; get; }
        public string TelUsu { set; get; }
        public string CorreoUsu { set; get; }
        public string DirDomUsu { set; get; }
        public string Contrasena { set; get; }
        public string SucursalOperarios { set; get; }
        public string IdTipoId { set; get; }
        public string IdTipoPer { set; get; }
        public string CiudadUsu { set; get; }
        public string NomTipoPer { set; get; }

        //public DatosClient()
        //{

        //}

        //public DatosClient(String pNombreC, String pIDClient, String pFechaNac_C, String pTelefonoC, String pEmail, String pDirDom_C, String pContrasena, String pSucursal, String pTipoId, String pTipoPer, String pCiudad, String pNomTipoPer)
        //{
        //    this.NumIdUsu = pNombreC;
        //    this.NomUsu = pIDClient;
        //    this.FechNacUsu = pFechaNac_C;
        //    this.TelUsu = pTelefonoC;
        //    this.CorreoUsu = pEmail;
        //    this.DirDomUsu = pDirDom_C;
        //    this.Contrasena = pContrasena;
        //    this.SucursalOperarios = pSucursal;
        //    this.IdTipoId = pTipoId;
        //    this.IdTipoPer = pTipoPer;
        //    this.CiudadUsu = pCiudad;
        //    this.NomTipoPer = pNomTipoPer;
        //}
    }
}
