using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesMecenatBO
{
    public class Utilisateur
    {

        //Attributs

        private int id;
        private string nom;
        private string prenom;
        private string mdp;

        //Propriété

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Mdp { get => mdp; set => mdp = value; }

        //Constructeur

        Utilisateur(string nom, string prenom, string mdp)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.mdp = mdp;
        }

    }
}
