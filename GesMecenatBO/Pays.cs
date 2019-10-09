using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class Pays
    {
        private string id;
        private string libelle;

        public Pays(string id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }

        public string Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
