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
        private Mission uneMission;
        private Pays unPays;

        public Association(int id)
        {
            this.id = id;
        }

        public Association(int id, string nomAssociation)
        {
            this.id = id;
            this.nomAssociation = nomAssociation;
        }

        public Association(int id, string nomAssociation, string nomResponsable)
        {
            this.id = id;
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
        }

        public Association(string nomAssociation, string nomResponsable, Mission uneMission, Pays unPays)
        {
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
            this.uneMission = uneMission;
            this.unPays = unPays;
        }

        public Association(int id, string nomAssociation, string nomResponsable, Mission uneMission, Pays unPays)
        {
            this.id = id;
            this.nomAssociation = nomAssociation;
            this.nomResponsable = nomResponsable;
            this.uneMission = uneMission;
            this.unPays = unPays;
        }

        public int Id { get => id; set => id = value; }
        public string NomAssociation { get => nomAssociation; set => nomAssociation = value; }
        public string NomResponsable { get => nomResponsable; set => nomResponsable = value; }
        public Mission UneMission { get => uneMission; set => uneMission = value; }
        public Pays UnPays { get => unPays; set => unPays = value; }
        public string LibelleMission { get => uneMission.Libelle; }
        public string LibellePays { get => unPays.Libelle; }
        
    }
}
