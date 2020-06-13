using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DuFa_express
{
    public class DataUsers
    {

        public string NombreCompleto { set; get; }
        public string NumeroEmpleado { set; get; }
        public string Sucursal { set; get; }
        public string Contrasena { set; get; }

        public DataUsers()
        {
            
        }

        public DataUsers(String pNombreUsuario,String pNumeroEmpleado, String pSucursal, String pContrasena)
        {
            this.NombreCompleto = pNombreUsuario;
            this.NumeroEmpleado = pNumeroEmpleado;
            this.Sucursal = pSucursal;
            this.Contrasena = pContrasena;
        }

    }
}
