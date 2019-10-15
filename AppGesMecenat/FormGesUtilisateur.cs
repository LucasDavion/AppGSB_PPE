using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ref à la BO et BLL
using GesMecenatBLL;
using GesMecenatBO;

namespace AppGesMecenat
{
    public partial class FormGesUtilisateur : Form
    {
        public FormGesUtilisateur()
        {
            InitializeComponent();
            this.cbxService.DataSource = ServiceManager.GetInstance().GetServices();
            cbxService.DisplayMember = "Libelle";
            cbxService.ValueMember = "Id";
            cbxService.SelectedIndex = -1;
        }

        private void ajouterUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAjouterUtilisateur.Visible = true;
        }
    }
}
