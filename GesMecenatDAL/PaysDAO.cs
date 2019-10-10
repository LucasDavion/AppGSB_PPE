using GesMecenatBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatDAL
{
    class PaysDAO
    {
        public List<Pays> GetPays()
        {
            //Declaration des variables de travail
            int id;
            string libelle;
            Pays unPays;

            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //On cree la collection lesPays qui vas contenir toute les caracteristique des cleints enregistrer dans la base de donnée 
            List<Pays> lesPays = new List<Pays>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les caracteristiques de tous les client 
            string sql;
            sql = "select * from pays";
            SqlCommand maCommande = new SqlCommand(sql, cnx);
            maCommande.CommandText = sql;

            //On execute la requette dataReader
            SqlDataReader monLecteur;
            monLecteur = maCommande.ExecuteReader();

            //Pour chaque enregistrement du dateReader on cree les eregistrements 
            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                libelle = (string)monLecteur["nom_fr_fr"];

                unPays = new Pays(id, libelle);
                lesPays.Add(unPays);
            }
            monLecteur.Close();

            //On ferme la connection
            Connexion.CloseConnexion();

            //On retourne la collection
            return lesPays;

        }
    }
}
