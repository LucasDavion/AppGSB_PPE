﻿namespace AppGSB_PPE
{
    partial class FormChoixPays
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChoixPays));
            this.lblPays = new System.Windows.Forms.Label();
            this.pnlChoixPays = new System.Windows.Forms.Panel();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxChoixPays = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.dtgConsultPays = new System.Windows.Forms.DataGridView();
            this.btnConsultPays = new System.Windows.Forms.Button();
            this.pnlChoixPays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultPays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(22, 31);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(30, 13);
            this.lblPays.TabIndex = 0;
            this.lblPays.Text = "Pays";
            // 
            // pnlChoixPays
            // 
            this.pnlChoixPays.Controls.Add(this.txtAnnee);
            this.pnlChoixPays.Controls.Add(this.label1);
            this.pnlChoixPays.Controls.Add(this.cbxChoixPays);
            this.pnlChoixPays.Controls.Add(this.btnValider);
            this.pnlChoixPays.Controls.Add(this.lblPays);
            this.pnlChoixPays.Location = new System.Drawing.Point(12, 12);
            this.pnlChoixPays.Name = "pnlChoixPays";
            this.pnlChoixPays.Size = new System.Drawing.Size(200, 149);
            this.pnlChoixPays.TabIndex = 1;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Location = new System.Drawing.Point(70, 72);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(93, 20);
            this.txtAnnee.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Année";
            // 
            // cbxChoixPays
            // 
            this.cbxChoixPays.FormattingEnabled = true;
            this.cbxChoixPays.Location = new System.Drawing.Point(59, 31);
            this.cbxChoixPays.Name = "cbxChoixPays";
            this.cbxChoixPays.Size = new System.Drawing.Size(121, 21);
            this.cbxChoixPays.TabIndex = 2;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(59, 106);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // dtgConsultPays
            // 
            this.dtgConsultPays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultPays.Location = new System.Drawing.Point(319, 12);
            this.dtgConsultPays.Name = "dtgConsultPays";
            this.dtgConsultPays.Size = new System.Drawing.Size(240, 150);
            this.dtgConsultPays.TabIndex = 2;
            // 
            // btnConsultPays
            // 
            this.btnConsultPays.Location = new System.Drawing.Point(229, 79);
            this.btnConsultPays.Name = "btnConsultPays";
            this.btnConsultPays.Size = new System.Drawing.Size(75, 23);
            this.btnConsultPays.TabIndex = 3;
            this.btnConsultPays.Text = "Consultation";
            this.btnConsultPays.UseVisualStyleBackColor = true;
            this.btnConsultPays.Click += new System.EventHandler(this.btnConsultPays_Click);
            // 
            // FormChoixPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 185);
            this.Controls.Add(this.btnConsultPays);
            this.Controls.Add(this.dtgConsultPays);
            this.Controls.Add(this.pnlChoixPays);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChoixPays";
            this.Text = "FormChoixPays";
            this.pnlChoixPays.ResumeLayout(false);
            this.pnlChoixPays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultPays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Panel pnlChoixPays;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.ComboBox cbxChoixPays;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgConsultPays;
        private System.Windows.Forms.Button btnConsultPays;
    }
}