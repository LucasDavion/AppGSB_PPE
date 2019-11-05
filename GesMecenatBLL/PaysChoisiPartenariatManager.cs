using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatBO;
using GesMecenatDAL;


namespace GesMecenatBLL
{
    public class PaysChoisiPartenariatManager
    {
        private static PaysChoisiPartenariatManager uneInstance;

        public static PaysChoisiPartenariatManager GetInstance()
        {
            if(uneInstance == null)
            {
                uneInstance = new PaysChoisiPartenariatManager();
            }
            return uneInstance;
        }
        private PaysChoisiPartenariatManager()
        {

        }
        public List<PaysChoisiPartenariat> GetPays()
        {
            return PaysChoisiDAO.GetInstance().GetPaysChoisi();
        }

        public int AjoutPays(int sonPays, string lAnnee, out string erreur)
        {
            int uneDate = System.DateTime.Now.Year;
            erreur = "";
            PaysChoisiPartenariat lepaysChoisiPartenariat;
            int ajoutPays = 0;
            int sonAnnee;
            int.TryParse(lAnnee, out sonAnnee);

            if (sonPays==0)
            {
                erreur += "\nVeuillez selectionner un pays";
            }
            if (sonAnnee<uneDate || sonAnnee>3000)
            {
                erreur += "\nVeuillez saisir une année à jour";
            }
            if (erreur =="")
            {
                lepaysChoisiPartenariat = new PaysChoisiPartenariat(sonPays, sonAnnee);

                try
                {
                    ajoutPays = PaysChoisiDAO.GetInstance().AjoutPays(lepaysChoisiPartenariat);
                }
                catch(Exception err)
                {
                    erreur = "Erreur lors de l'ajout de pays" + err.Message;
                }
            }
            return ajoutPays;

        }
    }
}
