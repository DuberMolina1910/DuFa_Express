using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DuFa_express
{
    class DB_Connection
    {
        public static SqlConnection DBConnection()
        {
            //FabianDB
            //SqlConnection Connect = new SqlConnection("Data source = DESKTOP-416QJ6G\\SQLEXPRESS; Initial Catalog = DuFa_express; Integrated Security = True");

            //DuberDB
            SqlConnection Connect = new SqlConnection("Data source = DESKTOP-4Q9IA0V\\PRUEBAS; Initial Catalog = DuFa_express; Integrated Security = True");//
            Connect.Open();
                       
            return Connect;
        } 
    }
}
