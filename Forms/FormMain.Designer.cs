namespace SkounyCrypt
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDocChanged = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.lockedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.unlockedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainerMain = new System.Windows.Forms.ToolStripContainer();
            this.textBoxMain = new System.Windows.Forms.TextBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveAsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.UndoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.statusStripMain.SuspendLayout();
            this.toolStripContainerMain.ContentPanel.SuspendLayout();
            this.toolStripContainerMain.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDocChanged,
            this.toolStripStatusLabelMain,
            this.lockedToolStripStatusLabel,
            this.unlockedToolStripStatusLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 353);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(605, 22);
            this.statusStripMain.TabIndex = 0;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDocChanged
            // 
            this.toolStripStatusLabelDocChanged.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabelDocChanged.Image = global::SkounyCrypt.Properties.Resources.DocEdit_16x16;
            this.toolStripStatusLabelDocChanged.Name = "toolStripStatusLabelDocChanged";
            this.toolStripStatusLabelDocChanged.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelDocChanged.ToolTipText = "You have made changes";
            this.toolStripStatusLabelDocChanged.Visible = false;
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(590, 17);
            this.toolStripStatusLabelMain.Spring = true;
            this.toolStripStatusLabelMain.Text = "Editing: ";
            this.toolStripStatusLabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lockedToolStripStatusLabel
            // 
            this.lockedToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lockedToolStripStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.lockedToolStripStatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("lockedToolStripStatusLabel.Image")));
            this.lockedToolStripStatusLabel.Name = "lockedToolStripStatusLabel";
            this.lockedToolStripStatusLabel.Size = new System.Drawing.Size(68, 17);
            this.lockedToolStripStatusLabel.Text = "LOCKED";
            this.lockedToolStripStatusLabel.Visible = false;
            // 
            // unlockedToolStripStatusLabel
            // 
            this.unlockedToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.unlockedToolStripStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.unlockedToolStripStatusLabel.Image = ((System.Drawing.Image)(resources.GetObject("unlockedToolStripStatusLabel.Image")));
            this.unlockedToolStripStatusLabel.Name = "unlockedToolStripStatusLabel";
            this.unlockedToolStripStatusLabel.Size = new System.Drawing.Size(86, 17);
            this.unlockedToolStripStatusLabel.Text = "UNLOCKED";
            this.unlockedToolStripStatusLabel.Visible = false;
            // 
            // toolStripContainerMain
            // 
            // 
            // toolStripContainerMain.ContentPanel
            // 
            this.toolStripContainerMain.ContentPanel.Controls.Add(this.textBoxMain);
            this.toolStripContainerMain.ContentPanel.Size = new System.Drawing.Size(605, 304);
            this.toolStripContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainerMain.Name = "toolStripContainerMain";
            this.toolStripContainerMain.Size = new System.Drawing.Size(605, 329);
            this.toolStripContainerMain.TabIndex = 1;
            this.toolStripContainerMain.Text = "toolStripContainer1";
            // 
            // toolStripContainerMain.TopToolStripPanel
            // 
            this.toolStripContainerMain.TopToolStripPanel.Controls.Add(this.toolStripMain);
            // 
            // textBoxMain
            // 
            this.textBoxMain.AllowDrop = true;
            this.textBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMain.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxMain.Location = new System.Drawing.Point(0, 0);
            this.textBoxMain.Multiline = true;
            this.textBoxMain.Name = "textBoxMain";
            this.textBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMain.Size = new System.Drawing.Size(605, 304);
            this.textBoxMain.TabIndex = 1000;
            this.textBoxMain.TabStop = false;
            this.textBoxMain.WordWrap = false;
            this.textBoxMain.TextChanged += new System.EventHandler(this.textBoxMain_TextChanged);
            this.textBoxMain.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxMain_DragDrop);
            this.textBoxMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxMain_DragEnter);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.SaveAsToolStripButton,
            this.toolStripSeparator,
            this.UndoToolStripButton,
            this.toolStripSeparator1,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton});
            this.toolStripMain.Location = new System.Drawing.Point(3, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(208, 25);
            this.toolStripMain.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = global::SkounyCrypt.Properties.Resources.New_16x16;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::SkounyCrypt.Properties.Resources.Save_16x16;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // SaveAsToolStripButton
            // 
            this.SaveAsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsToolStripButton.Image = global::SkounyCrypt.Properties.Resources.SaveAs_16x16;
            this.SaveAsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsToolStripButton.Name = "SaveAsToolStripButton";
            this.SaveAsToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveAsToolStripButton.Text = "Save As";
            this.SaveAsToolStripButton.Click += new System.EventHandler(this.SaveAsToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // UndoToolStripButton
            // 
            this.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoToolStripButton.Image = global::SkounyCrypt.Properties.Resources.Undo_16x16;
            this.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoToolStripButton.Name = "UndoToolStripButton";
            this.UndoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UndoToolStripButton.Text = "Undo";
            this.UndoToolStripButton.Click += new System.EventHandler(this.UndoToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = global::SkounyCrypt.Properties.Resources.Cut_16x16;
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = global::SkounyCrypt.Properties.Resources.Copy_16x16;
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            this.copyToolStripButton.Click += new System.EventHandler(this.copyToolStripButton_Click);
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = global::SkounyCrypt.Properties.Resources.Paste_16x16;
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            this.pasteToolStripButton.Click += new System.EventHandler(this.pasteToolStripButton_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.menuStripSeparator1,
            this.changePasswordToolStripMenuItem,
            this.menuStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.New_16x16;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Save_16x16;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.SaveAs_16x16;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // menuStripSeparator1
            // 
            this.menuStripSeparator1.Name = "menuStripSeparator1";
            this.menuStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Password_16x16;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change &Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // menuStripSeparator2
            // 
            this.menuStripSeparator2.Name = "menuStripSeparator2";
            this.menuStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Exit_16x16;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.menuStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.menuStripSeparator4,
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Undo_16x16;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // menuStripSeparator3
            // 
            this.menuStripSeparator3.Name = "menuStripSeparator3";
            this.menuStripSeparator3.Size = new System.Drawing.Size(132, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Cut_16x16;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.cutToolStripMenuItem.Text = "&Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Copy_16x16;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.copyToolStripMenuItem.Text = "C&opy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Paste_16x16;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // menuStripSeparator4
            // 
            this.menuStripSeparator4.Name = "menuStripSeparator4";
            this.menuStripSeparator4.Size = new System.Drawing.Size(132, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.SelectAll_16x16;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.deselectAllToolStripMenuItem.Text = "&Deselect All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.toolBarTextToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.statusBarToolStripMenuItem_CheckedChanged);
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.statusBarToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Checked = true;
            this.toolToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.toolToolStripMenuItem.Text = "&Tool Bar";
            this.toolToolStripMenuItem.CheckedChanged += new System.EventHandler(this.toolToolStripMenuItem_CheckedChanged);
            this.toolToolStripMenuItem.Click += new System.EventHandler(this.toolToolStripMenuItem_Click);
            // 
            // toolBarTextToolStripMenuItem
            // 
            this.toolBarTextToolStripMenuItem.Name = "toolBarTextToolStripMenuItem";
            this.toolBarTextToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.toolBarTextToolStripMenuItem.Text = "Tool Bar Te&xt";
            this.toolBarTextToolStripMenuItem.CheckedChanged += new System.EventHandler(this.toolBarTextToolStripMenuItem_CheckedChanged);
            this.toolBarTextToolStripMenuItem.Click += new System.EventHandler(this.toolBarTextToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordWrapToolStripMenuItem.Text = "&Word Wrap";
            this.wordWrapToolStripMenuItem.CheckedChanged += new System.EventHandler(this.wordWrapToolStripMenuItem_CheckedChanged);
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.webSiteToolStripMenuItem,
            this.contactEmailToolStripMenuItem,
            this.licenseToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.About_16x16;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // webSiteToolStripMenuItem
            // 
            this.webSiteToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.WebLink_16x16;
            this.webSiteToolStripMenuItem.Name = "webSiteToolStripMenuItem";
            this.webSiteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.webSiteToolStripMenuItem.Text = "&Web Site";
            this.webSiteToolStripMenuItem.Click += new System.EventHandler(this.webSiteToolStripMenuItem_Click);
            // 
            // contactEmailToolStripMenuItem
            // 
            this.contactEmailToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Email_16x16;
            this.contactEmailToolStripMenuItem.Name = "contactEmailToolStripMenuItem";
            this.contactEmailToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.contactEmailToolStripMenuItem.Text = "&Contact e-mail";
            this.contactEmailToolStripMenuItem.Click += new System.EventHandler(this.contactEmailToolStripMenuItem_Click);
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Image = global::SkounyCrypt.Properties.Resources.Texinfo_16x16;
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.licenseToolStripMenuItem.Text = "&License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(605, 24);
            this.menuStripMain.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 375);
            this.Controls.Add(this.toolStripContainerMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkounyCrypt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.toolStripContainerMain.ContentPanel.ResumeLayout(false);
            this.toolStripContainerMain.ContentPanel.PerformLayout();
            this.toolStripContainerMain.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerMain.TopToolStripPanel.PerformLayout();
            this.toolStripContainerMain.ResumeLayout(false);
            this.toolStripContainerMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripContainer toolStripContainerMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.TextBox textBoxMain;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripSeparator2;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton UndoToolStripButton;
        private System.Windows.Forms.ToolStripStatusLabel lockedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel unlockedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem webSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolBarTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator menuStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton SaveAsToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDocChanged;
        private System.Windows.Forms.ToolStripMenuItem contactEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;

    }
}

