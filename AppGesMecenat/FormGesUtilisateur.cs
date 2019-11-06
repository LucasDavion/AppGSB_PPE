using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ref à la BO et BLL
using GesMecenatBLL;
using GesMecenatBO;

namespace AppGesMecenat
{
    public partial class FormGesUtilisateur : Form
    {
        public FormGesUtilisateur()
        {
            InitializeComponent();

            //Valorisation de la combobox pour les services

            this.cbxService.DataSource = ServiceManager.GetInstance().GetServices();
            this.cbxService.DisplayMember = "Libelle";
            this.cbxService.ValueMember = "Id";
            this.cbxService.SelectedIndex = -1;

            //Valorisation de la combobox pour les profilUtilisateurs

            this.cbxProfilUtilisateur.DataSource = ProfilUtilisateurManager.GetInstance().GetProfilUtilisateurs();
            this.cbxProfilUtilisateur.DisplayMember = "Libelle";
            this.cbxProfilUtilisateur.ValueMember = "Id";
            this.cbxProfilUtilisateur.SelectedIndex = -1;

            //List qui va contenir les utilisateurs

            List<Utilisateur> lesUtilisateurs = UtilisateurManager.GetInstance().GetUtilisateurs();

            //Initialisation de la datagrid qui va affiché les utilisateur

            dtgGesUtilisateur.DataSource = lesUtilisateurs;
            dtgGesUtilisateur.Columns["id"].Visible = false;
            dtgGesUtilisateur.Columns["mdp"].Visible = false;
            dtgGesUtilisateur.Columns["unService"].Visible = false;
            dtgGesUtilisateur.Columns["unProfilUtilisateur"].Visible = false;
            dtgGesUtilisateur.Columns["GetLibelleService"].HeaderText = "Service";
            dtgGesUtilisateur.Columns["GetLibelleProfilUtilisateur"].HeaderText = "Profil";
        }

        private void ajouterUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAjouterUtilisateur.Visible = true;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int idService = (int)cbxService.SelectedValue;
            int idProfilUtilisateur = (int)cbxProfilUtilisateur.SelectedValue;
            UtilisateurManager.GetInstance().CreerUtilisateur(txtNom.Text, txtPrenom.Text, idService, cbxService.Text, idProfilUtilisateur, cbxProfilUtilisateur.Text, out string msg);
            lblMsg.Text = msg;
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {

            //List qui va contenir les utilisateurs

            List<Utilisateur> lesUtilisateurs = UtilisateurManager.GetInstance().GetUtilisateurs();

            //Initialisation de la datagrid qui va affiché les utilisateur

            dtgGesUtilisateur.DataSource = lesUtilisateurs;
            dtgGesUtilisateur.Columns["id"].Visible = false;
            dtgGesUtilisateur.Columns["mdp"].Visible = false;
            //dtgGesUtilisateur.Columns["unService.libelle"]
            //dtgGesUtilisateur.Columns["unProfilUtilisateur"
        }
    }
}
