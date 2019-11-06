namespace AppGSB_PPE
{
    partial class FormAjoutAssociation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAjoutAssociation));
            this.lblNomAsso = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.txtAsso = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNomResponsable = new System.Windows.Forms.TextBox();
            this.lblNomResponsable = new System.Windows.Forms.Label();
            this.cbxPays = new System.Windows.Forms.ComboBox();
            this.cbxMission = new System.Windows.Forms.ComboBox();
            this.lblPays = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomAsso
            // 
            this.lblNomAsso.AutoSize = true;
            this.lblNomAsso.Location = new System.Drawing.Point(21, 35);
            this.lblNomAsso.Name = "lblNomAsso";
            this.lblNomAsso.Size = new System.Drawing.Size(110, 13);
            this.lblNomAsso.TabIndex = 0;
            this.lblNomAsso.Text = "Nom de l\'association :";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(83, 75);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(48, 13);
            this.lblMission.TabIndex = 1;
            this.lblMission.Text = "Mission :";
            // 
            // txtAsso
            // 
            this.txtAsso.Location = new System.Drawing.Point(137, 32);
            this.txtAsso.Name = "txtAsso";
            this.txtAsso.Size = new System.Drawing.Size(161, 20);
            this.txtAsso.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(223, 191);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPays);
            this.panel1.Controls.Add(this.txtNomResponsable);
            this.panel1.Controls.Add(this.lblNomResponsable);
            this.panel1.Controls.Add(this.cbxPays);
            this.panel1.Controls.Add(this.cbxMission);
            this.panel1.Controls.Add(this.txtAsso);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.lblNomAsso);
            this.panel1.Controls.Add(this.lblMission);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 233);
            this.panel1.TabIndex = 5;
            // 
            // txtNomResponsable
            // 
            this.txtNomResponsable.Location = new System.Drawing.Point(137, 116);
            this.txtNomResponsable.Name = "txtNomResponsable";
            this.txtNomResponsable.Size = new System.Drawing.Size(161, 20);
            this.txtNomResponsable.TabIndex = 8;
            // 
            // lblNomResponsable
            // 
            this.lblNomResponsable.AutoSize = true;
            this.lblNomResponsable.Location = new System.Drawing.Point(36, 119);
            this.lblNomResponsable.Name = "lblNomResponsable";
            this.lblNomResponsable.Size = new System.Drawing.Size(95, 13);
            this.lblNomResponsable.TabIndex = 7;
            this.lblNomResponsable.Text = "Nom responsable :";
            // 
            // cbxPays
            // 
            this.cbxPays.FormattingEnabled = true;
            this.cbxPays.Location = new System.Drawing.Point(137, 151);
            this.cbxPays.Name = "cbxPays";
            this.cbxPays.Size = new System.Drawing.Size(161, 21);
            this.cbxPays.TabIndex = 6;
            // 
            // cbxMission
            // 
            this.cbxMission.FormattingEnabled = true;
            this.cbxMission.Location = new System.Drawing.Point(137, 75);
            this.cbxMission.Name = "cbxMission";
            this.cbxMission.Size = new System.Drawing.Size(161, 21);
            this.cbxMission.TabIndex = 5;
            // 
            // lblPays
            // 
            this.lblPays.AutoSize = true;
            this.lblPays.Location = new System.Drawing.Point(95, 154);
            this.lblPays.Name = "lblPays";
            this.lblPays.Size = new System.Drawing.Size(36, 13);
            this.lblPays.TabIndex = 9;
            this.lblPays.Text = "Pays :";
            this.lblPays.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAjoutAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 258);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAjoutAssociation";
            this.Text = "FormAjoutAssociation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomAsso;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.TextBox txtAsso;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbxMission;
        private System.Windows.Forms.TextBox txtNomResponsable;
        private System.Windows.Forms.Label lblNomResponsable;
        private System.Windows.Forms.ComboBox cbxPays;
        private System.Windows.Forms.Label lblPays;
    }
}