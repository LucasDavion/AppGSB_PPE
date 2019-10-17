using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGesMecenat
{
    public partial class FormPanel : Form
    {
        public FormPanel()
        {
            InitializeComponent();
        }

        private void gesUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGesUtilisateur monFormGesUtilisateur = new FormGesUtilisateur();
            monFormGesUtilisateur.Show();
        }
    }
}
