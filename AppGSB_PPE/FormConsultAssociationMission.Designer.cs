namespace AppGSB_PPE
{
    partial class FormConsultAssociationMission
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
            this.dtgConsultAssociation = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAssociation = new System.Windows.Forms.Button();
            this.btnMissions = new System.Windows.Forms.Button();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.cbxPays = new System.Windows.Forms.ComboBox();
            this.dtgConsultMissions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultAssociation)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultMissions)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultAssociation
            // 
            this.dtgConsultAssociation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultAssociation.Location = new System.Drawing.Point(12, 157);
            this.dtgConsultAssociation.Name = "dtgConsultAssociation";
            this.dtgConsultAssociation.ReadOnly = true;
            this.dtgConsultAssociation.Size = new System.Drawing.Size(776, 281);
            this.dtgConsultAssociation.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxPays);
            this.panel1.Controls.Add(this.lblRecherche);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAssociation);
            this.panel1.Controls.Add(this.btnMissions);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 132);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Affichage des données";
            // 
            // btnAssociation
            // 
            this.btnAssociation.Location = new System.Drawing.Point(392, 37);
            this.btnAssociation.Name = "btnAssociation";
            this.btnAssociation.Size = new System.Drawing.Size(124, 42);
            this.btnAssociation.TabIndex = 1;
            this.btnAssociation.Text = "Associations";
            this.btnAssociation.UseVisualStyleBackColor = true;
            this.btnAssociation.Click += new System.EventHandler(this.btnAssociation_Click);
            // 
            // btnMissions
            // 
            this.btnMissions.Location = new System.Drawing.Point(262, 37);
            this.btnMissions.Name = "btnMissions";
            this.btnMissions.Size = new System.Drawing.Size(124, 42);
            this.btnMissions.TabIndex = 0;
            this.btnMissions.Text = "Missions";
            this.btnMissions.UseVisualStyleBackColor = true;
            this.btnMissions.Click += new System.EventHandler(this.btnMissions_Click);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(271, 101);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(106, 13);
            this.lblRecherche.TabIndex = 4;
            this.lblRecherche.Text = "Rechercher par pays";
            this.lblRecherche.Visible = false;
            // 
            // cbxPays
            // 
            this.cbxPays.FormattingEnabled = true;
            this.cbxPays.Location = new System.Drawing.Point(381, 98);
            this.cbxPays.Name = "cbxPays";
            this.cbxPays.Size = new System.Drawing.Size(121, 21);
            this.cbxPays.TabIndex = 6;
            this.cbxPays.Visible = false;
            this.cbxPays.SelectedIndexChanged += new System.EventHandler(this.cbxPays_SelectedIndexChanged);
            // 
            // dtgConsultMissions
            // 
            this.dtgConsultMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultMissions.Location = new System.Drawing.Point(12, 157);
            this.dtgConsultMissions.Name = "dtgConsultMissions";
            this.dtgConsultMissions.Size = new System.Drawing.Size(776, 281);
            this.dtgConsultMissions.TabIndex = 3;
            // 
            // FormConsultAssociationMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgConsultMissions);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgConsultAssociation);
            this.Name = "FormConsultAssociationMission";
            this.Text = "FormConsultAssociation";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultAssociation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultMissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultAssociation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAssociation;
        private System.Windows.Forms.Button btnMissions;
        private System.Windows.Forms.ComboBox cbxPays;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.DataGridView dtgConsultMissions;
    }
}