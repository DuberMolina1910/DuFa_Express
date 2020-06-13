using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DuFa_express
{
    class UsuarioDAL_C
    {
        /*Query para registrar usuario Cliente*/
        public static int RegistrarData(DatosClient DatosClient, string pTipoPer)
        {
            int resultado = 0;
            SqlConnection Connect = DB_Connection.DBConnection();
            {
                SqlCommand command = new SqlCommand(string.Format("INSERT INTO TABUSUARIOS (NUMIDUSU, NOMUSU, FECHNACUSU, TELUSU, CORREOUSU,  DIRDOMUSU, CONTRASENA, TIPOPER, IDTIPOID) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', HASHBYTES('MD5','{6}'),'{7}','{8}')", DatosClient.NumIdUsu, DatosClient.NomUsu, DatosClient.FechNacUsu.ToString(), DatosClient.TelUsu, DatosClient.CorreoUsu, DatosClient.DirDomUsu, DatosClient.Contrasena, pTipoPer,DatosClient.IdTipoId), Connect);
                resultado = command.ExecuteNonQuery();
                Connect.Close();
            }
            return resultado;
        }

        /*Query para registrar usuario Operario*/
        public static int RegistrarUsu(DatosClient DatosClient)
        {
            int resultado = 0;
            SqlConnection Connect = DB_Connection.DBConnection();
            {
                SqlCommand command = new SqlCommand(string.Format("INSERT INTO TABUSUARIOS (NUMIDUSU, IDTIPOPER, NOMUSU, FECHNACUSU, TELUSU, CORREOUSU,  DIRDOMUSU, CONTRASENA, IDTIPOID, SUCOPERARIOS) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', HASHBYTES('MD5','{7}'),'{8}','{9}')", DatosClient.NumIdUsu, DatosClient.IdTipoPer, DatosClient.NomUsu, DatosClient.FechNacUsu.ToString(), DatosClient.TelUsu, DatosClient.CorreoUsu, DatosClient.DirDomUsu, DatosClient.Contrasena, DatosClient.IdTipoId, DatosClient.SucursalOperarios), Connect);
                resultado = command.ExecuteNonQuery();
                Connect.Close();
            }
            return resultado;
        }

        /*Query para validar usuario Cliente*/
        public static int AccesoUsuarios(DatosClient DatosClient)
        {
            SqlConnection Connect = DB_Connection.DBConnection();
            int resultado = -1;
            SqlCommand command = new SqlCommand(string.Format("SELECT TABUSUARIOS.*, TABTIPOPER.DESCTIPOPER, TABTIPOID.NOMTIPOID FROM TABUSUARIOS, TABTIPOPER, TABTIPOID WHERE NUMIDUSU = '{0}' AND HASHBYTES('MD5','{1}') = CONTRASENA AND TABTIPOPER.IDTIPOPER = '{2}' AND TABTIPOID.IDTIPOID = TABUSUARIOS.IDTIPOID", DatosClient.NumIdUsu, DatosClient.Contrasena, DatosClient.IdTipoPer), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                Cache.NumIdUsu = Reader.GetInt32(1);
                Cache.NomUsu = Reader.GetString(3);
                Cache.FechNacUsu = Reader.GetDateTime(4);
                Cache.TelUsu = Reader.GetString(5);
                Cache.CorreoUsu = Reader.GetString(6);
                Cache.DirDomUsu = Reader.GetString(7);
                Cache.NomTipoPer = Reader.GetString(11);
                Cache.NomTipoId = Reader.GetString(12);
                resultado = 50;
            }
            Connect.Close();
            return resultado;
        }

        /*Query para registrar Ciudades*/
        public static int RegistrarCiudad(string pNomCiudad)
        {
            int resultado = 0;
            SqlConnection Connect = DB_Connection.DBConnection();
            {
                SqlCommand command = new SqlCommand(string.Format("INSERT INTO TABCIUDADES  (NOMCIUDAD) VALUES ('{0}')", pNomCiudad), Connect);
                resultado = command.ExecuteNonQuery();
                Connect.Close();
            }
            return resultado;
        }

        /*Query para mostrar los tipos de identificación*/
        public DataTable ListarIdTipoId()
        {
            SqlConnection Connect = DB_Connection.DBConnection();
            
            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM TABTIPOID ORDER BY IDTIPOID ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();

            return tabla;
        }

        /*Query para mostrar los tipos de perfiles*/
        public DataTable ListarTipoPer()
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM TABTIPOPER ORDER BY IDTIPOPER DESC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();

            return tabla;
        }

        /*Query para mostrar los ciudades*/
        public DataTable ListarCiudades()
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM TABCIUDADES ORDER BY NOMCIUDAD ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();

            return tabla;
        }
        /*Query para listar los ciudades en DataGridView*/
        public DataTable MostrarCiudades()
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT NOMCIUDAD FROM TABCIUDADES WHERE ESTADOS = '0' ORDER BY NOMCIUDAD ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();

            return tabla;
        }
        /*Query para Desactivar los ciudades en DataGridView*/
        public static int  DesactivarCiudades(DatosClient DatosClient)
        {
            int rest = 0;
            SqlConnection Connect = DB_Connection.DBConnection();
            {
                SqlCommand com = new SqlCommand(string.Format("UPDATE TABCIUDADES SET ESTADOS='{0}' WHERE NOMCIUDAD='{1}'",DatosClient.Estado ,DatosClient.CiudadUsu),Connect);          
                rest = com.ExecuteNonQuery();
                Connect.Close();
            }
            return rest;
        }
        /*Query para mostrar los sucursales*/
        public DataTable ListarSucursales()
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT * FROM TABSUCURSALES ORDER BY NOMSUCURSAL ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();

            return tabla;
        }
    }
}