using System;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class StudentEditForm : Form
    {
        private User _student;

        public StudentEditForm(User student)
        {
            InitializeComponent();
            _student = student;

            UITheme.StylePrimaryButton(btnSave);
            UITheme.StyleSecondaryButton(btnCancel);

            if (_student != null)
            {
                txtUsername.Text = _student.Username;
                txtFullName.Text = _student.FullName;
                txtRollNo.Text = _student.RollNo;
                txtEmail.Text = _student.Email;
                txtPhone.Text = _student.Phone;
                chkIsActive.Checked = _student.IsActive;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string rollNo = txtRollNo.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(rollNo) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Full Name, Roll Number, and Email cannot be blank.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _student.FullName = fullName;
            _student.RollNo = rollNo;
            _student.Email = email;
            _student.Phone = txtPhone.Text.Trim();
            _student.IsActive = chkIsActive.Checked;

            btnSave.Enabled = false;

            if (DatabaseHelper.UpdateStudent(_student, out string message))
            {
                // If admin provided a new password, reset it
                string newPwd = txtNewPassword.Text.Trim();
                if (!string.IsNullOrEmpty(newPwd))
                {
                    if (newPwd.Length < 4)
                    {
                        MessageBox.Show("Profile updated, but password must be at least 4 characters long to be changed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DatabaseHelper.ResetStudentPassword(_student.UserId, newPwd, out _);
                    }
                }

                MessageBox.Show("Student details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
