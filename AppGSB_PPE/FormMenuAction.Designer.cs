namespace Pierre_Mulot
{
    partial class FormMenuAction
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreation = new System.Windows.Forms.Button();
            this.btnModification = new System.Windows.Forms.Button();
            this.btnSupression = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbxCreation = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreation
            // 
            this.btnCreation.Location = new System.Drawing.Point(3, 38);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(207, 33);
            this.btnCreation.TabIndex = 0;
            this.btnCreation.Text = "Creation";
            this.btnCreation.UseVisualStyleBackColor = true;
            this.btnCreation.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModification
            // 
            this.btnModification.Location = new System.Drawing.Point(3, 38);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(101, 33);
            this.btnModification.TabIndex = 1;
            this.btnModification.Text = "Modification";
            this.btnModification.UseVisualStyleBackColor = true;
            // 
            // btnSupression
            // 
            this.btnSupression.Location = new System.Drawing.Point(106, 38);
            this.btnSupression.Name = "btnSupression";
            this.btnSupression.Size = new System.Drawing.Size(101, 33);
            this.btnSupression.TabIndex = 2;
            this.btnSupression.Text = "Supression";
            this.btnSupression.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreation);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 74);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnModification);
            this.panel2.Controls.Add(this.btnSupression);
            this.panel2.Location = new System.Drawing.Point(231, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 74);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbxCreation);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(12, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 74);
            this.panel3.TabIndex = 5;
            // 
            // cbxCreation
            // 
            this.cbxCreation.AutoSize = true;
            this.cbxCreation.Location = new System.Drawing.Point(110, 35);
            this.cbxCreation.Name = "cbxCreation";
            this.cbxCreation.Size = new System.Drawing.Size(100, 17);
            this.cbxCreation.TabIndex = 2;
            this.cbxCreation.Text = "cree une action";
            this.cbxCreation.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // FormMenuAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 180);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenuAction";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.Button btnSupression;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbxCreation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

