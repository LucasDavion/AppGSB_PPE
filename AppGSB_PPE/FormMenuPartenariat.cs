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
        }

        private void menuAjoutPartenariat_Click(object sender, EventArgs e)
        {
            pnlAjoutPartenariat.Visible = true;
        }

        private void cbxSelectionAssociation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
