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
            
        }

        private void btnMissions_Click(object sender, EventArgs e)
        {
            List<Mission> lesMissions;
            lesMissions = MissionManager.GetInstance().GetMission();
            dtgConsult.DataSource = null;
            dtgConsult.DataSource = lesMissions;
        }

        private void btnAssociation_Click(object sender, EventArgs e)
        {
            List<Association> lesAssociations;
            lesAssociations = AssociationManager.GetInstance().GetAssociations();
            dtgConsult.DataSource = null;
            dtgConsult.DataSource = lesAssociations;
            dtgConsult.Columns["Id"].Visible = false;
            dtgConsult.Columns["UneMission"].Visible = false;
            dtgConsult.Columns["UnPays"].Visible = false;
        }
    }
}
