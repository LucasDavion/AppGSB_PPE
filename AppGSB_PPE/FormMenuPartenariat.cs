using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesMecenatBO;
using GesMecenatBLL;
using Action = GesMecenatBO.Action;

namespace AppGSB_PPE
{
    public partial class FormMenuPartenariat : Form
    {
        List<Partenariat> lesPartenariats=PartenariatManager.GetInstance().GetPartenariat();
        public FormMenuPartenariat()
        {
            InitializeComponent();
            List<Association> lesAssociations= AssociationManager.GetInstance().GetAssociations();
            this.cbxSelectionAssociation.DisplayMember = "Libelle";
            this.cbxSelectionAssociation.ValueMember = "Id";
            this.cbxSelectionAssociation.DataSource = lesAssociations;

            this.cbxSelectionAssociationConsult.DisplayMember = "Libelle";
            this.cbxSelectionAssociationConsult.ValueMember = "Id";
            this.cbxSelectionAssociationConsult.DataSource = lesAssociations;

            //List<Action> lesActions= ActionManager.GetInstance().GetAction();
            this.cbxSelectionAction.DisplayMember = "Libelle";
            this.cbxSelectionAction.ValueMember = "Id";
            //this.cbxSelectionAction.DataSource = lesActions;

            
            dtgConsultPartenariat.DataSource = null;
            dtgConsultPartenariat.DataSource = lesPartenariats;
            dtgConsultPartenariat.Columns["id"].Visible = false;
            dtgConsultPartenariat.Columns["uneAssociation"].Visible = false;
            dtgConsultPartenariat.Columns["uneAction"].Visible = false;
        }

        private void menuAjoutPartenariat_Click(object sender, EventArgs e)
        {
            pnlAjoutPartenariat.Visible = true;
            pnlModifPartenariat.Visible = false;
        }

        private void cbxSelectionAssociation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutPartenariat_Click(object sender, EventArgs e)
        {
            string msgerr;
            int nbAjout;
            int idAssociation = (int)cbxSelectionAssociation.SelectedValue;
            int idAction = (int)cbxSelectionAction.SelectedValue;
            float budgetPrevisionnel;
            float.TryParse(txtBudgetPrevisionnel.Text, out budgetPrevisionnel);
            nbAjout = PartenariatManager.GetInstance().CreerPartenariat(budgetPrevisionnel, idAssociation, idAction, out msgerr);
            if (nbAjout == 0)
            {
                MessageBox.Show("0 enregistrement a été enregisté");
            }
            else
            {
                MessageBox.Show("Les enregistrements on bien été ajoutés, nombre d'enregistrements : " + nbAjout);
            }
            if (msgerr != "")
            {
                MessageBox.Show(msgerr);
            }
        }

        private void menuConsultationPartenariat_Click(object sender, EventArgs e)
        {
            pnlModifPartenariat.Visible = true;
            pnlAjoutPartenariat.Visible = false;
        }

        private void cbxSelectionAssociationModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Partenariat> LesPartenariatsAssociations= new List<Partenariat>();
            foreach(Partenariat unPartenariat in lesPartenariats)
            {
                if (unPartenariat.LibelleAssociation == cbxSelectionAssociation.Text)
                {
                    LesPartenariatsAssociations.Add(unPartenariat);
                }
            }
            dtgConsultPartenariat.DataSource = LesPartenariatsAssociations;
        }
    }
}
