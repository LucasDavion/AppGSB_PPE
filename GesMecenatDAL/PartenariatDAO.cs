using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using GesMecenatBO;

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
            int id;
            float budgetPrevisionnel;
            float coutReel;
            int idAssociation;
            string libelleAssociation;
            string nomResponsable;
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

            string sqlr = "spselPartenariat";


            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            maCommand.CommandText = sqlr;

            SqlDataReader monLecteur;
            monLecteur = maCommand.ExecuteReader();

            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                budgetPrevisionnel = (float)monLecteur["budget"];
                coutReel = (float)monLecteur["coutReel"];
                idAssociation = (int)monLecteur["id_association"];
                libelleAssociation = (string)monLecteur["libelle"];
                nomResponsable = (string)monLecteur["nomResponsable"];
                idAction = (int)monLecteur["id_action"];

                uneAssoctiation = new Association(libelleAssociation, nomResponsable, idAssociation);

                //uneAction = new Action(idAction, libelleAction);

                //unPartenariat = new Partenariat(id, budgetPrevisionnel, coutReel, uneAssoctiation, uneAction);

                //LesPartenariats.Add(unPartenariat);
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
            string sqlr = "insert into partenariat values(@budget, @coutReel, @idAssociation, @idAction)";

            SqlCommand maCommand = new SqlCommand(sqlr, cnx);
            maCommand.CommandText = sqlr;
            maCommand.Parameters.Add("budget", SqlDbType.Float);
            maCommand.Parameters[0].Value = unPartenariat.Budget;
            maCommand.Parameters.Add("coutReel", SqlDbType.Float);
            maCommand.Parameters[1].Value = unPartenariat.CoutReel;
            maCommand.Parameters.Add("idAssociation", SqlDbType.Int);
            maCommand.Parameters[2].Value = unPartenariat.UneAssociation.Id;
            maCommand.Parameters.Add("idAction", SqlDbType.Int);
            //maCommand.Parameters[3].Value = unPartenariat.Action.Id;
            nbEnregs = maCommand.ExecuteNonQuery();

            //on ferme la connexion
            Connexion.CloseConnexion();

            return nbEnregs;
        }
    }
}

