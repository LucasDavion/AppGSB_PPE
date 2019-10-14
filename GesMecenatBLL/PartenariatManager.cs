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
        private static PartenariatManager uneInstance;

        public static PartenariatManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PartenariatManager();
            }
            return uneInstance;
        }
        private PartenariatManager()
        {

        }
        public List<Partenariat> GetPartenariat()
        {
            return PartenariatDAO.GetInstance().GetPartenariat();
        }
        public int CreerPartenariat(float sonBudget, int sonIdAssociation, int sonIdAction, out string msgerr)
        {
            int nbAjout = 0;
            msgerr = "";
            Partenariat unPartenariat;
            Association uneAssocation = new Association(sonIdAssociation);
            Action uneAction = new Action(sonIdAction);
            unPartenariat = new Partenariat(sonBudget, uneAssocation, uneAction);
            try
            {
                nbAjout = PartenariatDAO.GetInstance().AjoutPartenariat(unPartenariat);
            }
            catch (SqlException err)
            {
                msgerr = "ERREUR requête SQL : " + err.Message;
            }
            catch (Exception err)
            {
                msgerr = "ERREUR GRAVE : " + err.Message;
            }
            return nbAjout;
        }
    }
}
