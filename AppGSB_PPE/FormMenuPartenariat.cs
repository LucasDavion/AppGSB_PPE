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
        public FormMenuPartenariat()
        {
            InitializeComponent();
            List<Association> lesAssociations;
            //lesAssociations = AssociationManager.GetInstance().GetAssociation();
            this.cbxSelectionAssociation.DisplayMember = "Libelle";
            this.cbxSelectionAssociation.ValueMember = "Id";
            //this.cbxSelectionAssociation.DataSource = lesAssociations;

            List<Action> lesActions;
            //lesActions = ActionManager.GetInstance().GetAction();
            this.cbxSelectionAction.DisplayMember = "Libelle";
            this.cbxSelectionAction.ValueMember = "Id";
            //this.cbxSelectionAction.DataSource = lesActions;

            List<Partenariat> lesPartenariats;
            lesPartenariats = PartenariatManager.GetInstance().GetPartenariat();
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
    }
}
