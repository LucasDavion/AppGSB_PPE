using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class Association
    {
        private string nomAssociation;
        private string mission;
        private int id;

        public Association(string nomAssociation, string mission, int id)
        {
            this.nomAssociation = nomAssociation;
            this.mission = mission;
            this.id = id;
        }

        public string NomAssociation { get => nomAssociation; set => nomAssociation = value; }
        public string Mission { get => mission; set => mission = value; }
        public int Id { get => id; set => id = value; }
    }
}
