using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class Partenariat
    {
        private int id;
        private float budget;
        private float coutReel;
        private Association uneAssociation;

        public Partenariat(int id, float budget, float coutReel, Association uneAssociation)
        {
            this.id = id;
            this.budget = budget;
            this.coutReel = coutReel;
            this.uneAssociation = uneAssociation;
        }

        public int Id { get => id; set => id = value; }
        public float Budget { get => budget; set => budget = value; }
        public float CoutReel { get => coutReel; set => coutReel = value; }
        public Association UneAssociation { get => uneAssociation; set => uneAssociation = value; }
    }
}
