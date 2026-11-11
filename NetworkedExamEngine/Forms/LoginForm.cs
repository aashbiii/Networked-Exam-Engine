using System;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class LoginForm : Form
    {
        private bool _isAdminMode = false;

        public LoginForm()
        {
            InitializeComponent();
            ApplyCustomStyles();
        }

        private void ApplyCustomStyles()
        {
            UITheme.StylePrimaryButton(btnLogin);
            UITheme.StyleSecondaryButton(btnDbSettings);

            // Default to Student login
            SetLoginMode(false);
        }

        private void SetLoginMode(bool isAdmin)
        {
            _isAdminMode = isAdmin;
            if (_isAdminMode)
            {
                btnTabAdmin.BackColor = UITheme.Accent;
                btnTabAdmin.ForeColor = Color.White;
                btnTabStudent.BackColor = Color.FromArgb(241, 245, 249);
                btnTabStudent.ForeColor = UITheme.TextSecondary;
                lblLoginHeading.Text = "Administrator Login";
                lblLoginSubheading.Text = "Sign in to manage exams, questions, and students";
                pnlRegisterPrompt.Visible = false;
            }
            else
            {
                btnTabStudent.BackColor = UITheme.Accent;
                btnTabStudent.ForeColor = Color.White;
                btnTabAdmin.BackColor = Color.FromArgb(241, 245, 249);
                btnTabAdmin.ForeColor = UITheme.TextSecondary;
                lblLoginHeading.Text = "Student Examination Portal";
                lblLoginSubheading.Text = "Sign in with your student credentials to take exams";
                pnlRegisterPrompt.Visible = true;
            }
            lblStatus.Text = string.Empty;
        }

        private void btnTabStudent_Click(object sender, EventArgs e)
        {
            SetLoginMode(false);
        }

        private void btnTabAdmin_Click(object sender, EventArgs e)
        {
            SetLoginMode(true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                lblStatus.Text = "Please enter your username.";
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblStatus.Text = "Please enter your password.";
                txtPassword.Focus();
                return;
            }

            lblStatus.ForeColor = UITheme.Accent;
            lblStatus.Text = "Authenticating, please wait...";
            btnLogin.Enabled = false;
            Application.DoEvents();

            if (DatabaseHelper.AuthenticateUser(username, password, out User user, out string message))
            {
                lblStatus.ForeColor = UITheme.Success;
                lblStatus.Text = "Login successful!";

                // Validate role match
                if (_isAdminMode && !user.IsAdmin)
                {
                    lblStatus.ForeColor = UITheme.Danger;
                    lblStatus.Text = "Access Denied: This account does not possess Administrator privileges.";
                    btnLogin.Enabled = true;
                    return;
                }

                if (!_isAdminMode && !user.IsStudent)
                {
                    // If an admin logs in on student tab, allow switching or warn
                    var result = MessageBox.Show("This account is an Administrator. Would you like to enter the Admin Dashboard?",
                        "Admin Account Detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        OpenAdminDashboard(user);
                        return;
                    }
                    else
                    {
                        btnLogin.Enabled = true;
                        lblStatus.Text = string.Empty;
                        return;
                    }
                }

                if (user.IsAdmin)
                {
                    OpenAdminDashboard(user);
                }
                else
                {
                    OpenStudentDashboard(user);
                }
            }
            else
            {
                lblStatus.ForeColor = UITheme.Danger;
                lblStatus.Text = message;
                btnLogin.Enabled = true;
            }
        }

        private void OpenAdminDashboard(User user)
        {
            this.Hide();
            using (var adminForm = new AdminMainForm(user))
            {
                adminForm.ShowDialog();
            }
            txtPassword.Clear();
            lblStatus.Text = string.Empty;
            btnLogin.Enabled = true;
            this.Show();
        }

        private void OpenStudentDashboard(User user)
        {
            this.Hide();
            using (var studentForm = new StudentMainForm(user))
            {
                studentForm.ShowDialog();
            }
            txtPassword.Clear();
            lblStatus.Text = string.Empty;
            btnLogin.Enabled = true;
            this.Show();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var regForm = new StudentRegisterForm())
            {
                if (regForm.ShowDialog() == DialogResult.OK)
                {
                    SetLoginMode(false);
                    txtUsername.Text = regForm.RegisteredUsername;
                    txtPassword.Focus();
                    lblStatus.ForeColor = UITheme.Success;
                    lblStatus.Text = "Registration successful! Please enter your password to sign in.";
                }
            }
        }

        private void btnDbSettings_Click(object sender, EventArgs e)
        {
            using (var dbForm = new DatabaseConfigForm())
            {
                dbForm.ShowDialog();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
