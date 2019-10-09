namespace AppGSB_PPE
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
            this.lblPays = new System.Windows.Forms.Label();
            this.pnlChoixPays = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtChoixPays = new System.Windows.Forms.TextBox();
            this.pnlChoixPays.SuspendLayout();
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
            this.pnlChoixPays.Controls.Add(this.txtChoixPays);
            this.pnlChoixPays.Controls.Add(this.btnValider);
            this.pnlChoixPays.Controls.Add(this.lblPays);
            this.pnlChoixPays.Location = new System.Drawing.Point(249, 134);
            this.pnlChoixPays.Name = "pnlChoixPays";
            this.pnlChoixPays.Size = new System.Drawing.Size(200, 100);
            this.pnlChoixPays.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(58, 65);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // txtChoixPays
            // 
            this.txtChoixPays.Location = new System.Drawing.Point(58, 28);
            this.txtChoixPays.Name = "txtChoixPays";
            this.txtChoixPays.Size = new System.Drawing.Size(100, 20);
            this.txtChoixPays.TabIndex = 2;
            // 
            // FormChoixPays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChoixPays);
            this.Name = "FormChoixPays";
            this.Text = "FormChoixPays";
            this.pnlChoixPays.ResumeLayout(false);
            this.pnlChoixPays.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPays;
        private System.Windows.Forms.Panel pnlChoixPays;
        private System.Windows.Forms.TextBox txtChoixPays;
        private System.Windows.Forms.Button btnValider;
    }
}