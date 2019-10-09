using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ref aux bibliothèque des classe DAL et BO
using GesMecenatBO;
using GesMecenatDAL;

namespace GesMecenatBLL
{
    public class UtilisateurManager
    {
        private static UtilisateurManager uneInstance;

        //Méthode pour crée un objet de la classe ClientDAO si il n'existe pas sinon on retourne la réf à cet objet

        public static UtilisateurManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new UtilisateurManager();
            }

            return uneInstance;
        }

        //Constructeur privé par défaut donc impossible de crée un objet à l'ext de cette classe

        private UtilisateurManager()
        {
        }

        //Appel couche DAL pour crée l'utilisateur

        public int CreerUtilisateur(string sonNom, string sonPrenom)
        {
            string identification;
            string mdp;
            Utilisateur unUtilisateur;
            unUtilisateur = unUtilisateur(sonNom, sonPrenom, identification, mdp);
        }
    }
}
