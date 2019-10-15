﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GesMecenatBO;

namespace GesMecenatDAL
{
    public class AssociationDAO
    {

        private static AssociationDAO uneInstance;

        public static AssociationDAO GetInstance()
        {
            if (uneInstance == null)
            {
                uneInstance = new AssociationDAO();
            }
            return uneInstance;
        }

        private AssociationDAO()
        {

        }
        public List<Association> GetAssociation()
        {

            //Declaration des variables de travail
            int id;
            string nom;
            string mission;
            string pays;
            string libelle;
            Association uneAssociation;
            
            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //On cree la collection lesClients qui vas contenir toute les caracteristique des cleints enregistrer dans la base de donnée 
            List<Association> lesAssos = new List<Association>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les caracteristiques de tous les client 
            string sql;
            sql = "Select association.id, association.libelle, nomResponsable, pays.nom_fr_fr, mission.libelle from association join mission on id_mission = mission.id join pays on id_pays = pays.id";
            SqlCommand maCommande = new SqlCommand(sql, cnx);
            maCommande.CommandText = sql;

            //On execute la requette dataReader
            SqlDataReader monLecteur;
            monLecteur = maCommande.ExecuteReader();

            //Pour chaque enregistrement du dateReader on cree les eregistrements 
            while (monLecteur.Read())
            {
                id = (int)monLecteur["association.id"];
                libelle = (string)monLecteur["association.libelle"];
                nom = (string)monLecteur["nomResponsable"];
                mission = (string)monLecteur["mission.libelle"];
                pays = (string)monLecteur["pays.nom_fr_fr"];

                uneAssociation = new Association(id, libelle, nom, mission, pays);
                lesAssos.Add(uneAssociation);
            }
            monLecteur.Close();

            //On ferme la connection
            Connexion.CloseConnexion();


            //On retourne la collection
            return lesAssos;
        }


        //La methode ajoutClient ajoute un client a la base de donnée
        public int AjoutAssociation(Association uneAssociation)
        {
            int nbEnreg = 0;


            string sql;
            string msgErr = "";
            try
            {
                //On recupere l'objet responsable de la connection a la base
                SqlConnection cnx = Connexion.GetObjConnexion();
                sql = "insert into ";
                SqlCommand maCommande = new SqlCommand(sql, cnx);

                maCommande.Parameters.Add("nom", SqlDbType.VarChar);
                maCommande.Parameters[1].Value = uneAssociation.NomAssociation;
                maCommande.Parameters.Add("prenom", SqlDbType.VarChar);
                maCommande.Parameters[2].Value = uneAssociation.NomResponsable;
                
                maCommande.CommandText = sql;
                nbEnreg = maCommande.ExecuteNonQuery();
            }
            catch (SqlException err)
            {
                msgErr += "Erreur requete SQL " + err.Message;
            }
            catch (Exception err)
            {
                msgErr += "Erreur grave " + err.Message;
            }

            Connexion.CloseConnexion();
            return nbEnreg;
        }


    }
}
