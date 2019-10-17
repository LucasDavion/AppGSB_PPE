using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GesMecenatBO;
using Action = GesMecenatBO.Action;

namespace GesMecenatDAL
{
    public class PartenariatDAO
    {
        //Creation d'une instance
        private static PartenariatDAO uneInstance;

        public static PartenariatDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PartenariatDAO();
            }
            return uneInstance;
        }

        //Constructeur de PartenariatDAO
        private PartenariatDAO()
        {

        }

        public List<Partenariat> GetPartenariats()
        {
            //Déclaraion des variables
            int idPartenariat;
            float budgetPrevisionnel;
            float coutReel;
            int idAssociation;
            string libelleAssoaction;
            int idAction;
            string libelleAction;
            Partenariat unPartenariat;
            Association uneAssoctiation;
            Action uneAction;
            //Ouverture de la connexion

            SqlConnection cnx = Connexion.GetObjConnexion();
            //Déclaration de la liste lesPartenariats
            List<Partenariat> lesPartenariats = new List<Partenariat>();
            
            //Requête
            string sqlr = "spCnsPartenariat";

            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            //Procédure
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = sqlr;
            //Déclaration du lecteur
            SqlDataReader monLecteur;
            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                //Récuperation des enregistrements récuperés dans la BDD
                idPartenariat = (int)monLecteur["idPartenariat"];
                budgetPrevisionnel = (float)(double)monLecteur["budget"];
                //Si le cout réel n'a pas encore été enregistré
                if (monLecteur["coutReel"]== DBNull.Value)
                {
                    coutReel = 0;
                }
                else
                {
                    coutReel = (float)(double)monLecteur["coutReel"];
                }
                idAssociation = (int)monLecteur["id_association"];
                libelleAssoaction = (string)monLecteur["libelleAssociation"];
                libelleAction = (string)monLecteur["libelleAction"];
                idAction = (int)monLecteur["id_action"];
                //Création d'un objet Association
                uneAssoctiation = new Association(idAssociation, libelleAssoaction);
                //Création d'un objet Action
                uneAction = new Action(idAction, libelleAction);
                //Création d'un objet Partenariat
                unPartenariat = new Partenariat(idPartenariat, budgetPrevisionnel, coutReel, uneAssoctiation, uneAction);
                //Ajout de l'objet unPartenariat dans la collection lesPartenariats
                lesPartenariats.Add(unPartenariat);
            }
            //On ferme le Lecteur
            monLecteur.Close();


            //On ferme la connexion
            Connexion.CloseConnexion();

            //On retourne le collection
            return lesPartenariats;
        }
        public int AjoutPartenariat(Partenariat unPartenariat)
        {
            //Déclaration d'une variable pour récuperer le nombre d'enregistrement
            int nbEnregs = 0;

            //Connexion à la bdd
            SqlConnection cnx = Connexion.GetObjConnexion();

            //Requête
            string sqlr = "spInsPartenariat";

            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            //Procédure
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = sqlr;
            //Paramètres de la requête
            maCommand.Parameters.Add("budget", SqlDbType.Float);
            maCommand.Parameters[0].Value = unPartenariat.Budget;
            maCommand.Parameters.Add("idAssociation", SqlDbType.Int);
            maCommand.Parameters[1].Value = unPartenariat.UneAssociation.Id;
            maCommand.Parameters.Add("idAction", SqlDbType.Int);
            maCommand.Parameters[2].Value = unPartenariat.UneAction.Id;
            nbEnregs = maCommand.ExecuteNonQuery();

            //On ferme la connexion
            Connexion.CloseConnexion();

            //Retourne le nombre d'enregistrement
            return nbEnregs;
        }
    }
}

