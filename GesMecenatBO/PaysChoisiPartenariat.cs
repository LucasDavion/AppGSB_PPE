using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class PaysChoisiPartenariat
    {
        private int idPays;
        private int annee;
        private Pays pays;

        public PaysChoisiPartenariat(int id, int annee)
        {
            this.idPays = id;
            this.annee = annee;
        }

        public PaysChoisiPartenariat(int id, int annee, Pays pays)
        {
            this.Id = id;
            this.Annee = annee;
            this.Pays = pays;
        }

        public int Id { get => idPays; set => idPays = value; }
        public int Annee { get => annee; set => annee = value; }
        public Pays Pays { get => pays; set => pays = value; }
    }
}
