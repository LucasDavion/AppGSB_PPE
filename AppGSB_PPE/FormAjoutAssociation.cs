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
    public partial class FormAjoutAssociation : Form
    {
        public FormAjoutAssociation()
        {
            InitializeComponent();
            List<Pays> lesPays = PaysManager.GetInstance().GetPays();
            List<Mission> lesMissions = MissionManager.GetInstance().GetMission();

            cbxMission.DisplayMember = "Libelle";
            cbxMission.ValueMember = "Id";
            cbxMission.DataSource = lesMissions;

            cbxPays.DisplayMember = "Libelle";
            cbxPays.ValueMember = "Id";
            cbxPays.DataSource = lesPays;





        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string msgErreur;
            
            string libelle = (string)txtAsso.Text;
            string nomResponsable = (string)txtNomResponsable.Text;
            int idMission = (int)cbxMission.SelectedValue;
            int idPays = (int)cbxPays.SelectedValue;

            AssociationManager.GetInstance().CreerAssociation(libelle,nomResponsable,idMission,idPays, out msgErreur);

            if (msgErreur == "")
            {
                MessageBox.Show(" Enregistrement Ajouté", "Sucess");
            }
            else
            {
                MessageBox.Show(msgErreur, "Probleme");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
