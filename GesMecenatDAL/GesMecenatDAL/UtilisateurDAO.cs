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
            string nomUtilisateur;
            string prenomUtilisateur;
            string identifiantUtilisateur;
            string mdpUtilisateur;

            //List qui sera retourné

            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();

            //Objet de co à la BD

            SqlConnection cnx = Connexion.GetObjConnexion();

            //Requete SQL

            string strSQL = "Select nom, prenom, identifiant, mdp From Utilisateur";
            SqlCommand maCommand = new SqlCommand(strSQL, cnx);
            maCommand.CommandText = strSQL;

            //Lecture des données retournées dans un datareader

            SqlDataReader monLecteur;
            monLecteur = maCommand.ExecuteReader();

            while(monLecteur.Read())
            {

                //recup donnée utilisateur

                nomUtilisateur = (string)monLecteur["nom"];
                prenomUtilisateur = (string)monLecteur["prenom"];
                identifiantUtilisateur = (string)monLecteur["identifiant"];
                mdpUtilisateur = (string)monLecteur["mdp"];

                //Création de l'objet utilisateur

                //unUtilisateur = new Utilisateur(nomUtilisateur, prenomUtilisateur, identifiantUtilisateur, mdpUtilisateur);

                //lesUtilisateurs.Add(unUtilisateur);
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

            //Récup l'objet de la co à la BD

            SqlConnection cnx = Connexion.GetObjConnexion();

            //Crée l'objet qui va contenir la requete SQL

            string strSQL = "insert into Utilisateur(nom, prenom, identifiant, mdp) values(@nom, @prenom, @identifiant, @mdp)";
            SqlCommand maCommand = new SqlCommand(strSQL, cnx);
            maCommand.Parameters.Add("nom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("prenom", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("identifiant", System.Data.SqlDbType.VarChar);
            maCommand.Parameters.Add("mdp", System.Data.SqlDbType.VarChar);
            maCommand.Parameters[0].Value = unUtilisateur.Nom;
            maCommand.Parameters[1].Value = unUtilisateur.Prenom;
            maCommand.Parameters[2].Value = unUtilisateur.Identifiant;
            maCommand.Parameters[3].Value = unUtilisateur.Mdp;
            maCommand.CommandText = strSQL;
            nbAjout++;

            return nbAjout;
        }
    }
}
