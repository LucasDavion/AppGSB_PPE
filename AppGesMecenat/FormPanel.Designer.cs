﻿namespace AppGesMecenat
{
    partial class FormPanel
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
            this.gesServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gesUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gesServicesToolStripMenuItem,
            this.gesUtilisateurToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gesServicesToolStripMenuItem
            // 
            this.gesServicesToolStripMenuItem.Name = "gesServicesToolStripMenuItem";
            this.gesServicesToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.gesServicesToolStripMenuItem.Text = "Gestion des services";
            this.gesServicesToolStripMenuItem.Click += new System.EventHandler(this.gesServicesToolStripMenuItem_Click);
            // 
            // gesUtilisateurToolStripMenuItem
            // 
            this.gesUtilisateurToolStripMenuItem.Name = "gesUtilisateurToolStripMenuItem";
            this.gesUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.gesUtilisateurToolStripMenuItem.Text = "Gestion des utilisateurs";
            this.gesUtilisateurToolStripMenuItem.Click += new System.EventHandler(this.gesUtilisateurToolStripMenuItem_Click);
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPanel";
            this.Text = "FormPanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gesServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gesUtilisateurToolStripMenuItem;
    }
}