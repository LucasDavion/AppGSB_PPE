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
            
            Mission uneMission = new Mission(mission);

            
            try
            {
                nbAjout = MissionDAO.GetInstance().AjoutMission(uneMission);
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
