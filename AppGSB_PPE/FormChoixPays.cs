using GesMecenatBO;
using GesMecenatDAL;
using GesMecenatBLL;
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
        public FormChoixPays(List<Pays> laListe)
        {
            InitializeComponent();

            //on associe la collection à la Combobox
            this.cbxChoixPays.DataSource = PaysManager.GetInstance().GetPays();

            // la valeur affichée dans la liste sera la colonne libelle de la collection
            this.cbxChoixPays.DisplayMember = "libelle";

            // la valeur affichée dans la liste sera la colonne id de la collection
            this.cbxChoixPays.ValueMember = "id";

            // 
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
            string message = "";
            string erreur;
            int nbAjout;
            int pays = (int)cbxChoixPays.SelectedValue;
            
            nbAjout = PaysChoisiPartenariatManager.GetInstance().AjoutPays(pays, txtAnnee.Text, out erreur);
            if (nbAjout == 0)
            {
                message = "Aucun pays n'a été ajouté";
            }
            else
            {
                message = "Le pays a bien été ajouté" ;
            }
            if (erreur != "")
            {
                message = erreur;
            }
            MessageBox.Show(message);
            txtAnnee.Text = "";
            
        }

        private void btnConsultPays_Click(object sender, EventArgs e)
        {
            this.dtgConsultPays.DataSource = PaysChoisiPartenariatManager.GetInstance().GetPays();
            dtgConsultPays.Columns["Pays"].Visible = false;
            dtgConsultPays.Columns["IdPaysChoisi"].Visible = false;
        }
    }    
}
