using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class Action
    {
        private int id;
        private string libelle;

        public Action(string libelle)
        {
            this.libelle = libelle;
        }

        public Action(int id)
        {
            this.id = id;
        }

        public Action(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }
    }
}
