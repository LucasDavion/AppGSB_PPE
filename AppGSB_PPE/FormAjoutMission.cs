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
    public partial class FormAjoutMission : Form
    {
        public FormAjoutMission()
        {
            InitializeComponent();
        }

        private void btnValiderMission_Click(object sender, EventArgs e)
        {
            string msgErreur;
            
            string mission = (string)txtMission.Text;

           
            MissionManager.GetInstance().CreerMission(mission, out msgErreur);

            if (msgErreur == "")
            {
                MessageBox.Show(" Enregistrement Ajouté", "Sucess");
            }
            else
            {
                MessageBox.Show(msgErreur, "Probleme");
            }
        }
    }
}
