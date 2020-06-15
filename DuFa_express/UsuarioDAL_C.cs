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

        public static int RegistrarData(DatosClient DatosClient, string pTipoPer)/*Query para registrar usuario Cliente*/
        {
            int resultado = 0;
            SqlConnection Connect = DB_Connection.DBConnection();
            {
                SqlCommand command = new SqlCommand(string.Format("INSERT INTO TABUSUARIOS (NUMIDUSU, NOMUSU, FECHNACUSU, TELUSU, CORREOUSU,  DIRDOMUSU, CONTRASENA, TIPOPER, IDTIPOID) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', HASHBYTES('MD5','{6}'),'{7}','{8}')", DatosClient.NumIdUsu, DatosClient.NomUsu, DatosClient.FechNacUsu.ToString(), DatosClient.TelUsu, DatosClient.CorreoUsu, DatosClient.DirDomUsu, DatosClient.Contrasena, pTipoPer, DatosClient.IdTipoId), Connect);
                resultado = command.ExecuteNonQuery();
                Connect.Close();
            }
            return resultado;
        }


        public static int RegistrarUsu(DatosClient DatosClient)/*Query para registrar usuario Operario*/
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


        public static int AccesoUsuarios(DatosClient DatosClient)/*Query para validar usuario Cliente*/
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


        public static int RegistrarCiudad(string pNomCiudad)/*Query para registrar Ciudades*/
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


        public DataTable ListarIdTipoId()/*Query para mostrar los tipos de identificación*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT IDTIPOID, LTRIM(RTRIM(REPLACE(NOMTIPOID, '', ''))) AS NOMTIPOID FROM TABTIPOID"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();
            return tabla;
        }


        public DataTable ListarTipoPer()/*Query para mostrar los tipos de perfiles*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT IDTIPOPER, LTRIM(RTRIM(REPLACE(DESCTIPOPER, '', ''))) AS DESCTIPOPER FROM TABTIPOPER ORDER BY IDTIPOPER DESC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();
            return tabla;
        }


        public DataTable ListarCiudades()/*Query para mostrar los ciudades*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT IdCiudad, LTRIM(RTRIM(REPLACE(NomCiudad, '', ''))) AS NomCiudad, Estados FROM TABCIUDADES WHERE ESTADOS = '1' ORDER BY NOMCIUDAD ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();

            return tabla;
        }


        public DataTable MostrarCiudadesDGV()/*Query para listar los ciudades en DataGridView de RegCiudad*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT LTRIM(RTRIM(REPLACE(NOMCIUDAD, '', ''))) AS NOMCIUDAD FROM TABCIUDADES WHERE ESTADOS = '1' ORDER BY NOMCIUDAD ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();
            return tabla;
        }

        public DataTable ListarCiudadesDesac()/*Query para listar los ciudades desactivadas en DataGridView*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT LTRIM(RTRIM(REPLACE(NOMCIUDAD, '', ''))) AS NOMCIUDAD FROM TABCIUDADES WHERE ESTADOS = '0' ORDER BY NOMCIUDAD ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();
            return tabla;
        }


        public static int EstadosCiudades(DatosClient DatosClient)/*Query para Desactivar o Activar los ciudades*/
        {
            int rest = 0;
            SqlConnection Connect = DB_Connection.DBConnection();
            {
                SqlCommand com = new SqlCommand(string.Format("UPDATE TABCIUDADES SET ESTADOS='{0}' WHERE NOMCIUDAD='{1}'", DatosClient.Estado, DatosClient.CiudadUsu), Connect);
                rest = com.ExecuteNonQuery();
                Connect.Close();
            }
            return rest;
        }


        public DataTable ListarSucursales()/*Query para mostrar los sucursales*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT IDSUCURSAL, IDCIUDAD, LTRIM(RTRIM(REPLACE(NOMSUCURSAL, '', ''))) AS NOMSUCURSAL, ESTADOSSUC FROM TABSUCURSALES ORDER BY NOMSUCURSAL ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();
            return tabla;
        }


        public DataTable ListarSucursalesDGV()/*Query para mostrar los sucursales activas en el DataGridView de RegSuc*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT LTRIM(RTRIM(REPLACE(NOMCIUDAD, '', ''))) AS NOMCIUDAD, LTRIM(RTRIM(REPLACE(NOMSUCURSAL, '', ''))) AS NOMSUCURSAL FROM TABSUCURSALES, TABCIUDADES WHERE TABSUCURSALES.IDCIUDAD = TABCIUDADES.IDCIUDAD AND TABSUCURSALES.ESTADOSSUC = '1' AND TABCIUDADES.ESTADOS = '1'  ORDER BY NOMCIUDAD ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();
            return tabla;
        }

        public static int RegistrarSuc(int pIdCiudad, string pNomSuc)/*Query para registrar Sucursales*/
        {
            int resultado = 0;
            SqlConnection Connect = DB_Connection.DBConnection();
            {
                SqlCommand command = new SqlCommand(string.Format("INSERT INTO TABSUCURSALES (IDCIUDAD, NOMSUCURSAL) VALUES ('{0}','{1}')", pIdCiudad, pNomSuc), Connect);
                resultado = command.ExecuteNonQuery();
                Connect.Close();
            }
            return resultado;
        }

        public DataTable ListarSucursalesDesac()/*Query para mostrar las sucursales deshabilitadas*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();

            DataTable tabla = new DataTable();
            SqlCommand command = new SqlCommand(string.Format("SELECT LTRIM(RTRIM(REPLACE(NOMCIUDAD, '', ''))) AS NOMCIUDAD, LTRIM(RTRIM(REPLACE(NOMSUCURSAL, '', ''))) AS NOMSUCURSAL FROM TABSUCURSALES,TABCIUDADES WHERE TABSUCURSALES.IDCIUDAD = TABCIUDADES.IDCIUDAD AND TABSUCURSALES.ESTADOSSUC = '0' AND TABCIUDADES.ESTADOS = '1'  ORDER BY NOMCIUDAD ASC"), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            tabla.Load(Reader);
            Reader.Close();
            Connect.Close();
            return tabla;
        }


        public static int EstadosSucursales(DatosClient DatosClient)/*Query para Desactivar o Activar Sucursales*/
        {
            int rest = 0;
            SqlConnection Connect = DB_Connection.DBConnection();
            {
                SqlCommand com = new SqlCommand(string.Format("UPDATE TABSUCURSALES SET ESTADOSSUC='{0}' WHERE NOMSUCURSAL ='{1}'", DatosClient.Estado, DatosClient.SucursalOperarios), Connect);
                rest = com.ExecuteNonQuery();
                Connect.Close();
            }
            return rest;
        }

        public static int CosultarUsuarios(DatosClient DatosClient)/*Query para validar usuario al consultar en el registro de envios*/
        {
            SqlConnection Connect = DB_Connection.DBConnection();
            int resultado = -1;
            SqlCommand command = new SqlCommand(string.Format("SELECT TABUSUARIOS.*, TABTIPOPER.DESCTIPOPER, TABTIPOID.NOMTIPOID FROM TABUSUARIOS, TABTIPOPER, TABTIPOID WHERE NUMIDUSU = '{0}' AND TABUSUARIOS.IDTIPOPER = '{1}' AND TABTIPOID.IDTIPOID = TABUSUARIOS.IDTIPOID", DatosClient.NumIdUsu, DatosClient.IdTipoPer), Connect);
            SqlDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                CacheRegEnvio.NomUsu = Reader.GetString(3);
                CacheRegEnvio.TelUsu = Reader.GetString(5);
                CacheRegEnvio.CorreoUsu = Reader.GetString(6);
                CacheRegEnvio.DirDomUsu = Reader.GetString(7);
                resultado = 50;
            }
            Connect.Close();
            return resultado;
        }

    }
}