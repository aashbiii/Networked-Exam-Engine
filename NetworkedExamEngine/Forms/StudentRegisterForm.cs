using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class StudentRegisterForm : Form
    {
        public string RegisteredUsername { get; private set; }

        public StudentRegisterForm()
        {
            InitializeComponent();
            UITheme.StylePrimaryButton(btnRegister);
            UITheme.StyleSecondaryButton(btnCancel);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string rollNo = txtRollNo.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validations
            if (string.IsNullOrEmpty(fullName))
            {
                ShowError("Please enter your full name.");
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(rollNo))
            {
                ShowError("Please enter your student Roll Number / University ID.");
                txtRollNo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                ShowError("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(username) || username.Length < 3)
            {
                ShowError("Username must be at least 3 characters long.");
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password) || password.Length < 4)
            {
                ShowError("Password must be at least 4 characters long.");
                txtPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                ShowError("Password and Confirm Password do not match.");
                txtConfirmPassword.Focus();
                return;
            }

            var student = new User
            {
                FullName = fullName,
                RollNo = rollNo,
                Email = email,
                Phone = phone,
                Username = username,
                Role = "Student"
            };

            btnRegister.Enabled = false;
            lblStatus.ForeColor = UITheme.Accent;
            lblStatus.Text = "Creating account, please wait...";
            Application.DoEvents();

            if (DatabaseHelper.RegisterStudent(student, password, out string message))
            {
                RegisteredUsername = username;
                MessageBox.Show("Account created successfully! You can now log in with your credentials.",
                    "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                ShowError(message);
                btnRegister.Enabled = true;
            }
        }

        private void ShowError(string msg)
        {
            lblStatus.ForeColor = UITheme.Danger;
            lblStatus.Text = msg;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
