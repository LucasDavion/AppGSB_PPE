using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Ref à la BLL et BO
using GesMecenatBLL;
using GesMecenatBO;

namespace AppGSB_PPE
{
    public partial class FormAjoutUtilisateur : Form
    {
        public FormAjoutUtilisateur()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string msg;
            UtilisateurManager.GetInstance().CreerUtilisateur(txtNom.Text, txtPrenom.Text,out msg);
            lblMsg.Text = msg;
        }
    }
}
