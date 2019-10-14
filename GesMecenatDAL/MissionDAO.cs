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
    class MissionDAO
    {
        public List<Mission> GetMission()
        {

            //Declaration des variables de travail
            int id;
            string libelle;
            //string mission;
            Mission uneMission;

            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //On cree la collection lesClients qui vas contenir toute les caracteristique des cleints enregistrer dans la base de donnée 
            List<Mission> lesMissions = new List<Mission>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les caracteristiques de tous les client 
            string sql;
            sql = "";
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


                uneMission = new Mission(id, libelle);
                lesMissions.Add(uneMission);
            }
            monLecteur.Close();

            //On ferme la connection
            Connexion.CloseConnexion();


            //On retourne la collection
            return lesMissions;
        }


        //La methode ajoutClient ajoute un client a la base de donnée
        public int AjoutMission(Mission uneMission)
        {
            int nbEnreg = 0;


            string sql;
            string msgErr = "";
            try
            {
                //On recupere l'objet responsable de la connection a la base
                SqlConnection cnx = Connexion.GetObjConnexion();
                sql = "insert into mission (libelle) values(@libelle)";
                SqlCommand maCommande = new SqlCommand(sql, cnx);

                maCommande.Parameters.Add("libelle", SqlDbType.VarChar);
                maCommande.Parameters[1].Value = uneMission.Libelle;

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
