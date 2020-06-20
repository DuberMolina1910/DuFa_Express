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
        public bool Estado { set; get; }
        public int IdCiudad { set; get; }
        public string ValTotalEnvio { set; get; }
        public string IdEstadoEnvio { set; get; }
        public string FechEnvio { set; get; }
        public string SucursalOrigen { set; get; }
        public string SucursalDestino { set; get; }
        public string IdDestinatario { set; get; }
        public string NomDestinatario { set; get; }
        public string TelDestinatario { set; get; }
        public string DirDestinatario { set; get; }
        public string DetEnvio { set; get; }
        public string IdEnvioGuia { set; get; }
        public string DetCancelacion { set; get; }

        public DatosClient()
        {
        }

        public DatosClient(string pNombreC, string pIDClient, string pFechaNac_C, string pTelefonoC, string pEmail, string pDirDom_C, string pContrasena, string pSucursal, string pTipoId, string pTipoPer, string pCiudad, bool pEstado, int pIdCiudad, string pValTotalEnvio, string pIdEstadoEnvio, string pFechEnvio, string pSucursalOrigen, string pSucursalDestino, string pIdDestinatario, string pNomDestinatario, string pTelDestinatario, string pDirDestinatario, string pDetEnvio, string pIdEnvioGuia, string pDetCancelacion)
        {
            this.NumIdUsu = pNombreC;
            this.NomUsu = pIDClient;
            this.FechNacUsu = pFechaNac_C;
            this.TelUsu = pTelefonoC;
            this.CorreoUsu = pEmail;
            this.DirDomUsu = pDirDom_C;
            this.Contrasena = pContrasena;
            this.SucursalOperarios = pSucursal;
            this.IdTipoId = pTipoId;
            this.IdTipoPer = pTipoPer;
            this.CiudadUsu = pCiudad;
            this.Estado = pEstado;
            this.IdCiudad = pIdCiudad;
            this.ValTotalEnvio = pValTotalEnvio;
            this.IdEstadoEnvio = pIdEstadoEnvio;
            this.FechEnvio = pFechEnvio;
            this.SucursalOrigen = pSucursalOrigen;
            this.SucursalDestino = pSucursalDestino;
            this.IdDestinatario = pIdDestinatario;
            this.NomDestinatario = pNomDestinatario;
            this.TelDestinatario = pTelDestinatario;
            this.DirDestinatario = pDirDestinatario;
            this.DetEnvio = pDetEnvio;
            this.IdEnvioGuia = pIdEnvioGuia;
            this.DetCancelacion = pDetCancelacion;
        }
    }
}
