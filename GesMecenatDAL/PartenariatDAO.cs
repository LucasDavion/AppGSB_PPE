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

        public List<Partenariat> GetPartenariat()
        {
            //déclaraion des variables
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
            //ouverture de la connexion

            SqlConnection cnx = Connexion.GetObjConnexion();
            //déclaration de la liste LesClients
            List<Partenariat> LesPartenariats = new List<Partenariat>();
            //requete

            string sqlr = "spCnsPartenariat";


            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = sqlr;

            SqlDataReader monLecteur;
            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                idPartenariat = (int)monLecteur["idPartenariat"];
                budgetPrevisionnel = (float)(double)monLecteur["budget"];
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

                uneAssoctiation = new Association(idAssociation, libelleAssoaction);

                uneAction = new Action(idAction, libelleAction);

                unPartenariat = new Partenariat(idPartenariat, budgetPrevisionnel, coutReel, uneAssoctiation, uneAction);

                LesPartenariats.Add(unPartenariat);
            }
            //on ferme le DataReader
            monLecteur.Close();


            //on ferme la connexion
            Connexion.CloseConnexion();

            //on retourne le collection
            return LesPartenariats;
        }
        public int AjoutPartenariat(Partenariat unPartenariat)
        {
            int nbEnregs = 0;

            //connexion à la bdd
            SqlConnection cnx = Connexion.GetObjConnexion();

            //requete
            string sqlr = "spInsPartenariat";

            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            maCommand.CommandType = CommandType.StoredProcedure;
            maCommand.CommandText = sqlr;
            maCommand.Parameters.Add("budget", SqlDbType.Float);
            maCommand.Parameters[0].Value = unPartenariat.Budget;
            maCommand.Parameters.Add("idAssociation", SqlDbType.Int);
            maCommand.Parameters[1].Value = unPartenariat.UneAssociation.Id;
            maCommand.Parameters.Add("idAction", SqlDbType.Int);
            maCommand.Parameters[2].Value = unPartenariat.UneAction.Id;
            nbEnregs = maCommand.ExecuteNonQuery();

            //on ferme la connexion
            Connexion.CloseConnexion();

            return nbEnregs;
        }
    }
}

