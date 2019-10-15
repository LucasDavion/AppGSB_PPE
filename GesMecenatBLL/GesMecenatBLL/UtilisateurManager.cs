﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography; //Ref pour utilisé le sha1
using System.Text;
using System.Threading.Tasks;
//Ref aux bibliothèque des classe DAL et BO
using GesMecenatBO;
using GesMecenatDAL;

namespace GesMecenatBLL
{
    public class UtilisateurManager
    {
        private static UtilisateurManager uneInstance;

        //Méthode pour crée un objet de la classe ClientDAO si il n'existe pas sinon on retourne la réf à cet objet

        public static UtilisateurManager GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new UtilisateurManager();
            }

            return uneInstance;
        }

        //Constructeur privé par défaut donc impossible de crée un objet à l'ext de cette classe

        private UtilisateurManager()
        {
        }

        //Appel couche DAL pour crée l'utilisateur

        public int CreerUtilisateur(string sonNom, string sonPrenom, int idService, string libelleService ,out string msg)
        {

            //Variable

            string identifiant;
            string mdp;
            string mdpCrypte;
            Service unService;

            idService++;

            //Création de l'identifiant avec la 1er lettre du nom et le prenom entier

            identifiant = sonNom.Substring(0, 1) + sonPrenom;

            //Création du mdp 

            mdp = sonNom + sonPrenom;
            byte[] DataBytes = System.Text.Encoding.UTF8.GetBytes(mdp);
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(DataBytes);
            mdpCrypte = Convert.ToBase64String(hash);

            //Creéation de l'objet Service depuis l'id et le libelle selectionné depuis la comboBox

            unService = new Service(idService, libelleService);

            //Trouvé dans la list le service qui correspond

            //Création de l'objet utilisateur

            Utilisateur unUtilisateur;
            unUtilisateur = new Utilisateur(sonNom, sonPrenom, identifiant, mdpCrypte, unService);
            msg = "Un utilisateur a bien était crée";

            return UtilisateurDAO.GetInstance().AjoutUtilisateur(unUtilisateur);
        }
    }
}