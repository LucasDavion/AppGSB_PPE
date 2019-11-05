using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesMecenatDAL;
using GesMecenatBLL;

namespace AppGSB_PPE
{
    public partial class FormMenuAction : Form
    {
        public FormMenuAction()
        {
            InitializeComponent();
        }

        private void FormMenuAction_Load(object sender, EventArgs e)
        {
            this.cbxChoixAction.DisplayMember = "libelle";
            this.cbxChoixAction.ValueMember = "id";
            this.cbxChoixAction.DataSource = ActionManager.GetInstance().GetActions();
            this.cbxChoixAction.SelectedIndex = -1;

            this.dtgConsultAction.DataSource = ActionManager.GetInstance().GetActions();

        }

        private void cbxChoixAction_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblNomNouvAction.Visible = false;
            pnlModifSupr.Visible = true;
            lblNomActionModif.Visible = true;
        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            string nouvNomAction = txtModifAction.Text;

            if (nouvNomAction != "")
            {
                ActionManager.CreaAction(nouvNomAction);
                MessageBox.Show("La création de l'action a bien était effectuer", "succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtgConsultAction.DataSource = ActionManager.GetInstance().GetActions();
            }
            else
            {
                MessageBox.Show("Le champ du nom doit etre remplie", "echec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModification_Click(object sender, EventArgs e)
        {
            string modifNomAction = txtModifAction.Text;
            string nomAction      = cbxChoixAction.Text;

            if (modifNomAction != "")
            {
                ActionManager.ModifAction(modifNomAction, nomAction);
                MessageBox.Show("La création de l'action a bien était effectuer", "succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dtgConsultAction.DataSource = ActionManager.GetInstance().GetActions();
            }
            else
            {
                MessageBox.Show("Le champ du nom doit etre remplie", "echec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
