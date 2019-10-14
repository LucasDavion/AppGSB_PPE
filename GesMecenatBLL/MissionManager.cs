using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatBLL;
using GesMecenatBO;
using GesMecenatDAL;


namespace GesMecenatBLL
{
    public class MissionManager
    {
        private static MissionManager uneInstance;

        public static MissionManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new MissionManager();
            }
            return uneInstance;
        }
        private MissionManager()
        {

        }
        public List<Mission> GetMission()
        {
            return MissionManager.GetInstance().GetMission();
        }
        public int CreerMission(string mission, out string msgerr)
        {
            int nbAjout = 0;
            msgerr = "";
            Mission unPartenariat;
            Mission uneMission = new Mission(mission);
            //Action uneAction = new Action();
            //unPartenariat = new Partenariat(sonBudget, sonCoutReel, uneAssocation, uneAction);
            try
            {
                //nbAjout = PartenariatDAO.GetInstance().AjoutPartenariat(unPartenariat);
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
