using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatBO;
using Action = GesMecenatBO.Action;

namespace GesMecenatDAL
{
    public class ActionDAO
    {
        private static ActionDAO uneInstance;

        public static ActionDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ActionDAO();
            }
            return uneInstance;
        }
        public List<Action> GetActions()
        {

            //Declaration des variables de travail
            int id;
            string libelle;
            Action uneAction;

            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //On cree la collection lesClients qui vas contenir toute les caracteristique des cleints enregistrer dans la base de donnée 
            List<Action> lesActions = new List<Action>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les caracteristiques de tous les client 
            string sql;
            sql = "spCnsAcion";
            SqlCommand maCommande = new SqlCommand(sql, cnx);
            maCommande.CommandText = sql;

            //On execute la requette dataReader
            SqlDataReader monLecteur;
            monLecteur = maCommande.ExecuteReader();

            //Pour chaque enregistrement du dateReader on cree les eregistrements 
            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                libelle = (string)monLecteur["libelle"];

                uneAction = new Action(id, libelle);
                lesActions.Add(uneAction);
            }
            monLecteur.Close();

            //On ferme la connection
            Connexion.CloseConnexion();


            //On retourne la collection
            return lesActions;
        }

        public List<Action> CreaAction(Action nouvAction)
        {

            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //On cree la collection lesActions qui vas contenir toute les caracteristique des Actions enregistrer dans la base de donnée 
            List<Action> lesActions = new List<Action>();

            string sql;
            sql = "spInsAction";

            //on récupèe l'objet responsable de la connexion à la base
            SqlCommand maCommande;
            maCommande = new SqlCommand();
            maCommande.Parameters.Clear();
            maCommande.Connection = Connexion.GetObjConnexion();

            //on crée l'objet qui va contenir la requête SQL d'insert qui sera exécutée*
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.CommandText = sql;


            maCommande.Parameters.Add("nomAction", SqlDbType.VarChar);
            maCommande.Parameters[0].Value = nouvAction.Libelle;
            
            maCommande.ExecuteNonQuery();

            
            //On ferme la connection
            Connexion.CloseConnexion();


            //On retourne la collection
            return lesActions;
        }
    }
}
