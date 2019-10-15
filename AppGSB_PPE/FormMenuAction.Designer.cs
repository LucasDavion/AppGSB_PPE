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
            this.lblNomAction = new System.Windows.Forms.Label();
            this.txtModifAction = new System.Windows.Forms.TextBox();
            this.cbxChoixAction = new System.Windows.Forms.ComboBox();
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
            this.pnlCrea.Location = new System.Drawing.Point(231, 122);
            this.pnlCrea.Name = "pnlCrea";
            this.pnlCrea.Size = new System.Drawing.Size(213, 39);
            this.pnlCrea.TabIndex = 3;
            // 
            // pnlModifSupr
            // 
            this.pnlModifSupr.Controls.Add(this.btnModification);
            this.pnlModifSupr.Controls.Add(this.btnSupression);
            this.pnlModifSupr.Location = new System.Drawing.Point(12, 122);
            this.pnlModifSupr.Name = "pnlModifSupr";
            this.pnlModifSupr.Size = new System.Drawing.Size(213, 39);
            this.pnlModifSupr.TabIndex = 4;
            this.pnlModifSupr.Visible = false;
            // 
            // pnlChoixAction
            // 
            this.pnlChoixAction.Controls.Add(this.lblNomAction);
            this.pnlChoixAction.Controls.Add(this.txtModifAction);
            this.pnlChoixAction.Controls.Add(this.cbxChoixAction);
            this.pnlChoixAction.Location = new System.Drawing.Point(12, 12);
            this.pnlChoixAction.Name = "pnlChoixAction";
            this.pnlChoixAction.Size = new System.Drawing.Size(213, 74);
            this.pnlChoixAction.TabIndex = 5;
            // 
            // lblNomAction
            // 
            this.lblNomAction.AutoSize = true;
            this.lblNomAction.Location = new System.Drawing.Point(3, 35);
            this.lblNomAction.Name = "lblNomAction";
            this.lblNomAction.Size = new System.Drawing.Size(160, 13);
            this.lblNomAction.TabIndex = 2;
            this.lblNomAction.Text = "Choisir le nom d\'action souhaitez";
            // 
            // txtModifAction
            // 
            this.txtModifAction.Location = new System.Drawing.Point(3, 51);
            this.txtModifAction.Name = "txtModifAction";
            this.txtModifAction.Size = new System.Drawing.Size(206, 20);
            this.txtModifAction.TabIndex = 1;
            // 
            // cbxChoixAction
            // 
            this.cbxChoixAction.FormattingEnabled = true;
            this.cbxChoixAction.Location = new System.Drawing.Point(3, 4);
            this.cbxChoixAction.Name = "cbxChoixAction";
            this.cbxChoixAction.Size = new System.Drawing.Size(207, 21);
            this.cbxChoixAction.TabIndex = 0;
            this.cbxChoixAction.SelectionChangeCommitted += new System.EventHandler(this.cbxChoixAction_SelectionChangeCommitted);
            // 
            // FormMenuAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 176);
            this.Controls.Add(this.pnlChoixAction);
            this.Controls.Add(this.pnlModifSupr);
            this.Controls.Add(this.pnlCrea);
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
        private System.Windows.Forms.Label lblNomAction;
    }
}

