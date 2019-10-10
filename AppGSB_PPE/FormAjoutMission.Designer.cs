namespace AppGSB_PPE
{
    partial class FormAjoutMission
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValiderMission = new System.Windows.Forms.Button();
            this.txtMission = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMission);
            this.panel1.Controls.Add(this.btnValiderMission);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(216, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 77);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mission :";
            // 
            // btnValiderMission
            // 
            this.btnValiderMission.Location = new System.Drawing.Point(274, 42);
            this.btnValiderMission.Name = "btnValiderMission";
            this.btnValiderMission.Size = new System.Drawing.Size(75, 23);
            this.btnValiderMission.TabIndex = 1;
            this.btnValiderMission.Text = "Valider";
            this.btnValiderMission.UseVisualStyleBackColor = true;
            // 
            // txtMission
            // 
            this.txtMission.Location = new System.Drawing.Point(66, 16);
            this.txtMission.Name = "txtMission";
            this.txtMission.Size = new System.Drawing.Size(283, 20);
            this.txtMission.TabIndex = 2;
            // 
            // FormAjoutMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormAjoutMission";
            this.Text = "FormAjoutMission";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMission;
        private System.Windows.Forms.Button btnValiderMission;
        private System.Windows.Forms.Label label1;
    }
}