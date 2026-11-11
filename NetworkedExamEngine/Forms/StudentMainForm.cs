using System;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class StudentMainForm : Form
    {
        private User _student;

        public StudentMainForm(User student)
        {
            InitializeComponent();
            _student = student;

            UITheme.StyleDataGrid(dgvExams);
            UITheme.StyleDataGrid(dgvHistory);
            UITheme.StylePrimaryButton(btnStartExam);
            UITheme.StyleSuccessButton(btnViewReport);
            UITheme.StylePrimaryButton(btnHistoryViewReport);
            UITheme.StylePrimaryButton(btnUpdateProfile);

            lblWelcomeTitle.Text = $"Welcome, {_student.FullName}";
            lblStudentRoll.Text = $"Roll No: {_student.RollNo} | Email: {_student.Email}";

            LoadStudentExams();
            LoadStudentHistory();
            LoadProfileDetails();
        }

        private void LoadStudentExams()
        {
            var exams = DatabaseHelper.GetExamsForStudent(_student.UserId);

            dgvExams.Rows.Clear();
            foreach (var exam in exams)
            {
                string statusText = exam.IsAttemptedByStudent 
                    ? $"Completed ({exam.ExistingScore:0.#}/{exam.TotalQuestions} - {(exam.ExistingIsPassed == true ? "PASSED" : "FAILED")})" 
                    : "Available to Take";

                int rowIndex = dgvExams.Rows.Add(
                    exam.ExamId,
                    exam.SubjectCode,
                    exam.Title,
                    $"{exam.DurationMinutes} Minutes",
                    exam.TotalQuestions,
                    $"{exam.PassPercentage:0.#}%",
                    statusText
                );

                if (exam.IsAttemptedByStudent)
                {
                    dgvExams.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = exam.ExistingIsPassed == true ? UITheme.SuccessDark : UITheme.Danger;
                    dgvExams.Rows[rowIndex].Cells["colStatus"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else
                {
                    dgvExams.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = UITheme.Accent;
                }
            }

            UpdateExamActionButtons();
        }

        private void dgvExams_SelectionChanged(object sender, EventArgs e)
        {
            UpdateExamActionButtons();
        }

        private void UpdateExamActionButtons()
        {
            if (dgvExams.CurrentRow != null && dgvExams.CurrentRow.Index >= 0)
            {
                int examId = Convert.ToInt32(dgvExams.CurrentRow.Cells["colExamId"].Value);
                bool isAttempted = DatabaseHelper.HasStudentAttemptedExam(_student.UserId, examId);

                btnStartExam.Enabled = !isAttempted;
                btnStartExam.Text = isAttempted ? "Already Attempted" : "Start Selected Examination";
                btnViewReport.Enabled = isAttempted;
            }
            else
            {
                btnStartExam.Enabled = false;
                btnViewReport.Enabled = false;
            }
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            if (dgvExams.CurrentRow == null) return;

            int examId = Convert.ToInt32(dgvExams.CurrentRow.Cells["colExamId"].Value);
            string examTitle = dgvExams.CurrentRow.Cells["colTitle"].Value.ToString();

            if (DatabaseHelper.HasStudentAttemptedExam(_student.UserId, examId))
            {
                MessageBox.Show("You have already completed this examination. Each student is permitted only ONE attempt.",
                    "Attempt Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var res = MessageBox.Show($"You are about to start '{examTitle}'.\n\n" +
                                      $"• Make sure you have an active network connection.\n" +
                                      $"• The timer will begin immediately upon opening.\n" +
                                      $"• Only ONE attempt is allowed per candidate.\n\n" +
                                      $"Are you ready to proceed?",
                                      "Confirm Start Examination", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                this.Hide();
                using (var examForm = new ExamTakingForm(_student.UserId, examId))
                {
                    examForm.ShowDialog();
                }
                this.Show();

                // Refresh tables
                LoadStudentExams();
                LoadStudentHistory();
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (dgvExams.CurrentRow == null) return;

            int examId = Convert.ToInt32(dgvExams.CurrentRow.Cells["colExamId"].Value);
            var attempts = DatabaseHelper.GetAllAttempts(examId, _student.UserId);
            if (attempts.Count > 0)
            {
                using (var rep = new ExamResultReportForm(attempts[0].AttemptId))
                {
                    rep.ShowDialog();
                }
            }
        }

        private void LoadStudentHistory()
        {
            var attempts = DatabaseHelper.GetAllAttempts(studentId: _student.UserId);

            dgvHistory.Rows.Clear();
            foreach (var att in attempts)
            {
                int rowIndex = dgvHistory.Rows.Add(
                    att.AttemptId,
                    att.SubjectCode,
                    att.ExamTitle,
                    $"{att.Score:0.#} / {att.TotalQuestions}",
                    $"{att.Percentage:0.0}%",
                    att.IsPassed ? "PASSED" : "FAILED",
                    att.FormattedDuration,
                    att.StartTime.ToString("dd-MMM-yyyy hh:mm tt")
                );

                var statusCell = dgvHistory.Rows[rowIndex].Cells["colHistStatus"];
                statusCell.Style.ForeColor = att.IsPassed ? UITheme.SuccessDark : UITheme.Danger;
                statusCell.Style.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            }
        }

        private void btnHistoryViewReport_Click(object sender, EventArgs e)
        {
            if (dgvHistory.CurrentRow == null)
            {
                MessageBox.Show("Please select an exam attempt from the history table.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int attemptId = Convert.ToInt32(dgvHistory.CurrentRow.Cells["colHistAttemptId"].Value);
            using (var rep = new ExamResultReportForm(attemptId))
            {
                rep.ShowDialog();
            }
        }

        private void LoadProfileDetails()
        {
            txtProfFullName.Text = _student.FullName;
            txtProfRollNo.Text = _student.RollNo;
            txtProfEmail.Text = _student.Email;
            txtProfPhone.Text = _student.Phone;
            txtProfUsername.Text = _student.Username;
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string fullName = txtProfFullName.Text.Trim();
            string email = txtProfEmail.Text.Trim();
            string phone = txtProfPhone.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Full Name and Email cannot be empty.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _student.FullName = fullName;
            _student.Email = email;
            _student.Phone = phone;

            if (DatabaseHelper.UpdateStudent(_student, out string message))
            {
                string newPwd = txtProfNewPassword.Text.Trim();
                if (!string.IsNullOrEmpty(newPwd))
                {
                    if (newPwd.Length < 4)
                    {
                        MessageBox.Show("Password must be at least 4 characters long.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    DatabaseHelper.ResetStudentPassword(_student.UserId, newPwd, out _);
                    txtProfNewPassword.Clear();
                }

                MessageBox.Show("Your profile details have been updated successfully!", "Profile Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblWelcomeTitle.Text = $"Welcome, {_student.FullName}";
                lblStudentRoll.Text = $"Roll No: {_student.RollNo} | Email: {_student.Email}";
            }
            else
            {
                MessageBox.Show(message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
