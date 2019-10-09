using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    class Partenariat
    {
        private int id;
        private float budget;
        private float coutReel;

        public Partenariat(int id, float budget, float coutReel)
        {
            this.id = id;
            this.budget = budget;
            this.coutReel = coutReel;
        }

        public int Id { get => id; set => id = value; }
        public float Budget { get => budget; set => budget = value; }
        public float CoutReel { get => coutReel; set => coutReel = value; }
    }
}
