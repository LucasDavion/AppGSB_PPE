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
            this.cbxChoixAction.DisplayMember    = "libelle";
            this.cbxChoixAction.ValueMember      = "id";
            this.cbxChoixAction.DataSource   = ActionManager.GetInstance().GetActions();
            this.cbxChoixAction.SelectedIndex = -1;

        }

        private void cbxChoixAction_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlCrea.Visible = false;
            pnlModifSupr.Visible = true;
        }

    }
}
