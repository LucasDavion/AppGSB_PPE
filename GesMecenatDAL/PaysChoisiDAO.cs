using GesMecenatBO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GesMecenatDAL
{
    public class PaysChoisiDAO
    {
        private static PaysChoisiDAO uneInstance;

        public static PaysChoisiDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PaysChoisiDAO();
            }
            return uneInstance;
        }

        private PaysChoisiDAO()
        {

        }

        public int AjoutPays(PaysChoisiPartenariat unPaysChoisiPartenariat)
        {
            int nbEnregs = 0;

            //connexion à la bdd
            SqlConnection cnx = Connexion.GetObjConnexion();

            //requete
            string sqlr = "insert into paysChoisiPartenariat (idPays,annee) values(@pays, @annee)";

            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            maCommand.CommandText = sqlr;
            maCommand.Parameters.Add("pays", SqlDbType.VarChar);
            maCommand.Parameters[0].Value = unPaysChoisiPartenariat.IdPaysChoisi;
            maCommand.Parameters.Add("annee", SqlDbType.Int);
            maCommand.Parameters[1].Value = unPaysChoisiPartenariat.Annee;

            nbEnregs = maCommand.ExecuteNonQuery();

            //on ferme la connexion
            Connexion.CloseConnexion();

            return nbEnregs;
        }
        public List<PaysChoisiPartenariat> GetPaysChoisi()
        {

            //Declaration des variables de travail
            Pays unPays;
            string libellePays;
            int annee;
            PaysChoisiPartenariat unPaysChoisi;

            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();
            SqlDataReader monLecteur;

            //On cree la collection lesPaysChoisi qui vas contenir toute les caracteristique des paysChoisi enregistrer dans la base de donnée 
            List<PaysChoisiPartenariat> lesPaysChoisi = new List<PaysChoisiPartenariat>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les paysChoisi

            SqlCommand maCommande = new SqlCommand();
            maCommande.Connection = cnx;
            maCommande.CommandType = CommandType.StoredProcedure;
            maCommande.CommandText = "spCnsPaysChoisi";

            //On execute la requette dataReader

            monLecteur = maCommande.ExecuteReader();

            //Pour chaque enregistrement du dateReader on cree les eregistrements 
            while (monLecteur.Read())
            {
                
                annee = (int)monLecteur["annee"];
                libellePays = (string)monLecteur["nom"];

                unPays = new Pays(libellePays);

                unPaysChoisi = new PaysChoisiPartenariat(unPays, annee);
                lesPaysChoisi.Add(unPaysChoisi);
            }
            monLecteur.Close();

            //On ferme la connection
            Connexion.CloseConnexion();

            //On retourne la collection
            return lesPaysChoisi;

        }
    }
}