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
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string msgErreur;

            string libelle = (string)txtAsso.Text;
            string nomResponsable = (string)txtNomResponsable.Text;
            int idMission = (int)cbxMission.SelectedIndex;
            int idPays = (int)cbxPays.SelectedIndex;

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
    }
}
