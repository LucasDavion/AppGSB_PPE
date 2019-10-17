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
    public class AssociationDAO
    {

        private static AssociationDAO uneInstance;

        public static AssociationDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AssociationDAO();
            }
            return uneInstance;
        }

        private AssociationDAO()
        {

        }
        public List<Association> GetAssociation()
        {

            //Declaration des variables de travail
            int id;
            string nom;
            string mission;
            string pays;
            string libelle;
            Association uneAssociation;
            Mission uneMission;
            Pays unPays;

            
            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //On cree la collection lesClients qui vas contenir toute les caracteristique des cleints enregistrer dans la base de donnée 
            List<Association> lesAssos = new List<Association>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les caracteristiques de tous les client 
            string sql;
            sql = "spCnsAssociation";
            SqlCommand maCommande = new SqlCommand(sql, cnx);
            maCommande.CommandText = sql;

            //On execute la requette dataReader
            SqlDataReader monLecteur;
            monLecteur = maCommande.ExecuteReader();

            //Pour chaque enregistrement du dateReader on cree les eregistrements 
            while (monLecteur.Read())
            {
                id = (int)monLecteur["idAssociation"];
                libelle = (string)monLecteur["libelleAssociation"];
                nom = (string)monLecteur["nomResponsable"];

                int idMission = (int)monLecteur["idPays"];
                mission = (string)monLecteur["libelleMission"];

                int idPays = (int)monLecteur["idMission"];
                pays = (string)monLecteur["nomPaysFr"];

                uneAssociation = new Association(id, libelle, nom);
                uneMission = new Mission(idMission, mission);
                unPays = new Pays(idPays, pays);
                lesAssos.Add(uneAssociation);
            }
            monLecteur.Close();

            //On ferme la connection
            Connexion.CloseConnexion();


            //On retourne la collection
            return lesAssos;
        }


        //La methode ajoutClient ajoute un client a la base de donnée
        public int AjoutAssociation(Association uneAssociation)
        {
            int nbEnreg = 0;


            string sql;
            string msgErr = "";
            try
            {
                //On recupere l'objet responsable de la connection a la base
                SqlConnection cnx = Connexion.GetObjConnexion();
                sql = "spInsAssociation";
                SqlCommand maCommande = new SqlCommand(sql, cnx);

                maCommande.Parameters.Add("libelle", SqlDbType.VarChar);
                maCommande.Parameters[0].Value = uneAssociation.NomAssociation;
                maCommande.Parameters.Add("nomRespon", SqlDbType.VarChar);
                maCommande.Parameters[1].Value = uneAssociation.NomResponsable;
                maCommande.Parameters.Add("idMission", SqlDbType.Int);
                maCommande.Parameters[2].Value = uneAssociation.UneMission.Id;
                maCommande.Parameters.Add("idPays", SqlDbType.Int);
                maCommande.Parameters[3].Value = uneAssociation.UnPays.Id;

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
