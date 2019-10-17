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

        public int AjoutPays(int sonPays, int sonAnnee, out string erreur)
        {
            erreur = "";
            PaysChoisiPartenariat lepaysChoisiPartenariat;
            int ajoutPays = 0;

            if (sonPays==0)
            {
                erreur += "\nVeuillez selectionner un pays";
            }
            if (sonAnnee==0)
            {
                erreur += "\nVeuillez saisir une année";
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
