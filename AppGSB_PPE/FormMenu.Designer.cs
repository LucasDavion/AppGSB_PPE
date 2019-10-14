namespace AppGSB_PPE
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.choixDesPaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneAssociationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneMissionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesAssociationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choixDesPaysToolStripMenuItem,
            this.ajouterUneMissionToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // choixDesPaysToolStripMenuItem
            // 
            this.choixDesPaysToolStripMenuItem.Name = "choixDesPaysToolStripMenuItem";
            this.choixDesPaysToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.choixDesPaysToolStripMenuItem.Text = "Choix des pays";
            this.choixDesPaysToolStripMenuItem.Click += new System.EventHandler(this.choixDesPaysToolStripMenuItem_Click);
            // 
            // ajouterUneMissionToolStripMenuItem
            // 
            this.ajouterUneMissionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneAssociationToolStripMenuItem1,
            this.ajouterUneMissionToolStripMenuItem1,
            this.consulterLesAssociationToolStripMenuItem});
            this.ajouterUneMissionToolStripMenuItem.Name = "ajouterUneMissionToolStripMenuItem";
            this.ajouterUneMissionToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.ajouterUneMissionToolStripMenuItem.Text = "Associations";
            // 
            // ajouterUneAssociationToolStripMenuItem1
            // 
            this.ajouterUneAssociationToolStripMenuItem1.Name = "ajouterUneAssociationToolStripMenuItem1";
            this.ajouterUneAssociationToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.ajouterUneAssociationToolStripMenuItem1.Text = "Ajouter une association";
            this.ajouterUneAssociationToolStripMenuItem1.Click += new System.EventHandler(this.ajouterUneAssociationToolStripMenuItem1_Click);
            // 
            // ajouterUneMissionToolStripMenuItem1
            // 
            this.ajouterUneMissionToolStripMenuItem1.Name = "ajouterUneMissionToolStripMenuItem1";
            this.ajouterUneMissionToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.ajouterUneMissionToolStripMenuItem1.Text = "Ajouter une mission";
            this.ajouterUneMissionToolStripMenuItem1.Click += new System.EventHandler(this.ajouterUneMissionToolStripMenuItem1_Click);
            // 
            // consulterLesAssociationToolStripMenuItem
            // 
            this.consulterLesAssociationToolStripMenuItem.Name = "consulterLesAssociationToolStripMenuItem";
            this.consulterLesAssociationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.consulterLesAssociationToolStripMenuItem.Text = "Consulter les association";
            this.consulterLesAssociationToolStripMenuItem.Click += new System.EventHandler(this.consulterLesAssociationToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 245);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            this.actionToolStripMenuItem.Click += new System.EventHandler(this.actionToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Gestion Mecenat";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem choixDesPaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneMissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneAssociationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneMissionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consulterLesAssociationToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
    }
}