using System;
using System.Collections.Generic;
using System.Data.SqlClient; //Ref pour faire les requete SQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ref bibliotheque GesMecenatBO
using GesMecenatBO;

namespace GesMecenatDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO uneInstance;

        //Méthode pour crée un objet de la classe ClientDAO si il n'existe pas sinon on retourne la réf à cet objet

        public static UtilisateurDAO GetInstance()
        {
            if(uneInstance == null)
            {
                uneInstance = new UtilisateurDAO();
            }

            return uneInstance;
        }

        //Constructeur privé par défaut donc impossible de crée un objet à l'ext de cette classe

        private UtilisateurDAO()
        {
        }

        //Méthode qui retourne une list de tout les utilisateurs de la table Utilisateur

        public List<Utilisateur> GetUtilisateurs()
        {

            //Variable

            Utilisateur unUtilisateur;
            Service unService;
            ProfilUtilisateur unProfilUtilisateur;
            string nomUtilisateur;
            string prenomUtilisateur;
            string identifiantUtilisateur;
            string mdpUtilisateur;
            string libelleService;
            string libelleProfilUtilisateur;
            int idProfilUtilisateur;
            int idService;
            int idUtilisateur;

            //List qui sera retourné

            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

            //Récup l'objet de la co à la BD et qu'on va appeler une procédure stockée avec la création de l'objet pour la requete SQL

            SqlConnection cnx = Connexion.GetObjConnexion();
            SqlCommand maCommand = new SqlCommand();
            SqlCommand maCommandService = new SqlCommand();
            SqlCommand maCommandProfilUtilisateur = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandType = System.Data.CommandType.StoredProcedure;

            //Requete SQL

            maCommand.CommandText = "spCnsToutUtilisateurs";

            //Lecture des données retournées dans un datareader

            SqlDataReader monLecteur;
            monLecteur = maCommand.ExecuteReader();

            while(monLecteur.Read())
            {

                //recup donnée utilisateur

                idUtilisateur = (int)monLecteur["id"];
                nomUtilisateur = (string)monLecteur["nom"];
                prenomUtilisateur = (string)monLecteur["prenom"];
                identifiantUtilisateur = (string)monLecteur["identifiant"];
                mdpUtilisateur = (string)monLecteur["mdp"];
                idProfilUtilisateur = (int)monLecteur["id_profilUtilisateur"];
                idService = (int)monLecteur["id_service"];
                libelleService = (string)monLecteur["serviceLibelle"];
                libelleProfilUtilisateur = (string)monLecteur["profilUtilisateurLibelle"];

                //Création de l'objet Service

                unService = new Service(idService, libelleService);

                //Création de l'objet Service

                unProfilUtilisateur = new ProfilUtilisateur(idProfilUtilisateur, libelleProfilUtilisateur);

                //Création de l'objet utilisateur

                unUtilisateur = new Utilisateur(idUtilisateur, nomUtilisateur, prenomUtilisateur, identifiantUtilisateur, mdpUtilisateur,unService, unProfilUtilisateur);

                lesUtilisateurs.Add(unUtilisateur);
            }

            //Fermeture des lecteur et connexion

            monLecteur.Close();
            cnx.Close();

            //Retourne la liste

            return lesUtilisateurs;
        }

        //Méthode pour ajouter un utilisateur dans la BDD

        public int AjoutUtilisateur(Utilisateur unUtilisateur)
        {

            //Compteur

            int nbAjout = 0;

            //Récup l'objet de la co à la BD et qu'on va appeler une procédure stockée avec la création de l'objet pour la requete SQL

            SqlConnection cnx = Connexion.GetObjConnexion();
            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandType = System.Data.CommandType.StoredProcedure;

            //On indique le nom de la procédure stockée à appeler avec les paramètres 

            maCommand.CommandText = "spInsUtilisateur";
            maCommand.Parameters.Add("identifiant", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("prenom", System.Data.SqlDbType.VarChar); 
            maCommand.Parameters.Add("mdp", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("idProfilUtilisateur", System.Data.SqlDbType.Int);
            maCommand.Parameters.Add("idService", System.Data.SqlDbType.Int);
            maCommand.Parameters[0].Value = unUtilisateur.Identifiant;
            maCommand.Parameters[1].Value = unUtilisateur.Nom;
            maCommand.Parameters[2].Value = unUtilisateur.Prenom;
            maCommand.Parameters[3].Value = unUtilisateur.Mdp;
            maCommand.Parameters[4].Value = unUtilisateur.UnProfilUtilisateur.Id;
            maCommand.Parameters[5].Value = unUtilisateur.UnService.Id;

            //Execution de la requete

            maCommand.ExecuteNonQuery();

            //Incrémentation du nombre d'ajout faite

            nbAjout++;

            return nbAjout;
        }

        //Méthode pour select un utilisateur dans la DB en fonction du identifiant et du mdp

        public bool TrouveUnUtilisateur(Utilisateur unUtilisateur)
        {

            //Variable

            bool trouve;

            //Récup l'objet de la co à la BD et qu'on va appeler une procédure stockée avec la création de l'objet pour la requete SQL

            SqlConnection cnx = Connexion.GetObjConnexion();
            SqlCommand maCommand = new SqlCommand();
            maCommand.Connection = cnx;
            maCommand.CommandType = System.Data.CommandType.StoredProcedure;

            //On indique le nom de la procédure stockée à appeler avec les paramètres 

            maCommand.CommandText = "spCnsUtilisateur";
            maCommand.Parameters.Add("identifiant", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("mdp", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[0].Value = unUtilisateur.Identifiant;
            maCommand.Parameters[1].Value = unUtilisateur.Mdp;

            //Execution de la requete

            trouve = Convert.ToBoolean(maCommand.ExecuteScalar());
            
            return trouve;
        }
    }
}
