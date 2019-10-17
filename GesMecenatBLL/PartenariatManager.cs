using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatDAL;
using GesMecenatBO;
using System.Data.SqlClient;
using Action = GesMecenatBO.Action;

namespace GesMecenatBLL
{
    public class PartenariatManager
    {
        //Creation d'une instance
        private static PartenariatManager uneInstance;

        public static PartenariatManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PartenariatManager();
            }
            return uneInstance;
        }
        //Constructeur de PartenariatManager
        private PartenariatManager()
        {

        }
        //Récupère la collection des partenariats
        public List<Partenariat> GetPartenariat()
        {
            return PartenariatDAO.GetInstance().GetPartenariat();
        }
        //Création des objet pour AjoutPartenariats à l'aide des parmètres
        public int CreerPartenariat(float sonBudget, int sonIdAssociation, int sonIdAction, out string msgerr)
        {
            //Déclaration des variables
            int nbAjout = 0;
            msgerr = "";
            //Création des objets
            Partenariat unPartenariat;
            Association uneAssocation = new Association(sonIdAssociation);
            Action uneAction = new Action(sonIdAction);
            unPartenariat = new Partenariat(sonBudget, uneAssocation, uneAction);
            try
            {
                //Ajout de l'objet unPartenariat dans la méthode AjoutPartenariat
                nbAjout = PartenariatDAO.GetInstance().AjoutPartenariat(unPartenariat);
            }
            //On teste les exception
            catch (SqlException err)
            {
                msgerr = "ERREUR requête SQL : " + err.Message;
            }
            catch (Exception err)
            {
                msgerr = "ERREUR GRAVE : " + err.Message;
            }
            //Retourne le nombre d'enregistrement
            return nbAjout;
        }
    }
}
