using System;
using System.Collections.Generic;
using System.Data.SqlClient; //Ref SQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ref à la BO
using GesMecenatBO;

namespace GesMecenatDAL
{
    public class ServiceDAO
    {
        private static ServiceDAO uneInstance;

        //Méthode pour crée un objet de la classe ClientDAO si il n'existe pas sinon on retourne la réf à cet objet

        public static ServiceDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ServiceDAO();
            }

            return uneInstance;
        }

        //Constructeur privé par défaut donc impossible de crée un objet à l'ext de cette classe

        private ServiceDAO()
        {
        }


        //Méthode qui retourne une list de tout les utilisateurs de la table Utilisateur

        public List<Service> GetServices()
        {

            //Variable

            Service unService;
            string libelleService;
            int idService;

            //List qui sera retourné

            List<Service> lesServices = new List<Service>();

            //Objet de co à la BD

            SqlConnection cnx = Connexion.GetObjConnexion();

            //Requete SQL

            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //On indique le nom de la procédure stockée à appeler
            maCommand.CommandText = "spCnsService";

            //Lecture des données retournées dans un datareader

            SqlDataReader monLecteur;
            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {

                //recup donnée utilisateur

                idService = (int)monLecteur["id"];
                libelleService = (string)monLecteur["libelle"];

                //Création de l'objet utilisateur

                unService = new Service(idService,libelleService);

                lesServices.Add(unService);
            }

            //Fermeture des lecteur et connexion

            monLecteur.Close();
            cnx.Close();

            //Retourne la liste

            return lesServices;
        }
    }
}
