using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class Association
    {
        
        private int id;
        private string nomAssociation;
        private string nomResponsable;
        private int mission;
        private int pays;

        public Association(int id)
        {
            this.id = id;
        }

        public Association(int id, string nomAssociation)
        {
            this.id = id;
            this.nomAssociation = nomAssociation;
        }

        public Association(string nomAssociation, string nomResponsable, int mission, int pays)
        {
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
            this.mission = mission;
            this.pays = pays;
        }

        public Association(int id, string nomAssociation, string nomResponsable, int mission, int pays)
        {
            this.id = id;
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
            this.mission = mission;
            this.pays = pays;
        }

        public string NomAssociation { get => nomAssociation; set => nomAssociation = value; }
        public string NomResponsable { get => nomResponsable; set => nomResponsable = value; }
        public int Mission1 { get => mission; set => mission = value; }
        public int Pays { get => pays; set => pays = value; }
    }
}
