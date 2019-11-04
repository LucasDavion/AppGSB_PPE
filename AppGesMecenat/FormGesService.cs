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

namespace AppGesMecenat
{
    public partial class FormGesService : Form
    {
        public FormGesService()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ServiceManager.GetInstance().CreerService(txtLibelle.Text, out string msg);
            lblMsg.Text = msg;
        }
    }
}
