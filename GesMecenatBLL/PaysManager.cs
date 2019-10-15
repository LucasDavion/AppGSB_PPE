using GesMecenatBO;
using GesMecenatDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBLL
{
    public class PaysManager
    {
        private static PaysManager uneInstance;

        //Méthode pour crée la classe PaysManager s'il n'en existe pas on en crée un puis retourne la ref à l'objet

        public static PaysManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PaysManager();
            }
            return uneInstance;
        }

        //Constructeur par défaut privée

        private PaysManager()
        {
        }

        //Appel de la couche DAL pour récupérer une liste de pays

        public List<Pays> GetPays()
        {
            return PaysDAO.GetInstance().GetPays();
        }

       

    }
}
