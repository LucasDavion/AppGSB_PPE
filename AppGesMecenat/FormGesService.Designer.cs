namespace AppGesMecenat
{
    partial class FormGesService
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
            this.mnuGesService = new System.Windows.Forms.MenuStrip();
            this.ajouterServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsg = new System.Windows.Forms.Label();
            this.mnuGesService.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuGesService
            // 
            this.mnuGesService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterServiceToolStripMenuItem});
            this.mnuGesService.Location = new System.Drawing.Point(0, 0);
            this.mnuGesService.Name = "mnuGesService";
            this.mnuGesService.Size = new System.Drawing.Size(800, 24);
            this.mnuGesService.TabIndex = 0;
            this.mnuGesService.Text = "menuStrip1";
            // 
            // ajouterServiceToolStripMenuItem
            // 
            this.ajouterServiceToolStripMenuItem.Name = "ajouterServiceToolStripMenuItem";
            this.ajouterServiceToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.ajouterServiceToolStripMenuItem.Text = "Ajouter un service";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(3, 21);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(95, 13);
            this.lblLibelle.TabIndex = 1;
            this.lblLibelle.Text = "Libelle du service :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(104, 18);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(100, 20);
            this.txtLibelle.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(6, 44);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(198, 33);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.lblLibelle);
            this.panel1.Controls.Add(this.txtLibelle);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 83);
            this.panel1.TabIndex = 4;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(364, 383);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 13);
            this.lblMsg.TabIndex = 5;
            // 
            // FormGesService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuGesService);
            this.MainMenuStrip = this.mnuGesService;
            this.Name = "FormGesService";
            this.Text = "FormGesService";
            this.mnuGesService.ResumeLayout(false);
            this.mnuGesService.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuGesService;
        private System.Windows.Forms.ToolStripMenuItem ajouterServiceToolStripMenuItem;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMsg;
    }
}