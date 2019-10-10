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
        private string nomResponsable;
        private int id;
        

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

        public string NomAssociation { get => nomAssociation; set => nomAssociation = value; }
        public string NomResponsable { get => nomResponsable; set => nomResponsable = value; }
        public int Id { get => id; set => id = value; }
    }
}
