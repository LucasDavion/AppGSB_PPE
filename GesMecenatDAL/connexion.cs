using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GesMecenatDAL
{
    public class connexion
    {
        static private SqlConnection objConnex;

        static connexion()
        {
            objConnex = new SqlConnection();
            objConnex.ConnectionString = ConfigurationManager.ConnectionStrings["AppGSB_PPE"].ConnectionString;
        }

        public static SqlConnection GetObjConnexion()
        {
            if (objConnex.State == System.Data.ConnectionState.Closed)
            {
                objConnex.Open();
            }
            return objConnex;
        }

        public static void CloseConnexion()
        {
            if (objConnex != null && objConnex.State != System.Data.ConnectionState.Closed)
            {
                objConnex.Close();
            }

        }
    }
}
