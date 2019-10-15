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

    }
}
