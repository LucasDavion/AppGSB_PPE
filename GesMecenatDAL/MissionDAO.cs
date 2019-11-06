using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatBO;

namespace GesMecenatDAL
{
    public class MissionDAO
    {
        private static MissionDAO uneInstance;

        public static MissionDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new MissionDAO();
            }
            return uneInstance;
        }

        private MissionDAO()
        {
        }

        public List<Mission> GetMission()
        {

            //Declaration des variables de travail
            int id;
            string libelle;
            
            Mission uneMission;

            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //On cree la collection lesMissions qui vas contenir toute les caracteristique des missions enregistrer dans la base de donnée 
            List<Mission> lesMissions = new List<Mission>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les caracteristiques de toutes les missions 
            string sql;
            sql = "spCnsMission";
            SqlCommand maCommande = new SqlCommand(sql, cnx);
            
            maCommande.CommandText = sql;
            maCommande.CommandType = CommandType.StoredProcedure;
            //On execute la requette dataReader
            SqlDataReader monLecteur;
            monLecteur = maCommande.ExecuteReader();

            //Pour chaque enregistrement du dateReader on cree les eregistrements 
            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                libelle = (string)monLecteur["libelle"];


                uneMission = new Mission(id, libelle);
                lesMissions.Add(uneMission);
            }
            monLecteur.Close();

            //On ferme la connection
            Connexion.CloseConnexion();


            //On retourne la collection
            return lesMissions;
        }


        //La methode AjouteMission ajoute une mission a la base de donnée
        public int AjoutMission(Mission uneMission)
        {
            int nbEnreg = 0;


            string sql;
            string msgErr = "";
            try
            {
                //On recupere l'objet responsable de la connection a la base
                SqlConnection cnx = Connexion.GetObjConnexion();

                //recuperation des données
                sql = "spInsMission";
                SqlCommand maCommande = new SqlCommand(sql, cnx);
                maCommande.CommandType = CommandType.StoredProcedure;
                maCommande.Parameters.Add("libelle", SqlDbType.VarChar);
                maCommande.Parameters[0].Value = uneMission.Libelle;

                maCommande.CommandText = sql;
                nbEnreg = maCommande.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                msgErr += "Erreur requete SQL " + err.Message;
            }
            catch (Exception err)
            {
                msgErr += "Erreur grave " + err.Message;
            }

            Connexion.CloseConnexion();
            return nbEnreg;
        }
    }
}
