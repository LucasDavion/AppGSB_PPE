using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GesMecenatBO;

namespace GesMecenatDAL
{
    class PartenariatDAO
    {
        private static PartenariatDAO uneInstance;

        public static PartenariatDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PartenariatDAO();
            }
            return uneInstance;
        }

        private PartenariatDAO()
        {

        }

        public List<Partenariat> GetClients()
        {
            //déclaraion des variables
            int id;
            string budgetPrevisionnel;
            string coutReel;
            int idAssociation;
            int idAction;
            Partenariat unPartenariat;
            Association uneAssoctiation;
            Action uneAction;
            //ouverture de la connexion

            SqlConnection cnx = Connexion.GetObjConnexion();
            //déclaration de la liste LesClients
            List<Client> LesClients = new List<Client>();
            //requete

            string sqlr = "select * from Client join categSocioPro on idCateg=categSocioPro.id";


            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            maCommand.CommandText = sqlr;

            SqlDataReader monLecteur;
            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                nom = (string)monLecteur["nom"];
                prenom = (string)monLecteur["prenom"];
                sexe = (string)monLecteur["sexe"];
                idCateg = (int)monLecteur["idCateg"];
                libelleCateg = (string)monLecteur["libelle"];

                uneCateg = new Categorie(idCateg, libelleCateg);

                unClient = new Client(id, nom, prenom, sexe, uneCateg);

                LesClients.Add(unClient);
            }
            //on ferme le DataReader
            monLecteur.Close();


            //on ferme la connexion
            Connexion.CloseConnexion();

            //on retourne le collection
            return LesClients;



        }
    }
}
