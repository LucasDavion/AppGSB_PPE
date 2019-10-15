using GesMecenatBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatBLL;
using GesMecenatDAL;
using System.Data.SqlClient;

namespace GesMecenatBLL
{
    public class AssociationManager
    {

        private static AssociationManager uneInstance;

        public static AssociationManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AssociationManager();
            }
            return uneInstance;
        }
        private AssociationManager()
        {

        }
        public List<Association> GetAssociations()
        {
            return AssociationManager.GetInstance().GetAssociations();
        }
        public int CreerAssociation(string association, out string msgerr)
        {
            int nbAjout = 0;
            msgerr = "";

            Association uneAssociation = new Association(association);


            try
            {
                nbAjout = AssociationDAO.GetInstance().AjoutAssociation(uneAssociation);
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
