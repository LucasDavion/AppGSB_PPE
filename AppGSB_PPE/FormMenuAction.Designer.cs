namespace AppGSB_PPE
{
    partial class FormMenuAction
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreation = new System.Windows.Forms.Button();
            this.btnModification = new System.Windows.Forms.Button();
            this.btnSupression = new System.Windows.Forms.Button();
            this.pnlCrea = new System.Windows.Forms.Panel();
            this.pnlModifSupr = new System.Windows.Forms.Panel();
            this.pnlChoixAction = new System.Windows.Forms.Panel();
            this.lblChoixAction = new System.Windows.Forms.Label();
            this.lblNomNouvAction = new System.Windows.Forms.Label();
            this.txtModifAction = new System.Windows.Forms.TextBox();
            this.cbxChoixAction = new System.Windows.Forms.ComboBox();
            this.lblNomActionModif = new System.Windows.Forms.Label();
            this.pnlCrea.SuspendLayout();
            this.pnlModifSupr.SuspendLayout();
            this.pnlChoixAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(3, 3);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(207, 33);
            this.btnCreation.TabIndex = 0;
            this.btnCreation.Text = "Creation";
            this.btnCreation.UseVisualStyleBackColor = true;
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(3, 3);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(101, 33);
            this.btnModification.TabIndex = 1;
            this.btnModification.Text = "Modification";
            this.btnModification.UseVisualStyleBackColor = true;
            // 
            // btnSupression
            // 
            this.btnSupression.Location = new System.Drawing.Point(108, 3);
            this.btnSupression.Name = "btnSupression";
            this.btnSupression.Size = new System.Drawing.Size(101, 33);
            this.btnSupression.TabIndex = 2;
            this.btnSupression.Text = "Supression";
            this.btnSupression.UseVisualStyleBackColor = true;
            // 
            // pnlCrea
            // 
            this.pnlCrea.Controls.Add(this.btnCreation);
            this.pnlCrea.Location = new System.Drawing.Point(0, 0);
            this.pnlCrea.Name = "pnlCrea";
            this.pnlCrea.Size = new System.Drawing.Size(213, 39);
            this.pnlCrea.TabIndex = 3;
            // 
            // pnlModifSupr
            // 
            this.pnlModifSupr.Controls.Add(this.btnModification);
            this.pnlModifSupr.Controls.Add(this.btnSupression);
            this.pnlModifSupr.Controls.Add(this.pnlCrea);
            this.pnlModifSupr.Location = new System.Drawing.Point(12, 122);
            this.pnlModifSupr.Name = "pnlModifSupr";
            this.pnlModifSupr.Size = new System.Drawing.Size(213, 39);
            this.pnlModifSupr.TabIndex = 4;
            this.pnlModifSupr.Visible = false;
            // 
            // pnlChoixAction
            // 
            this.pnlChoixAction.Controls.Add(this.lblNomActionModif);
            this.pnlChoixAction.Controls.Add(this.lblChoixAction);
            this.pnlChoixAction.Controls.Add(this.lblNomNouvAction);
            this.pnlChoixAction.Controls.Add(this.txtModifAction);
            this.pnlChoixAction.Controls.Add(this.cbxChoixAction);
            this.pnlChoixAction.Location = new System.Drawing.Point(15, 24);
            this.pnlChoixAction.Name = "pnlChoixAction";
            this.pnlChoixAction.Size = new System.Drawing.Size(213, 92);
            this.pnlChoixAction.TabIndex = 5;
            // 
            // lblChoixAction
            // 
            this.lblChoixAction.AutoSize = true;
            this.lblChoixAction.Location = new System.Drawing.Point(3, 6);
            this.lblChoixAction.Name = "lblChoixAction";
            this.lblChoixAction.Size = new System.Drawing.Size(212, 13);
            this.lblChoixAction.TabIndex = 6;
            this.lblChoixAction.Text = "Choisisser une action a modifier ou suprimer";
            // 
            // lblNomNouvAction
            // 
            this.lblNomNouvAction.AutoSize = true;
            this.lblNomNouvAction.Location = new System.Drawing.Point(3, 53);
            this.lblNomNouvAction.Name = "lblNomNouvAction";
            this.lblNomNouvAction.Size = new System.Drawing.Size(176, 13);
            this.lblNomNouvAction.TabIndex = 2;
            this.lblNomNouvAction.Text = "Choisisser le nom d\'action souhaitez";
            // 
            // txtModifAction
            // 
            this.txtModifAction.Location = new System.Drawing.Point(3, 69);
            this.txtModifAction.Name = "txtModifAction";
            this.txtModifAction.Size = new System.Drawing.Size(206, 20);
            this.txtModifAction.TabIndex = 1;
            // 
            // cbxChoixAction
            // 
            this.cbxChoixAction.FormattingEnabled = true;
            this.cbxChoixAction.Location = new System.Drawing.Point(3, 22);
            this.cbxChoixAction.Name = "cbxChoixAction";
            this.cbxChoixAction.Size = new System.Drawing.Size(207, 21);
            this.cbxChoixAction.TabIndex = 0;
            this.cbxChoixAction.SelectionChangeCommitted += new System.EventHandler(this.cbxChoixAction_SelectionChangeCommitted);
            // 
            // lblNomActionModif
            // 
            this.lblNomActionModif.AutoSize = true;
            this.lblNomActionModif.Location = new System.Drawing.Point(3, 53);
            this.lblNomActionModif.Name = "lblNomActionModif";
            this.lblNomActionModif.Size = new System.Drawing.Size(170, 13);
            this.lblNomActionModif.TabIndex = 6;
            this.lblNomActionModif.Text = "Ecriver le nouveau nom de l\'action";
            this.lblNomActionModif.Visible = false;
            // 
            // FormMenuAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 176);
            this.Controls.Add(this.pnlChoixAction);
            this.Controls.Add(this.pnlModifSupr);
            this.Name = "FormMenuAction";
            this.Text = "Gestion des action";
            this.Load += new System.EventHandler(this.FormMenuAction_Load);
            this.pnlCrea.ResumeLayout(false);
            this.pnlModifSupr.ResumeLayout(false);
            this.pnlChoixAction.ResumeLayout(false);
            this.pnlChoixAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.Button btnSupression;
        private System.Windows.Forms.Panel pnlCrea;
        private System.Windows.Forms.Panel pnlModifSupr;
        private System.Windows.Forms.Panel pnlChoixAction;
        private System.Windows.Forms.TextBox txtModifAction;
        private System.Windows.Forms.ComboBox cbxChoixAction;
        private System.Windows.Forms.Label lblNomNouvAction;
        private System.Windows.Forms.Label lblChoixAction;
        private System.Windows.Forms.Label lblNomActionModif;
    }
}

