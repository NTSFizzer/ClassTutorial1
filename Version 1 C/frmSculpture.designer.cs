namespace Version_1_C
{
    partial class FrmSculpture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSculpture));
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(146, 225);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(142, 29);
            this.txtMaterial.TabIndex = 7;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(14, 229);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(84, 26);
            this.Label5.TabIndex = 56;
            this.Label5.Text = "Material";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(146, 173);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(142, 29);
            this.txtWeight.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(14, 178);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(84, 26);
            this.Label4.TabIndex = 54;
            this.Label4.Text = "Weight";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(322, 124);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSculpture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(528, 292);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSculpture";
            this.Text = "Sculpture Details";
            this.Controls.SetChildIndex(this.txtMaterial, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.txtWeight, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtMaterial;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtWeight;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
