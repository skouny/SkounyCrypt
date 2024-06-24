namespace SkounyCrypt
{
    partial class MyLicense
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
            this.textBoxLicense = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxLicense
            // 
            this.textBoxLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLicense.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxLicense.Location = new System.Drawing.Point(0, 0);
            this.textBoxLicense.Multiline = true;
            this.textBoxLicense.Name = "textBoxLicense";
            this.textBoxLicense.ReadOnly = true;
            this.textBoxLicense.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLicense.Size = new System.Drawing.Size(574, 382);
            this.textBoxLicense.TabIndex = 0;
            this.textBoxLicense.TabStop = false;
            this.textBoxLicense.WordWrap = false;
            // 
            // MyLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 382);
            this.Controls.Add(this.textBoxLicense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyLicense";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "License";
            this.Load += new System.EventHandler(this.License_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLicense;
    }
}