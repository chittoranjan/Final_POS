namespace POS_System_EF.UI
{
    partial class BarcodeViewForm
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
            this.barCodePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barCodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // barCodePictureBox
            // 
            this.barCodePictureBox.Location = new System.Drawing.Point(33, 12);
            this.barCodePictureBox.Name = "barCodePictureBox";
            this.barCodePictureBox.Size = new System.Drawing.Size(118, 75);
            this.barCodePictureBox.TabIndex = 0;
            this.barCodePictureBox.TabStop = false;
            // 
            // BarcodeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 363);
            this.Controls.Add(this.barCodePictureBox);
            this.Name = "BarcodeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarcodeViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.barCodePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox barCodePictureBox;
    }
}