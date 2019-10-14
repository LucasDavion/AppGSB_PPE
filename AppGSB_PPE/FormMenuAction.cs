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
    public partial class FormMenuAction : Form
    {
        public FormMenuAction()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCrea.Visible = false;
            pnlModifSupr.Visible = true;
            txtModifAction.Enabled = true;
        }

        private void cbxCreation_CheckedChanged(object sender, EventArgs e)
        {
            if (txtModifAction.Enabled == false)
            {
                txtModifAction.Enabled = true;
                cbxChoixAction.Enabled = false;
            }
            else
            {
                txtModifAction.Enabled = false;
                cbxChoixAction.Enabled = true;
            }
            
        }
    }
}
