using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class Service
    {

        //Atributs

        private int id;
        private string libelle;

        //Propriété

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        //Constructeur

        public Service(string libelle)
        {
            this.libelle = libelle;
        }
        public Service(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
    }
}
