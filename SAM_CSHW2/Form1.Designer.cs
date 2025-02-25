namespace SAM_CSHW2
{
    partial class Form1
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
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.GrayPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBox.Location = new System.Drawing.Point(185, 94);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(290, 248);
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            // 
            // GrayPictureBox
            // 
            this.GrayPictureBox.Location = new System.Drawing.Point(556, 94);
            this.GrayPictureBox.Name = "GrayPictureBox";
            this.GrayPictureBox.Size = new System.Drawing.Size(271, 248);
            this.GrayPictureBox.TabIndex = 1;
            this.GrayPictureBox.TabStop = false;
            this.GrayPictureBox.Click += new System.EventHandler(this.GrayPictureBox_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(951, 633);
            this.Controls.Add(this.GrayPictureBox);
            this.Controls.Add(this.PictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FromClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox emguPictureBox;
        private System.Windows.Forms.PictureBox BinaryThreshHoldBox;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.PictureBox GrayPictureBox;
    }
}

