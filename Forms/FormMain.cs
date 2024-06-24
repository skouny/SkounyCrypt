using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SkounyCrypt
{
    public partial class FormMain : Form
    {
        #region Initialization
        FileInfo _WorkingFile;
        string _WorkingPassword;
        Boolean _WorkingTextChanged;
        MySettings mySettings = MySettings.Read();
        public FormMain(string filename)
        {
            InitializeComponent();
            if (filename == String.Empty)
            {
                WorkingFile = null;
            }
            else
            {
                try
                {
                    WorkingFile = new FileInfo(filename);
                    if (!OpenMyText()) this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion Initialization
        #region Form Events
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadAllSettings();
        }
        private void FormMain_Shown(object sender, EventArgs e)
        {
            // deselect all when directly open a file
            textBoxMain.DeselectAll();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ChangesSaved()) e.Cancel = true;
            SaveAllSettings();
        }
        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {
            WorkingTextChanged = true;
        }
        #endregion Form Events
        #region Menu Items
        // File
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ChangesSaved()) return;
            ClearAll();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ChangesSaved()) return;
            if (GetOpenFileName()) OpenMyText();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( WorkingFile != null )
            {
                SaveMyText();
            }
            else
            {
                if (GetSaveFileName()) SaveMyText();
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( GetSaveFileName() ) SaveMyText();
        }
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newPassword;
            if (PasswordIsSet())
            {
                newPassword = new PasswordManager().CreatePassword(WorkingPassword);
            }
            else
            {
                newPassword = new PasswordManager().CreatePassword();
            }
            if (newPassword != String.Empty)
            {
                WorkingPassword = newPassword;
                WorkingTextChanged = true;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Edit
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Undo();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.Paste(Clipboard.GetText());
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.SelectAll();
        }
        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxMain.DeselectAll();
        }
        // View
        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBarToolStripMenuItem.Checked = !statusBarToolStripMenuItem.Checked;
        }
        private void statusBarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            statusStripMain.Visible = statusBarToolStripMenuItem.Checked;
        }
        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolToolStripMenuItem.Checked = !toolToolStripMenuItem.Checked;
        }
        private void toolToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            this.toolStripMain.Visible = toolToolStripMenuItem.Checked;
        }
        private void toolBarTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolBarTextToolStripMenuItem.Checked = !toolBarTextToolStripMenuItem.Checked;
        }
        private void toolBarTextToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ToolStripItem tool in toolStripMain.Items)
            {
                if (toolBarTextToolStripMenuItem.Checked)
                    tool.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                else
                    tool.DisplayStyle = ToolStripItemDisplayStyle.Image;
            }
        }
        // Options
        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wordWrapToolStripMenuItem.Checked = !wordWrapToolStripMenuItem.Checked;
        }
        private void wordWrapToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMain.WordWrap = wordWrapToolStripMenuItem.Checked;
        }
        // Help
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
        private void webSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://skouny.net");
        }
        private void contactEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format("mailto:{0}?subject={1} user&body={2}", "skouny@gmail.com", Application.ProductName, ""));
        }
        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MyLicense().ShowDialog();
        }
        #endregion Menu Items
        #region ToolStripMenu
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }
        private void SaveAsToolStripButton_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem_Click(sender, e);
        }
        private void UndoToolStripButton_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem_Click(sender, e);
        }
        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            cutToolStripMenuItem_Click(sender, e);
        }
        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(sender, e);
        }
        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(sender, e);
        }
        #endregion ToolStripMenu
        #region Private methods
        // Save textBoxMain's text to current file
        private Boolean SaveMyText()
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(textBoxMain.Text);
                // encrypt if is secured
                if (WorkingFile.Extension == ".egz")
                {
                    if (!GZipEncryptOK(ref data)) return false;
                }
                using (FileStream fs = WorkingFile.OpenWrite())
                {
                    fs.Write(data, 0, data.Length);
                    fs.Close();
                }
                WorkingTextChanged = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Saving error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // Read current file to textBoxMain's text
        private Boolean OpenMyText()
        {
            try
            {
                byte[] data = File.ReadAllBytes(WorkingFile.FullName);
                if (WorkingFile.Extension == ".egz")
                {
                    if (DecryptUngzipOK(ref data))
                    {
                        textBoxMain.Text = Encoding.UTF8.GetString(data);
                        WorkingTextChanged = false;
                        return true;
                    }
                }
                else
                {
                    textBoxMain.Text = GetBytesText(data);
                    WorkingTextChanged = false;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reading error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        // Detect enconing from bytes and convert to windows EOL format
        private string GetBytesText(byte[] data)
        {
            using (StreamReader sr = new StreamReader(new MemoryStream(data), GetTextEncoding(data)))
            {
                string s = "";
                while (!sr.EndOfStream)
                {
                    s += sr.ReadLine() + "\r\n";
                }
                return s;
            }
        }
        // Get text enconding from is bytes
        // SOS!! .NET BUG! => StreamReader.CurrentEncoding does NOT works!!
        public static Encoding GetTextEncoding(byte[] data)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;
            // detect encoding if there is a BOM
            if (data[0] == 0xef && data[1] == 0xbb && data[2] == 0xbf)
                enc = Encoding.UTF8;
            else if (data[0] == 0xfe && data[1] == 0xff)
                enc = Encoding.Unicode;
            else if (data[0] == 0 && data[1] == 0 && data[2] == 0xfe && data[3] == 0xff)
                enc = Encoding.UTF32;
            else if (data[0] == 0x2b && data[1] == 0x2f && data[2] == 0x76)
                enc = Encoding.UTF7;
            // return the result
            return enc;
        }
        // Ask user to choose a file for saveing
        private Boolean GetSaveFileName()
        {
            saveFileDialogMain.FileName = String.Empty;
            saveFileDialogMain.Filter = "Encrypted text files (*.egz)|*.egz|Normal text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogMain.FilterIndex = 1;
            saveFileDialogMain.ShowDialog();
            if (saveFileDialogMain.FileName.Length > 0)
            {
                try
                {
                    WorkingFile = new FileInfo(saveFileDialogMain.FileName);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        // Ask user to choose a file for opening
        private Boolean GetOpenFileName()
        {
            openFileDialogMain.FileName = String.Empty;
            openFileDialogMain.Filter = "Encrypted text files (*.egz)|*.egz|Normal text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialogMain.FilterIndex = 1;
            openFileDialogMain.ShowDialog();
            if (openFileDialogMain.FileName.Length > 0)
            {
                try
                {
                    WorkingFile = new FileInfo(openFileDialogMain.FileName);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        // decrypt decompress data and ask for password
        private Boolean GZipEncryptOK(ref byte[] data)
        {
            try
            {
                if (PasswordExists(false))
                {
                    data = GZip.CompressBytes(data);
                    data = AES256.EncryptBytes(data, WorkingPassword);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Decrypt error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }
            return false;
        }
        // decrypt decompress data and ask for password
        private Boolean DecryptUngzipOK(ref byte[] data)
        {
            try
            {
                if (PasswordExists(true))
                {
                    data = AES256.DecryptBytes(data, WorkingPassword);
                    data = GZip.DecompressBytes(data);
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Decryption failed! Wrong password!", "Incorrect password!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ClearAll();
            }
            return false;
        }
        // Ask user for password if not set
        private Boolean PasswordExists(Boolean forFileOpen)
        {
            // ask user for password if necessary
            if (forFileOpen)
            {
                WorkingPassword = new PasswordManager().GetPassword();
            }
            else
            {
                if (!PasswordIsSet())
                {
                    WorkingPassword = new PasswordManager().CreatePassword();
                }
            }
            // if the password OK return true else return false
            if (PasswordIsSet())
            {
                return true;
            }
            else
            {
                WorkingFile = null;
                return false;
            }
        }
        // Validate Password
        private Boolean PasswordIsSet()
        {
            if (WorkingPassword == null) return false;
            if (WorkingPassword == String.Empty) return false;
            if (WorkingPassword.Length < 6) return false;
            // on any other case is valid
            return true;
        }
        // Clear all
        private void ClearAll()
        {
            textBoxMain.Clear();
            WorkingFile = null;
            WorkingTextChanged = false;
        }
        // Check if there is unsaved work
        private bool ChangesSaved()
        {
            if (WorkingTextChanged)
            {
                DialogResult result = MessageBox.Show(
                    "There are unsaved changes! Pressing OK button, anything unsaved will be lost!",
                    "Unsaved Changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Cancel) return false;
            }
            return true;
        }
        // Save form settings
        private void SaveAllSettings()
        {
            mySettings.FormSize = this.Size;
            mySettings.FormLocation = this.Location;
            mySettings.ViewStatusBar = statusBarToolStripMenuItem.Checked;
            mySettings.ViewToolBar = toolToolStripMenuItem.Checked;
            mySettings.ViewToolBarText = toolBarTextToolStripMenuItem.Checked;
            mySettings.OptionWordWrap = wordWrapToolStripMenuItem.Checked;
            mySettings.Save();
        }
        // Load form settings
        private void LoadAllSettings()
        {
            if (!mySettings.FormSize.IsEmpty) this.Size = mySettings.FormSize;
            if (!mySettings.FormLocation.IsEmpty) this.Location = mySettings.FormLocation;
            statusBarToolStripMenuItem.Checked= mySettings.ViewStatusBar ;
            toolToolStripMenuItem.Checked = mySettings.ViewToolBar;
            toolBarTextToolStripMenuItem.Checked = mySettings.ViewToolBarText;
            wordWrapToolStripMenuItem.Checked = mySettings.OptionWordWrap;
        }
        #endregion Private methods
        #region Private Properies
        private FileInfo WorkingFile
        {
            get { return _WorkingFile; }
            set
            {
                _WorkingFile = value;
                WorkingPassword = String.Empty;
                if (_WorkingFile != null)
                {
                    toolStripStatusLabelMain.Text = string.Format("Editing: {0}", _WorkingFile.FullName);
                    // set the security label
                    if (_WorkingFile.Extension == ".egz")
                    {
                        lockedToolStripStatusLabel.Visible = true;
                        unlockedToolStripStatusLabel.Visible = false;
                    }
                    else
                    {
                        lockedToolStripStatusLabel.Visible = false;
                        unlockedToolStripStatusLabel.Visible = true;
                    }
                }
                else
                {
                    toolStripStatusLabelMain.Text = string.Format("Editing: {0}", "None");
                    // set the security label
                    lockedToolStripStatusLabel.Visible = false;
                    unlockedToolStripStatusLabel.Visible = false;
                }
            }
        }
        private string WorkingPassword
        {
            get { return _WorkingPassword; }
            set
            {
                _WorkingPassword = value;
            }
        }
        private Boolean WorkingTextChanged
        {
            get { return _WorkingTextChanged; }
            set 
            {
                toolStripStatusLabelDocChanged.Visible = value;
                _WorkingTextChanged = value;
            }
        }
        #endregion Private Properies

        private void textBoxMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        private void textBoxMain_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                Array arr = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (arr != null)
                {
                    FileInfo fi = new FileInfo( arr.GetValue(0).ToString());
                    if (ChangesSaved())
                    {
                        WorkingFile = fi;
                        OpenMyText();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Drag & Drop Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}