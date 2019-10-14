namespace AppGSB_PPE
{
    partial class FormMenuPartenariat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAjoutPartenariat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultationPartenariat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAjoutPartenariat = new System.Windows.Forms.Panel();
            this.btnAjoutPartenariat = new System.Windows.Forms.Button();
            this.cbxSelectionAction = new System.Windows.Forms.ComboBox();
            this.cbxSelectionAssociation = new System.Windows.Forms.ComboBox();
            this.txtBudgetPrevisionnel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectionAction = new System.Windows.Forms.Label();
            this.lblSelectionAssociation = new System.Windows.Forms.Label();
            this.lblAjoutPartenariat = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlAjoutPartenariat.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAjoutPartenariat,
            this.menuConsultationPartenariat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAjoutPartenariat
            // 
            this.menuAjoutPartenariat.Name = "menuAjoutPartenariat";
            this.menuAjoutPartenariat.Size = new System.Drawing.Size(135, 20);
            this.menuAjoutPartenariat.Text = "Ajout d\'un partenariat";
            this.menuAjoutPartenariat.Click += new System.EventHandler(this.menuAjoutPartenariat_Click);
            // 
            // menuConsultationPartenariat
            // 
            this.menuConsultationPartenariat.Name = "menuConsultationPartenariat";
            this.menuConsultationPartenariat.Size = new System.Drawing.Size(173, 20);
            this.menuConsultationPartenariat.Text = "Consultation des partenariats";
            // 
            // pnlAjoutPartenariat
            // 
            this.pnlAjoutPartenariat.Controls.Add(this.btnAjoutPartenariat);
            this.pnlAjoutPartenariat.Controls.Add(this.cbxSelectionAction);
            this.pnlAjoutPartenariat.Controls.Add(this.cbxSelectionAssociation);
            this.pnlAjoutPartenariat.Controls.Add(this.txtBudgetPrevisionnel);
            this.pnlAjoutPartenariat.Controls.Add(this.label3);
            this.pnlAjoutPartenariat.Controls.Add(this.lblSelectionAction);
            this.pnlAjoutPartenariat.Controls.Add(this.lblSelectionAssociation);
            this.pnlAjoutPartenariat.Controls.Add(this.lblAjoutPartenariat);
            this.pnlAjoutPartenariat.Location = new System.Drawing.Point(50, 58);
            this.pnlAjoutPartenariat.Name = "pnlAjoutPartenariat";
            this.pnlAjoutPartenariat.Size = new System.Drawing.Size(708, 348);
            this.pnlAjoutPartenariat.TabIndex = 1;
            this.pnlAjoutPartenariat.Visible = false;
            // 
            // btnAjoutPartenariat
            // 
            this.btnAjoutPartenariat.Location = new System.Drawing.Point(325, 223);
            this.btnAjoutPartenariat.Name = "btnAjoutPartenariat";
            this.btnAjoutPartenariat.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutPartenariat.TabIndex = 7;
            this.btnAjoutPartenariat.Text = "Valider";
            this.btnAjoutPartenariat.UseVisualStyleBackColor = true;
            this.btnAjoutPartenariat.Click += new System.EventHandler(this.btnAjoutPartenariat_Click);
            // 
            // cbxSelectionAction
            // 
            this.cbxSelectionAction.FormattingEnabled = true;
            this.cbxSelectionAction.Location = new System.Drawing.Point(215, 125);
            this.cbxSelectionAction.Name = "cbxSelectionAction";
            this.cbxSelectionAction.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectionAction.TabIndex = 6;
            // 
            // cbxSelectionAssociation
            // 
            this.cbxSelectionAssociation.FormattingEnabled = true;
            this.cbxSelectionAssociation.Location = new System.Drawing.Point(239, 80);
            this.cbxSelectionAssociation.Name = "cbxSelectionAssociation";
            this.cbxSelectionAssociation.Size = new System.Drawing.Size(121, 21);
            this.cbxSelectionAssociation.TabIndex = 5;
            this.cbxSelectionAssociation.SelectedIndexChanged += new System.EventHandler(this.cbxSelectionAssociation_SelectedIndexChanged);
            // 
            // txtBudgetPrevisionnel
            // 
            this.txtBudgetPrevisionnel.Location = new System.Drawing.Point(267, 169);
            this.txtBudgetPrevisionnel.Name = "txtBudgetPrevisionnel";
            this.txtBudgetPrevisionnel.Size = new System.Drawing.Size(100, 20);
            this.txtBudgetPrevisionnel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Renseignez un budget prévisionnel :";
            // 
            // lblSelectionAction
            // 
            this.lblSelectionAction.AutoSize = true;
            this.lblSelectionAction.Location = new System.Drawing.Point(82, 128);
            this.lblSelectionAction.Name = "lblSelectionAction";
            this.lblSelectionAction.Size = new System.Drawing.Size(127, 13);
            this.lblSelectionAction.TabIndex = 2;
            this.lblSelectionAction.Text = "Selectionnez une action :";
            // 
            // lblSelectionAssociation
            // 
            this.lblSelectionAssociation.AutoSize = true;
            this.lblSelectionAssociation.Location = new System.Drawing.Point(82, 83);
            this.lblSelectionAssociation.Name = "lblSelectionAssociation";
            this.lblSelectionAssociation.Size = new System.Drawing.Size(151, 13);
            this.lblSelectionAssociation.TabIndex = 1;
            this.lblSelectionAssociation.Text = "Selectionnez une association :";
            // 
            // lblAjoutPartenariat
            // 
            this.lblAjoutPartenariat.AutoSize = true;
            this.lblAjoutPartenariat.Location = new System.Drawing.Point(311, 18);
            this.lblAjoutPartenariat.Name = "lblAjoutPartenariat";
            this.lblAjoutPartenariat.Size = new System.Drawing.Size(107, 13);
            this.lblAjoutPartenariat.TabIndex = 0;
            this.lblAjoutPartenariat.Text = "Ajout d\'un partenariat";
            // 
            // FormMenuPartenariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAjoutPartenariat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuPartenariat";
            this.Text = "Gestion des partenariats";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAjoutPartenariat.ResumeLayout(false);
            this.pnlAjoutPartenariat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAjoutPartenariat;
        private System.Windows.Forms.ToolStripMenuItem menuConsultationPartenariat;
        private System.Windows.Forms.Panel pnlAjoutPartenariat;
        private System.Windows.Forms.ComboBox cbxSelectionAction;
        private System.Windows.Forms.ComboBox cbxSelectionAssociation;
        private System.Windows.Forms.TextBox txtBudgetPrevisionnel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectionAction;
        private System.Windows.Forms.Label lblSelectionAssociation;
        private System.Windows.Forms.Label lblAjoutPartenariat;
        private System.Windows.Forms.Button btnAjoutPartenariat;
    }
}