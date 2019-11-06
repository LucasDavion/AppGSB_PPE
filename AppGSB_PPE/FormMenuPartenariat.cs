using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesMecenatBO;
using GesMecenatBLL;
using Action = GesMecenatBO.Action;

namespace AppGSB_PPE
{
    public partial class FormMenuPartenariat : Form
    {
        //Création de la collection lesPartenariats qui contient la collection retourné par la méthode GetPartenariats
        List<Partenariat> lesPartenariats=PartenariatManager.GetInstance().GetPartenariats();

        //Constructeur du FormMenuPartenariat
        public FormMenuPartenariat()
        {
            InitializeComponent();
            //Création de la collection lesAssocations qui contient la collection retourné par la méthode GetAssociations
            List<Association> lesAssociations= AssociationManager.GetInstance().GetAssociations();
            //On met les objets de la collection lesAssocations dans la liste déroulante cbxSelectionAssociation
            this.cbxSelectionAssociation.DisplayMember = "NomAssociation";
            this.cbxSelectionAssociation.ValueMember = "Id";
            this.cbxSelectionAssociation.DataSource = lesAssociations;

            //On met les objets de la collection lesAssocations dans la liste déroulante cbxSelectionAssociationConsult
            this.cbxSelectionAssociationConsult.DisplayMember = "NomAssociation";
            this.cbxSelectionAssociationConsult.ValueMember = "Id";
            this.cbxSelectionAssociationConsult.DataSource = lesAssociations;

            //Création de la collection lesActions qui contient la collection retourné par la méthode GetActions
            List<Action> lesActions= ActionManager.GetInstance().GetActions();
            //On met les objets de la collection lesActions dans la liste déroulante cbxSelectionAction
            this.cbxSelectionAction.DisplayMember = "Libelle";
            this.cbxSelectionAction.ValueMember = "Id";
            this.cbxSelectionAction.DataSource = lesActions;

            //Parmètrage de dtgConsultPartenariat
            dtgConsultPartenariat.DataSource = null;
            dtgConsultPartenariat.DataSource = lesPartenariats;
            dtgConsultPartenariat.Columns["id"].Visible = false;
            dtgConsultPartenariat.Columns["uneAssociation"].Visible = false;
            dtgConsultPartenariat.Columns["uneAction"].Visible = false;
            dtgConsultPartenariat.Columns["LibelleAssociation"].HeaderText = "Nom de l'association";
            dtgConsultPartenariat.Columns["LibelleAction"].HeaderText = "Nom de l'action";
            dtgConsultPartenariat.Columns["CoutReel"].HeaderText = "Cout réél";
        }

        private void menuAjoutPartenariat_Click(object sender, EventArgs e)
        {
            //On rend visible ou invisible les panels en fonction du besoin
            pnlAjoutPartenariat.Visible = true;
            pnlModifPartenariat.Visible = false;
        }

        private void cbxSelectionAssociation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutPartenariat_Click(object sender, EventArgs e)
        {
            //Déclaration des variables
            string msgerr;
            int nbAjout;
            int idAssociation = (int)cbxSelectionAssociation.SelectedValue;
            int idAction = (int)cbxSelectionAction.SelectedValue;
            float budgetPrevisionnel;
            float.TryParse(txtBudgetPrevisionnel.Text, out budgetPrevisionnel);
            //Ajout des valeurs saisie par l'utilisateur dans paramètre de la méthode GreerPartenariat
            nbAjout = PartenariatManager.GetInstance().CreerPartenariat(budgetPrevisionnel, idAssociation, idAction, out msgerr);
            
            if (nbAjout == 0)
            {
                //Si il n'y a pas d'enrgistrement, on le signal à l'utilisateur
                MessageBox.Show("0 enregistrement a été enregisté");
            }
            else
            {
                //Si non on signal à l'utilisateur que ses enrgistrements ont été pris en compte
                MessageBox.Show("Les enregistrements on bien été ajoutés, nombre d'enregistrements : " + nbAjout);
                txtBudgetPrevisionnel.Text = "";
            }
            if (msgerr != "")
            {
                //Si il y a une erreur on l'affiche a l'utilsateur
                MessageBox.Show(msgerr);
            }
        }

        private void menuConsultationPartenariat_Click(object sender, EventArgs e)
        {
            //On rend visible ou invisible les panels en fonction du besoin
            pnlModifPartenariat.Visible = true;
            pnlAjoutPartenariat.Visible = false;
        }

        private void cbxSelectionAssociationModif_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Création d'une collection qui contiendra les partenariat qui correspondent à l'association selectionnée dans la liste déroulante cbxSelectionAssociationConsult
            List<Partenariat> LesPartenariatsAssociations= new List<Partenariat>();
            foreach(Partenariat unPartenariat in lesPartenariats)
            {
                //Si le nom de l'association correspond à celui selectionnée, on ajout dans la collection LesPartenariatsAssociations le partenariat
                if (unPartenariat.LibelleAssociation == cbxSelectionAssociationConsult.Text)
                {
                    LesPartenariatsAssociations.Add(unPartenariat);
                }
            }
            //On renseigne donc la nouvelle source de donnée
            dtgConsultPartenariat.DataSource = LesPartenariatsAssociations;
        }

        private void FormMenuPartenariat_Load(object sender, EventArgs e)
        {

        }
    }
}
