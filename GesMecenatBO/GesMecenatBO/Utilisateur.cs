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
        private string identifiant;
        private Service unService;

        //Propriété

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Identifiant { get => identifiant; set => identifiant = value; }
        public Service UnService { get => unService; set => unService = value; }

        //Constructeur

        public Utilisateur(string nom, string prenom ,string identifiant, string mdp, Service unService)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.identifiant = identifiant;
            this.mdp = mdp;
            this.unService = unService;
        }
    }
}
