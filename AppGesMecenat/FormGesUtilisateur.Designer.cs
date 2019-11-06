namespace AppGesMecenat
{
    partial class FormGesUtilisateur
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
            this.mnuGesUtilisateur = new System.Windows.Forms.MenuStrip();
            this.ajouterUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAjouterUtilisateur = new System.Windows.Forms.Panel();
            this.cbxProfilUtilisateur = new System.Windows.Forms.ComboBox();
            this.lblProfilUtilisateur = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.cbxService = new System.Windows.Forms.ComboBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.dtgGesUtilisateur = new System.Windows.Forms.DataGridView();
            this.lblTitreConsult = new System.Windows.Forms.Label();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.mnuGesUtilisateur.SuspendLayout();
            this.pnlAjouterUtilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGesUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuGesUtilisateur
            // 
            this.mnuGesUtilisateur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUtilisateurToolStripMenuItem});
            this.mnuGesUtilisateur.Location = new System.Drawing.Point(0, 0);
            this.mnuGesUtilisateur.Name = "mnuGesUtilisateur";
            this.mnuGesUtilisateur.Size = new System.Drawing.Size(800, 24);
            this.mnuGesUtilisateur.TabIndex = 0;
            this.mnuGesUtilisateur.Text = "menuStrip1";
            // 
            // ajouterUtilisateurToolStripMenuItem
            // 
            this.ajouterUtilisateurToolStripMenuItem.Name = "ajouterUtilisateurToolStripMenuItem";
            this.ajouterUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.ajouterUtilisateurToolStripMenuItem.Text = "Ajouter un utilisateur";
            this.ajouterUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUtilisateurToolStripMenuItem_Click);
            // 
            // pnlAjouterUtilisateur
            // 
            this.pnlAjouterUtilisateur.Controls.Add(this.cbxProfilUtilisateur);
            this.pnlAjouterUtilisateur.Controls.Add(this.lblProfilUtilisateur);
            this.pnlAjouterUtilisateur.Controls.Add(this.lblMsg);
            this.pnlAjouterUtilisateur.Controls.Add(this.btnEnregistrer);
            this.pnlAjouterUtilisateur.Controls.Add(this.lblService);
            this.pnlAjouterUtilisateur.Controls.Add(this.cbxService);
            this.pnlAjouterUtilisateur.Controls.Add(this.txtPrenom);
            this.pnlAjouterUtilisateur.Controls.Add(this.txtNom);
            this.pnlAjouterUtilisateur.Controls.Add(this.lblPrenom);
            this.pnlAjouterUtilisateur.Controls.Add(this.lblNom);
            this.pnlAjouterUtilisateur.Location = new System.Drawing.Point(12, 54);
            this.pnlAjouterUtilisateur.Name = "pnlAjouterUtilisateur";
            this.pnlAjouterUtilisateur.Size = new System.Drawing.Size(300, 157);
            this.pnlAjouterUtilisateur.TabIndex = 1;
            this.pnlAjouterUtilisateur.Visible = false;
            // 
            // cbxProfilUtilisateur
            // 
            this.cbxProfilUtilisateur.FormattingEnabled = true;
            this.cbxProfilUtilisateur.Location = new System.Drawing.Point(176, 91);
            this.cbxProfilUtilisateur.Name = "cbxProfilUtilisateur";
            this.cbxProfilUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.cbxProfilUtilisateur.TabIndex = 9;
            // 
            // lblProfilUtilisateur
            // 
            this.lblProfilUtilisateur.AutoSize = true;
            this.lblProfilUtilisateur.Location = new System.Drawing.Point(68, 94);
            this.lblProfilUtilisateur.Name = "lblProfilUtilisateur";
            this.lblProfilUtilisateur.Size = new System.Drawing.Size(102, 13);
            this.lblProfilUtilisateur.TabIndex = 8;
            this.lblProfilUtilisateur.Text = "Profil de l\'utilisateur :";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(78, 198);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 7;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(3, 118);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(294, 36);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(121, 67);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Service :";
            // 
            // cbxService
            // 
            this.cbxService.FormattingEnabled = true;
            this.cbxService.Location = new System.Drawing.Point(176, 64);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(121, 21);
            this.cbxService.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(176, 38);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(121, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(176, 12);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(121, 20);
            this.txtNom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(24, 41);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(146, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom du nouvel utilisateur :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(38, 15);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(132, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom du nouvel utilisateur :";
            // 
            // dtgGesUtilisateur
            // 
            this.dtgGesUtilisateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgGesUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGesUtilisateur.Location = new System.Drawing.Point(318, 70);
            this.dtgGesUtilisateur.Name = "dtgGesUtilisateur";
            this.dtgGesUtilisateur.Size = new System.Drawing.Size(470, 249);
            this.dtgGesUtilisateur.TabIndex = 2;
            // 
            // lblTitreConsult
            // 
            this.lblTitreConsult.AutoSize = true;
            this.lblTitreConsult.Location = new System.Drawing.Point(318, 54);
            this.lblTitreConsult.Name = "lblTitreConsult";
            this.lblTitreConsult.Size = new System.Drawing.Size(137, 13);
            this.lblTitreConsult.TabIndex = 3;
            this.lblTitreConsult.Text = "Consultation des utilisateurs";
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(519, 325);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(75, 23);
            this.btnActualiser.TabIndex = 4;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // FormGesUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.lblTitreConsult);
            this.Controls.Add(this.dtgGesUtilisateur);
            this.Controls.Add(this.pnlAjouterUtilisateur);
            this.Controls.Add(this.mnuGesUtilisateur);
            this.MainMenuStrip = this.mnuGesUtilisateur;
            this.Name = "FormGesUtilisateur";
            this.Text = "Gestion Utilisateur";
            this.mnuGesUtilisateur.ResumeLayout(false);
            this.mnuGesUtilisateur.PerformLayout();
            this.pnlAjouterUtilisateur.ResumeLayout(false);
            this.pnlAjouterUtilisateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGesUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuGesUtilisateur;
        private System.Windows.Forms.ToolStripMenuItem ajouterUtilisateurToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAjouterUtilisateur;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cbxService;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.ComboBox cbxProfilUtilisateur;
        private System.Windows.Forms.Label lblProfilUtilisateur;
        private System.Windows.Forms.DataGridView dtgGesUtilisateur;
        private System.Windows.Forms.Label lblTitreConsult;
        private System.Windows.Forms.Button btnActualiser;
    }
}