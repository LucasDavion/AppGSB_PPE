using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatDAL;
using GesMecenatBO;

namespace GesMecenatBLL
{
    public class PartenariatManager
    {
        private static PartenariatManager uneInstance;

        public static PartenariatManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new PartenariatManager();
            }
            return uneInstance;
        }
        private PartenariatManager()
        {

        }
        public List<Partenariat> GetPartenariat()
        {
            return PartenariatDAO.GetInstance().GetPartenariat();
        }
    }
}
