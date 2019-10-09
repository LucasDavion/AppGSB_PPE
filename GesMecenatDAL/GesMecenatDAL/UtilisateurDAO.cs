using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ref bibliotheque GesMecenatBO
using GesMecenatBO;

namespace GesMecenatDAL
{
    public class UtilisateurDAO
    {
        private static UtilisateurDAO uneInstance;

        //Méthode pour crée un objet de la classe ClientDAO si il n'existe pas sinon on retourne la réf à cet objet

        public static UtilisateurDAO GetInstance()
        {
            if(uneInstance == null)
            {
                uneInstance = new UtilisateurDAO();
            }

            return uneInstance;
        }

        //Constructeur privé par défaut donc impossible de crée un objet à l'ext de cette classe

        private UtilisateurDAO()
        {
        }

        //Méthode pour ajouter un utilisateur dans la BDD

        public int AjoutUtilisateur(Utilisateur unUtilisateur)
        {
        }
    }
}
