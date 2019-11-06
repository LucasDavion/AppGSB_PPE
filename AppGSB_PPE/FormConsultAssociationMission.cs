using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesMecenatBLL;
using GesMecenatBO;
using GesMecenatDAL;

namespace AppGSB_PPE
{
    public partial class FormConsultAssociationMission : Form
    {
        List<Association> lesAssociations;
        List<Mission> lesMissions;
        

        public FormConsultAssociationMission()
        {
            InitializeComponent();
            List<Pays> lesPays = PaysManager.GetInstance().GetPays();
            
            lesAssociations = AssociationManager.GetInstance().GetAssociations();
            dtgConsultAssociation.DataSource = null;
            dtgConsultAssociation.DataSource = lesAssociations;

            lesMissions = MissionManager.GetInstance().GetMission();
            dtgConsultMissions.DataSource = null;
            dtgConsultMissions.DataSource = lesMissions;

            cbxPays.DisplayMember = "Libelle";
            cbxPays.ValueMember = "Id";
            cbxPays.DataSource = lesPays;

            cbxPays.Visible = false;
            dtgConsultAssociation.Visible = false;
            dtgConsultMissions.Visible = false;
        }

        private void btnMissions_Click(object sender, EventArgs e)
        {
            dtgConsultAssociation.Visible = false;
            dtgConsultMissions.Visible = true;
            dtgConsultMissions.Columns["Id"].Visible = false;
            lblRecherche.Visible = false;
            cbxPays.Visible = false;
            dtgConsultAssociation.Columns["Libelle"].HeaderText = "Mission";
        }

        private void btnAssociation_Click(object sender, EventArgs e)
        {
            dtgConsultMissions.Visible = false;
            dtgConsultAssociation.Visible = true;
            dtgConsultAssociation.Columns["Id"].Visible = false;
            dtgConsultAssociation.Columns["UneMission"].Visible = false;
            dtgConsultAssociation.Columns["UnPays"].Visible = false;
            dtgConsultAssociation.Columns["NomAssociation"].HeaderText = "Nom de l'association";
            dtgConsultAssociation.Columns["NomResponsable"].HeaderText = "Nom du responsable";
            dtgConsultAssociation.Columns["LibelleMission"].HeaderText = "Mission";
            dtgConsultAssociation.Columns["LibellePays"].HeaderText = "Pays";
            lblRecherche.Visible = true;
            cbxPays.Visible = true;
            dtgConsultAssociation.DataSource = lesAssociations;
        }

        private void cbxPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Association> lesPaysAssociation = new List<Association>();
            foreach (Association uneAssociation in lesAssociations)
            {
                if (uneAssociation.LibellePays == cbxPays.Text)
                {
                    lesPaysAssociation.Add(uneAssociation);
                }
            }
            dtgConsultAssociation.DataSource = lesPaysAssociation;
        }
    }
}
