﻿using GesMecenatBO;
using GesMecenatDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGSB_PPE
{
    public partial class FormChoixPays : Form
    {
        List<Pays> lesPays;
        public FormChoixPays(List<Pays> laListe)
        {
            InitializeComponent();
            

            //Declaration des variables de travail
            int id;
            string libelle;
            Pays unPays;

            //On recupere l'objet responsable de la connection a la base
            SqlConnection cnx = connexion.GetObjConnexion();

            //On cree la collection lesPays qui vas contenir toute les caracteristique des cleints enregistrer dans la base de donnée 
            List<Pays> lesPays = new List<Pays>();

            //On cree l'objet de type SqlCommand qui vas contenir la requete SQL permettant d'obtenir toutes les caracteristiques de tous les client 
            string sql;
            sql = "select * from pays";
            SqlCommand maCommande = new SqlCommand(sql, cnx);
            maCommande.CommandText = sql;

            //On execute la requette dataReader
            SqlDataReader monLecteur;
            monLecteur = maCommande.ExecuteReader();

            //Pour chaque enregistrement du dateReader on cree les eregistrements 
            while (monLecteur.Read())
            {
                id = (int)monLecteur["id"];
                libelle = (string)monLecteur["nom_fr_fr"];

                unPays = new Pays(id, libelle);
                lesPays.Add(unPays);
            }
            monLecteur.Close();

            //On ferme la connection
            connexion.CloseConnexion();

            // la valeur affichée dans la liste sera la colonne NomEmploye de la collection
            this.cbxChoixPays.DisplayMember = "libelle";

            // la valeur affichée dans la liste sera la colonne NumEmploye de la collection
            this.cbxChoixPays.ValueMember = "id";

            //on associe la collection à la Combobox
            this.cbxChoixPays.DataSource = lesPays;         
        }
    }    
}
