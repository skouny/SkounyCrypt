using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkounyCrypt
{
    public partial class PasswordManager : Form
    {
        #region init
        enum ButtonPressed { OK, Cancel };
        ButtonPressed _button;
        string _Password;
        string _NewPassword;
        public PasswordManager()
        {
            InitializeComponent();
        }
        #endregion init
        #region form events
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _button = ButtonPressed.Cancel;
            this.Close();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            _button = ButtonPressed.OK;
            if (panelEnterPassword.Visible)
            {
                if (PasswordAcceptable(textBoxPassword.Text))
                {
                    _Password = textBoxPassword.Text;
                    this.Close();
                }
                return;
            }
            if (panelCurrentPassword.Visible)
            {
                // validate current password
                if (textBoxCurrentPassword.Text != _Password)
                {
                    MessageBox.Show("Current password is incorrect!",
                        "Password validaton error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (panelNewPassword.Visible)
            {
                // validate new passwords is same
                if (textBoxNewPassword.Text != textBoxNewPasswordAgain.Text)
                {
                    MessageBox.Show("Passwords is NOT the same!",
                        "Password validaton error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                // validate new password's length
                if (!PasswordAcceptable(textBoxNewPassword.Text)) return;
                // set the new password and close the dialog
                _NewPassword = textBoxNewPassword.Text;
            }
            this.Close();
        }
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonOK_Click(sender, e);
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
        }
        #endregion form events
        #region public methods
        // Get a password
        public string GetPassword()
        {
            // hide unused panels and fix the form size
            panelCurrentPassword.Hide();
            panelNewPassword.Hide();
            panelButtons.Top = panelEnterPassword.Height;
            this.ClientSize = new System.Drawing.Size(panelButtons.Width,
                panelButtons.Top + panelButtons.Height);
            // set window title
            this.Text = "Password required";
            // reset password and show dialog
            _Password = String.Empty;
            this.ShowDialog();
            // return the result of validation
            if (_button == ButtonPressed.OK)
            {
                return _Password;
            }
            else
            {
                return String.Empty;
            }
        }
        // Create new password
        public string CreatePassword()
        {
            // hide unused panels and fix the form size
            panelEnterPassword.Hide();
            panelCurrentPassword.Hide();
            panelNewPassword.Top = 0;
            panelButtons.Top = panelNewPassword.Height;
            this.ClientSize = new System.Drawing.Size(panelButtons.Width,
                panelButtons.Top + panelButtons.Height);
            // disable current password check
            _Password = String.Empty;
            // set window title
            this.Text = "Create Password";
            // reset password and show dialog
            _NewPassword = String.Empty;
            this.ShowDialog();
            // return the result of validation
            // return the result of validation
            if (_button == ButtonPressed.OK)
            {
                return _NewPassword;
            }
            else
            {
                return String.Empty;
            }
        }
        // Change current password
        public string CreatePassword(string CurrentPassword)
        {
            // hide unused panels and fix the form size
            panelEnterPassword.Hide();
            panelCurrentPassword.Top = 0;
            panelNewPassword.Top = panelCurrentPassword.Height;
            panelButtons.Top = panelNewPassword.Top + panelNewPassword.Height;
            this.ClientSize = new System.Drawing.Size(panelButtons.Width,
                panelButtons.Top + panelButtons.Height);
            // enable current password check
            _Password = CurrentPassword;
            // set window title
            this.Text = "Change Password";
            // reset password and show dialog
            _NewPassword = String.Empty;
            this.ShowDialog();
            // return the result of validation
            if (_button == ButtonPressed.OK)
            {
                return _NewPassword;
            }
            else
            {
                return String.Empty;
            }
        }
        // Validate password
        public Boolean PasswordAcceptable(string testPassword)
        {
            if (testPassword.Length < 6)
            {
                MessageBox.Show("Paswords must be more than 6 characters!",
                    "Password validaton error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        #endregion public methods
        
    }
}
