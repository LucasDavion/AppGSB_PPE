using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class ProfilUtilisateur
    {

        //Attribut

        private int id;
        private string libelle;

        //Propriétés

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        //Constructeur

        public ProfilUtilisateur(int id, string libelle)
        {
            this.Id = id;
            this.libelle = libelle;
        }
    }
}
