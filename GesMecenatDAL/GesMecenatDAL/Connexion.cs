using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient; //Pour utilisé SQLserver
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatDAL
{
    static public class Connexion
    {
        static private SqlConnection objConnection;

        //Le constructeur statique crée un objet instance de la classe SqlConnection

        static Connexion()
        {
            objConnection = new SqlConnection();
            objConnection.ConnectionString = ConfigurationManager.ConnectionStrings["AppGSB_PPE"].ConnectionString;
        }

        //Méthode GetObjConnexion fournit l'objet instance de la classe SqlConnection dans un état ouvert

        public static SqlConnection GetObjConnexion()
        {

            //Ouvre si co fermée

            if(objConnection.State == System.Data.ConnectionState.Closed)
            {
                objConnection.Open();
            }

            //On retourne l'objet responsable de la connexion

            return objConnection;
        }

        //Méthode CloseConnexion met l'objet instance de la classe SqlConnection dans un état "connexion fermé"

        public static void CloseConnexion()
        {

            //Si la connexion est ouverte on la ferme

            if(objConnection != null && objConnection.State != System.Data.ConnectionState.Closed)
            {
                objConnection.Close();
            }
        }
    }
}
