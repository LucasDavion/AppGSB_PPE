﻿namespace AppGSB_PPE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuAction));
            this.btnCreation = new System.Windows.Forms.Button();
            this.btnModification = new System.Windows.Forms.Button();
            this.btnSupression = new System.Windows.Forms.Button();
            this.pnlCrea = new System.Windows.Forms.Panel();
            this.pnlModifSupr = new System.Windows.Forms.Panel();
            this.pnlChoixAction = new System.Windows.Forms.Panel();
            this.lblNomActionModif = new System.Windows.Forms.Label();
            this.lblChoixAction = new System.Windows.Forms.Label();
            this.lblNomNouvAction = new System.Windows.Forms.Label();
            this.txtModifAction = new System.Windows.Forms.TextBox();
            this.cbxChoixAction = new System.Windows.Forms.ComboBox();
            this.dtgConsultAction = new System.Windows.Forms.DataGridView();
            this.pnlCrea.SuspendLayout();
            this.pnlModifSupr.SuspendLayout();
            this.pnlChoixAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultAction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(3, 3);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(211, 114);
            this.btnCreation.TabIndex = 0;
            this.btnCreation.Text = "Creation d\'une nouvelle action";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(3, 3);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(101, 114);
            this.btnModification.TabIndex = 1;
            this.btnModification.Text = "Modification";
            this.btnModification.UseVisualStyleBackColor = true;
            // 
            // btnSupression
            // 
            this.btnSupression.Location = new System.Drawing.Point(113, 3);
            this.btnSupression.Name = "btnSupression";
            this.btnSupression.Size = new System.Drawing.Size(101, 114);
            this.btnSupression.TabIndex = 2;
            this.btnSupression.Text = "Supression";
            this.btnSupression.UseVisualStyleBackColor = true;
            // 
            // pnlCrea
            // 
            this.pnlCrea.Controls.Add(this.btnCreation);
            this.pnlCrea.Location = new System.Drawing.Point(12, 136);
            this.pnlCrea.Name = "pnlCrea";
            this.pnlCrea.Size = new System.Drawing.Size(217, 120);
            this.pnlCrea.TabIndex = 3;
            // 
            // pnlModifSupr
            // 
            this.pnlModifSupr.Controls.Add(this.btnModification);
            this.pnlModifSupr.Controls.Add(this.btnSupression);
            this.pnlModifSupr.Location = new System.Drawing.Point(12, 136);
            this.pnlModifSupr.Name = "pnlModifSupr";
            this.pnlModifSupr.Size = new System.Drawing.Size(217, 120);
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
            this.pnlChoixAction.Location = new System.Drawing.Point(12, 12);
            this.pnlChoixAction.Name = "pnlChoixAction";
            this.pnlChoixAction.Size = new System.Drawing.Size(217, 118);
            this.pnlChoixAction.TabIndex = 5;
            // 
            // lblNomActionModif
            // 
            this.lblNomActionModif.AutoSize = true;
            this.lblNomActionModif.Location = new System.Drawing.Point(3, 66);
            this.lblNomActionModif.Name = "lblNomActionModif";
            this.lblNomActionModif.Size = new System.Drawing.Size(170, 13);
            this.lblNomActionModif.TabIndex = 6;
            this.lblNomActionModif.Text = "Ecriver le nouveau nom de l\'action";
            this.lblNomActionModif.Visible = false;
            // 
            // lblChoixAction
            // 
            this.lblChoixAction.AutoSize = true;
            this.lblChoixAction.Location = new System.Drawing.Point(2, 10);
            this.lblChoixAction.Name = "lblChoixAction";
            this.lblChoixAction.Size = new System.Drawing.Size(212, 13);
            this.lblChoixAction.TabIndex = 6;
            this.lblChoixAction.Text = "Choisisser une action a modifier ou suprimer";
            // 
            // lblNomNouvAction
            // 
            this.lblNomNouvAction.AutoSize = true;
            this.lblNomNouvAction.Location = new System.Drawing.Point(3, 66);
            this.lblNomNouvAction.Name = "lblNomNouvAction";
            this.lblNomNouvAction.Size = new System.Drawing.Size(164, 13);
            this.lblNomNouvAction.TabIndex = 2;
            this.lblNomNouvAction.Text = "Choisisser le nom d\'action a creer";
            // 
            // txtModifAction
            // 
            this.txtModifAction.Location = new System.Drawing.Point(3, 82);
            this.txtModifAction.Name = "txtModifAction";
            this.txtModifAction.Size = new System.Drawing.Size(211, 20);
            this.txtModifAction.TabIndex = 1;
            // 
            // cbxChoixAction
            // 
            this.cbxChoixAction.FormattingEnabled = true;
            this.cbxChoixAction.Location = new System.Drawing.Point(3, 26);
            this.cbxChoixAction.Name = "cbxChoixAction";
            this.cbxChoixAction.Size = new System.Drawing.Size(211, 21);
            this.cbxChoixAction.TabIndex = 0;
            this.cbxChoixAction.SelectionChangeCommitted += new System.EventHandler(this.cbxChoixAction_SelectionChangeCommitted);
            // 
            // dtgConsultAction
            // 
            this.dtgConsultAction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgConsultAction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgConsultAction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultAction.Location = new System.Drawing.Point(235, 22);
            this.dtgConsultAction.Name = "dtgConsultAction";
            this.dtgConsultAction.ReadOnly = true;
            this.dtgConsultAction.Size = new System.Drawing.Size(256, 231);
            this.dtgConsultAction.TabIndex = 6;
            // 
            // FormMenuAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 268);
            this.Controls.Add(this.pnlModifSupr);
            this.Controls.Add(this.dtgConsultAction);
            this.Controls.Add(this.pnlChoixAction);
            this.Controls.Add(this.pnlCrea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenuAction";
            this.Text = "Gestion des action";
            this.Load += new System.EventHandler(this.FormMenuAction_Load);
            this.pnlCrea.ResumeLayout(false);
            this.pnlModifSupr.ResumeLayout(false);
            this.pnlChoixAction.ResumeLayout(false);
            this.pnlChoixAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultAction)).EndInit();
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
        private System.Windows.Forms.Label lblNomNouvAction;
        private System.Windows.Forms.Label lblChoixAction;
        private System.Windows.Forms.Label lblNomActionModif;
        private System.Windows.Forms.DataGridView dtgConsultAction;
        private System.Windows.Forms.ComboBox cbxChoixAction;
    }
}

