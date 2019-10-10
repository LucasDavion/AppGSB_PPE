using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGSB_PPE
{
    public partial class FormMenuPartenariat : Form
    {
        public FormMenuPartenariat()
        {
            InitializeComponent();
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
