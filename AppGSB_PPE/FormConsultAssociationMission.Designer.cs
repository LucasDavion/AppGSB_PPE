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
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultAssociation)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgConsultAssociation
            // 
            this.dtgConsultAssociation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultAssociation.Location = new System.Drawing.Point(108, 144);
            this.dtgConsultAssociation.Name = "dtgConsultAssociation";
            this.dtgConsultAssociation.Size = new System.Drawing.Size(582, 150);
            this.dtgConsultAssociation.TabIndex = 0;
            // 
            // FormConsultAssociation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgConsultAssociation);
            this.Name = "FormConsultAssociation";
            this.Text = "FormConsultAssociation";
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultAssociation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgConsultAssociation;
    }
}