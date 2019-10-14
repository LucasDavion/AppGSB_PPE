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
            this.cbxCreation = new System.Windows.Forms.CheckBox();
            this.txtModifAction = new System.Windows.Forms.TextBox();
            this.cbxChoixAction = new System.Windows.Forms.ComboBox();
            this.pnlCrea.SuspendLayout();
            this.pnlModifSupr.SuspendLayout();
            this.pnlChoixAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(3, 38);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(207, 33);
            this.btnCreation.TabIndex = 0;
            this.btnCreation.Text = "Creation";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(3, 38);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(101, 33);
            this.btnModification.TabIndex = 1;
            this.btnModification.Text = "Modification";
            this.btnModification.UseVisualStyleBackColor = true;
            // 
            // btnSupression
            // 
            this.btnSupression.Location = new System.Drawing.Point(106, 38);
            this.btnSupression.Name = "btnSupression";
            this.btnSupression.Size = new System.Drawing.Size(101, 33);
            this.btnSupression.TabIndex = 2;
            this.btnSupression.Text = "Supression";
            this.btnSupression.UseVisualStyleBackColor = true;
            // 
            // pnlCrea
            // 
            this.pnlCrea.Controls.Add(this.btnCreation);
            this.pnlCrea.Location = new System.Drawing.Point(12, 92);
            this.pnlCrea.Name = "pnlCrea";
            this.pnlCrea.Size = new System.Drawing.Size(213, 74);
            this.pnlCrea.TabIndex = 3;
            // 
            // pnlModifSupr
            // 
            this.pnlModifSupr.Controls.Add(this.btnModification);
            this.pnlModifSupr.Controls.Add(this.btnSupression);
            this.pnlModifSupr.Location = new System.Drawing.Point(12, 92);
            this.pnlModifSupr.Name = "pnlModifSupr";
            this.pnlModifSupr.Size = new System.Drawing.Size(213, 74);
            this.pnlModifSupr.TabIndex = 4;
            this.pnlModifSupr.Visible = false;
            // 
            // pnlChoixAction
            // 
            this.pnlChoixAction.Controls.Add(this.cbxCreation);
            this.pnlChoixAction.Controls.Add(this.txtModifAction);
            this.pnlChoixAction.Controls.Add(this.cbxChoixAction);
            this.pnlChoixAction.Location = new System.Drawing.Point(12, 12);
            this.pnlChoixAction.Name = "pnlChoixAction";
            this.pnlChoixAction.Size = new System.Drawing.Size(213, 74);
            this.pnlChoixAction.TabIndex = 5;
            // 
            // cbxCreation
            // 
            this.cbxCreation.AutoSize = true;
            this.cbxCreation.Location = new System.Drawing.Point(110, 35);
            this.cbxCreation.Name = "cbxCreation";
            this.cbxCreation.Size = new System.Drawing.Size(100, 17);
            this.cbxCreation.TabIndex = 2;
            this.cbxCreation.Text = "cree une action";
            this.cbxCreation.UseVisualStyleBackColor = true;
            this.cbxCreation.CheckedChanged += new System.EventHandler(this.cbxCreation_CheckedChanged);
            // 
            // txtModifAction
            // 
            this.txtModifAction.Enabled = false;
            this.txtModifAction.Location = new System.Drawing.Point(4, 32);
            this.txtModifAction.Name = "txtModifAction";
            this.txtModifAction.Size = new System.Drawing.Size(100, 20);
            this.txtModifAction.TabIndex = 1;
            // 
            // cbxChoixAction
            // 
            this.cbxChoixAction.FormattingEnabled = true;
            this.cbxChoixAction.Location = new System.Drawing.Point(3, 4);
            this.cbxChoixAction.Name = "cbxChoixAction";
            this.cbxChoixAction.Size = new System.Drawing.Size(207, 21);
            this.cbxChoixAction.TabIndex = 0;
            this.cbxChoixAction.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormMenuAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 176);
            this.Controls.Add(this.pnlChoixAction);
            this.Controls.Add(this.pnlModifSupr);
            this.Controls.Add(this.pnlCrea);
            this.Name = "FormMenuAction";
            this.Text = "Gestion des action";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.CheckBox cbxCreation;
        private System.Windows.Forms.TextBox txtModifAction;
        private System.Windows.Forms.ComboBox cbxChoixAction;
    }
}

