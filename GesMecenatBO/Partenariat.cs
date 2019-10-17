using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class Partenariat
    {
        //Déclaration des variables
        private int id;
        private float budget;
        private float coutReel;
        private Association uneAssociation;
        private Action uneAction;

        //Constructeurs
        public Partenariat(float coutReel)
        {
            this.coutReel = coutReel;
        }

        public Partenariat(float budget, Association uneAssociation, Action uneAction)
        {
            this.budget = budget;
            this.uneAssociation = uneAssociation;
            this.uneAction = uneAction;
        }

        public Partenariat(int id, float budget, float coutReel, Association uneAssociation, Action uneAction)
        {
            this.id = id;
            this.budget = budget;
            this.coutReel = coutReel;
            this.uneAssociation = uneAssociation;
            this.uneAction = uneAction;
        }

        //Getter et Setter
        public int Id { get => id; set => id = value; }
        public float Budget { get => budget; set => budget = value; }
        public float CoutReel { get => coutReel; set => coutReel = value; }
        public Association UneAssociation { get => uneAssociation; set => uneAssociation = value; }
        public Action UneAction { get => uneAction; set => uneAction = value; }
        public string LibelleAssociation { get => uneAssociation.NomAssociation; }
        public string LibelleAction { get => uneAction.Libelle; }
    }
}
