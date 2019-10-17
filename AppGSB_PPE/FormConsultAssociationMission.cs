using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesMecenatBLL;
using GesMecenatBO;
using GesMecenatDAL;

namespace AppGSB_PPE
{
    public partial class FormConsultAssociationMission : Form
    {
        public FormConsultAssociationMission()
        {
            InitializeComponent();
            List<Mission> lesMissions;
            
            lesMissions = MissionManager.GetInstance().GetMission();

            List<Association> lesAssociations;
            
            lesAssociations = AssociationManager.GetInstance().GetAssociations();


            dtgConsultAssociation.DataSource = lesAssociations;
            dtgMission.DataSource = lesMissions;

         
        }

        private void btnMissions_Click(object sender, EventArgs e)
        {
            dtgMission.Visible = true;
            dtgConsultAssociation.Visible = false;
        }

        private void btnAssociation_Click(object sender, EventArgs e)
        {
            dtgMission.Visible = false;
            dtgConsultAssociation.Visible = true;
        }
    }
}
