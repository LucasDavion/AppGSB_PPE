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
        private string nouvLibelle;

        public Action(string libelle)
        {
            this.libelle = libelle;
        }

        public Action(string nouvLibelle, string libelle)
        {
            this.nouvLibelle = nouvLibelle;
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
        public string NouvLibelle { get => nouvLibelle; set => nouvLibelle = value; }
    }
}
