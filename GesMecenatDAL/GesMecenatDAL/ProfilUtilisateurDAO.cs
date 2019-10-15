using System;
using System.Collections.Generic;
using System.Data.SqlClient; //Ref commandeSQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ref à la BO
using GesMecenatBO;

namespace GesMecenatDAL
{
    public class ProfilUtilisateurDAO
    {
        private static ProfilUtilisateurDAO uneInstance;

        //Méthode pour crée un objet de la classe ProfilUtilisateurDAO si il n'existe pas sinon on retourne la réf à cet objet

        public static ProfilUtilisateurDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ProfilUtilisateurDAO();
            }

            return uneInstance;
        }

        //Constructeur privé par défaut donc impossible de crée un objet à l'ext de cette classe

        private ProfilUtilisateurDAO()
        {
        }

        //Méthode qui retourne une list de tout les utilisateurs de la table Utilisateur

        public List<ProfilUtilisateur> GetProfilUtilisateur()
        {

            //Variable

            ProfilUtilisateur unProfilUtilisateur;
            string libelleProfilUtilisateur;
            int idProfilUtilisateur;

            //List qui sera retourné

            List<ProfilUtilisateur> lesProfilsUtilisateurs = new List<ProfilUtilisateur>();

            //Objet de co à la BD

            SqlConnection cnx = Connexion.GetObjConnexion();

            //Requete SQL

            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //On indique le nom de la procédure stockée à appeler
            maCommand.CommandText = "spCnsProfilUtilisateur";

            //Lecture des données retournées dans un datareader

            SqlDataReader monLecteur;
            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {

                //recup donnée utilisateur

                idProfilUtilisateur = (int)monLecteur["id"];
                libelleProfilUtilisateur = (string)monLecteur["libelle"];

                //Création de l'objet utilisateur

                unProfilUtilisateur = new ProfilUtilisateur(idProfilUtilisateur,libelleProfilUtilisateur);

                lesProfilsUtilisateurs.Add(unProfilUtilisateur);
            }

            //Fermeture des lecteur et connexion

            monLecteur.Close();
            cnx.Close();

            //Retourne la liste

            return lesProfilsUtilisateurs;
        }
    }
}
