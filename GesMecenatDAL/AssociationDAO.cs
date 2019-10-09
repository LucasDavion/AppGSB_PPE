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
    class AssociationDAO
    {
        public List<Association> GetAssociation()
        {

            //Declaration des variables de travail
            int id;
            string nom;
            string mission;
            Association uneAssociation;
            
            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = Connexion.GetObjConnexion();

            //On cree la collection lesClients qui vas contenir toute les caracteristique des cleints enregistrer dans la base de donnée 
            List<Association> lesAssos = new List<Association>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les caracteristiques de tous les client 
            string sql;
            sql = "select * from client join categorie on idCateg = categorie.id";
            SqlCommand maCommande = new SqlCommand(sql, cnx);
            maCommande.CommandText = sql;

            //On execute la requette dataReader
            SqlDataReader monLecteur;
            monLecteur = maCommande.ExecuteReader();

            //Pour chaque enregistrement du dateReader on cree les eregistrements 
            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                nom = (string)monLecteur["nom"];
                mission = (string)monLecteur["mission"];
    
                uneAssociation = new Association(nom, mission, id);
                lesAssos.Add(uneAssociation);
            }
            monLecteur.Close();

            //On ferme la connection
            Connexion.CloseConnexion();


            //On retourne la collection
            return lesAssos;
        }


        //La methode ajoutClient ajoute un client a la base de donnée
        public int AjoutClient(Association uneAssociation)
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
                maCommande.Parameters[1].Value = uneAssociation.Nom;
                maCommande.Parameters.Add("prenom", SqlDbType.VarChar);
                maCommande.Parameters[2].Value = uneAssociation.Mission;
                
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
