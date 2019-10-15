using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ref à la DAL et à la BO
using GesMecenatBO;
using GesMecenatDAL;

namespace GesMecenatBLL
{
    public class ProfilUtilisateurManager
    {

        private static ProfilUtilisateurManager uneInstance;

        //Méthode pour crée un objet de la classe ProfilUtilisateurManageur si il n'existe pas sinon on retourne la réf à cet objet

        public static ProfilUtilisateurManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new ProfilUtilisateurManager();
            }

            return uneInstance;
        }

        //Constructeur privé par défaut donc impossible de crée un objet à l'ext de cette classe

        private ProfilUtilisateurManager()
        {
        }

        //Méthode pour recup les profilUtilisateurs

        public List<ProfilUtilisateur> GetProfilUtilisateurs()
        {
            return ProfilUtilisateurDAO.GetInstance().GetProfilUtilisateur();
        }
    }
}
