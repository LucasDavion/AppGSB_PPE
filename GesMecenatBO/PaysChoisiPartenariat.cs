using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class PaysChoisiPartenariat
    {
        
        private int annee;
        private Pays pays;

        public PaysChoisiPartenariat(Pays unPays, int annee)
        {
            this.pays = unPays;
            this.annee = annee;
        }
        


        
        public int Annee { get => annee; set => annee = value; }
        public Pays Pays { get => pays; set => pays = value; }
        public string LibellePaysChoisi { get => pays.Libelle; set =>  pays.Libelle= value; }
        public int IdPaysChoisi { get => pays.Id; set => pays.Id = value; }
    }
}
