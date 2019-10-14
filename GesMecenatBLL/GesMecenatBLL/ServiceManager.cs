using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBLL
{
    public class ServiceManager
    {

        private static ServiceManager uneInstance;

        //Méthode pour crée un objet de la classe ClientDAO si il n'existe pas sinon on retourne la réf à cet objet

        public static ServiceManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ServiceManager();
            }

            return uneInstance;

        }

        //Constructeur privé par défaut donc impossible de crée un objet à l'ext de cette classe

        private ServiceManager()
        {
        }
    }
}
