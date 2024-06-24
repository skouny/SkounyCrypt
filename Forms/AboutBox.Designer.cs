namespace SkounyCrypt
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelContactEmail = new System.Windows.Forms.Label();
            this.labelWebSite = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxVersion = new System.Windows.Forms.TextBox();
            this.textBoxCopyright = new System.Windows.Forms.TextBox();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.linkLabelWebSite = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(123, 121);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(316, 231);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 22);
            this.buttonOK.TabIndex = 25;
            this.buttonOK.Text = "&OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(15, 139);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(376, 86);
            this.textBoxDescription.TabIndex = 26;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Description";
            // 
            // labelContactEmail
            // 
            this.labelContactEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContactEmail.Location = new System.Drawing.Point(6, 72);
            this.labelContactEmail.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelContactEmail.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelContactEmail.Name = "labelContactEmail";
            this.labelContactEmail.Size = new System.Drawing.Size(80, 17);
            this.labelContactEmail.TabIndex = 27;
            this.labelContactEmail.Text = "Contact e-mail:";
            this.labelContactEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWebSite
            // 
            this.labelWebSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWebSite.Location = new System.Drawing.Point(6, 96);
            this.labelWebSite.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelWebSite.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelWebSite.Name = "labelWebSite";
            this.labelWebSite.Size = new System.Drawing.Size(80, 17);
            this.labelWebSite.TabIndex = 31;
            this.labelWebSite.Text = "Web site:";
            this.labelWebSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.8804F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.1196F));
            this.tableLayoutPanel1.Controls.Add(this.labelProductName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelWebSite, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelVersion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelContactEmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelCopyright, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProductName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCopyright, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelWebSite, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(141, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(249, 122);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(6, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(80, 17);
            this.labelProductName.TabIndex = 30;
            this.labelProductName.Text = "Product Name:";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(6, 24);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(80, 17);
            this.labelVersion.TabIndex = 31;
            this.labelVersion.Text = "Version:";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCopyright.Location = new System.Drawing.Point(6, 48);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(80, 17);
            this.labelCopyright.TabIndex = 32;
            this.labelCopyright.Text = "Copyright:";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProductName.Location = new System.Drawing.Point(92, 3);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.ReadOnly = true;
            this.textBoxProductName.Size = new System.Drawing.Size(154, 13);
            this.textBoxProductName.TabIndex = 35;
            // 
            // textBoxVersion
            // 
            this.textBoxVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxVersion.Location = new System.Drawing.Point(92, 27);
            this.textBoxVersion.Name = "textBoxVersion";
            this.textBoxVersion.ReadOnly = true;
            this.textBoxVersion.Size = new System.Drawing.Size(154, 13);
            this.textBoxVersion.TabIndex = 36;
            // 
            // textBoxCopyright
            // 
            this.textBoxCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCopyright.Location = new System.Drawing.Point(92, 51);
            this.textBoxCopyright.Name = "textBoxCopyright";
            this.textBoxCopyright.ReadOnly = true;
            this.textBoxCopyright.Size = new System.Drawing.Size(154, 13);
            this.textBoxCopyright.TabIndex = 37;
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.linkLabelEmail.Location = new System.Drawing.Point(92, 72);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(99, 13);
            this.linkLabelEmail.TabIndex = 34;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "skouny@gmail.com";
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked);
            // 
            // linkLabelWebSite
            // 
            this.linkLabelWebSite.AutoSize = true;
            this.linkLabelWebSite.Location = new System.Drawing.Point(92, 96);
            this.linkLabelWebSite.Name = "linkLabelWebSite";
            this.linkLabelWebSite.Size = new System.Drawing.Size(90, 13);
            this.linkLabelWebSite.TabIndex = 33;
            this.linkLabelWebSite.TabStop = true;
            this.linkLabelWebSite.Text = "http://skouny.net";
            this.linkLabelWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebSite_LinkClicked);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 265);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.logoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelContactEmail;
        private System.Windows.Forms.Label labelWebSite;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxVersion;
        private System.Windows.Forms.TextBox textBoxCopyright;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.LinkLabel linkLabelWebSite;

    }
}
