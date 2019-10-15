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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAjouterUtilisateur = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblService = new System.Windows.Forms.Label();
            this.cbxService = new System.Windows.Forms.ComboBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblProfilUtilisateur = new System.Windows.Forms.Label();
            this.cbxProfilUtilisateur = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.pnlAjouterUtilisateur.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUtilisateurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.pnlAjouterUtilisateur.Location = new System.Drawing.Point(36, 54);
            this.pnlAjouterUtilisateur.Name = "pnlAjouterUtilisateur";
            this.pnlAjouterUtilisateur.Size = new System.Drawing.Size(300, 237);
            this.pnlAjouterUtilisateur.TabIndex = 1;
            this.pnlAjouterUtilisateur.Visible = false;
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
            this.btnEnregistrer.Location = new System.Drawing.Point(110, 159);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(107, 79);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "Service :";
            // 
            // cbxService
            // 
            this.cbxService.FormattingEnabled = true;
            this.cbxService.Location = new System.Drawing.Point(162, 76);
            this.cbxService.Name = "cbxService";
            this.cbxService.Size = new System.Drawing.Size(121, 21);
            this.cbxService.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(164, 41);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(164, 12);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(10, 44);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(146, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom du nouvel utilisateur :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(24, 15);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(132, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom du nouvel utilisateur :";
            // 
            // lblProfilUtilisateur
            // 
            this.lblProfilUtilisateur.AutoSize = true;
            this.lblProfilUtilisateur.Location = new System.Drawing.Point(54, 121);
            this.lblProfilUtilisateur.Name = "lblProfilUtilisateur";
            this.lblProfilUtilisateur.Size = new System.Drawing.Size(102, 13);
            this.lblProfilUtilisateur.TabIndex = 8;
            this.lblProfilUtilisateur.Text = "Profil de l\'utilisateur :";
            // 
            // cbxProfilUtilisateur
            // 
            this.cbxProfilUtilisateur.FormattingEnabled = true;
            this.cbxProfilUtilisateur.Location = new System.Drawing.Point(162, 118);
            this.cbxProfilUtilisateur.Name = "cbxProfilUtilisateur";
            this.cbxProfilUtilisateur.Size = new System.Drawing.Size(121, 21);
            this.cbxProfilUtilisateur.TabIndex = 9;
            // 
            // FormGesUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlAjouterUtilisateur);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGesUtilisateur";
            this.Text = "FormGesUtilisateur";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAjouterUtilisateur.ResumeLayout(false);
            this.pnlAjouterUtilisateur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
    }
}