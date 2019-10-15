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
        private string nomMission;
        private string pays;

   
        private string association;

        public Association(int id)
        {
            this.id = id;
        }

        public Association(string association)
        {
            this.association = association;
        }

        public Association(string nomAssociation, string nomResponsable)
        {
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
        }

        public Association(string nomAssociation, string nomResponsable, int id)
        {
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
            this.id = id;
        }

        public Association(int id, string nomAssociation, string nomResponsable, string nomMission, string pays)
        {
            this.id = id;
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
            this.nomMission = nomMission;
            this.pays = pays;
        }

        public string NomAssociation { get => nomAssociation; set => nomAssociation = value; }
        public string NomResponsable { get => nomResponsable; set => nomResponsable = value; }
        public int Id { get => id; set => id = value; }
    }
}
