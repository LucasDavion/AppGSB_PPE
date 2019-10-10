using GesMecenatBO;
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
    public partial class FormMenu : Form
    {
        List<Pays> lesPays;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void choixDesPaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChoixPays monChoixPays;
            monChoixPays = new FormChoixPays(lesPays);
            monChoixPays.Show();
        }
    }
}
