using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class AdminMainForm : Form
    {
        private User _admin;
        private List<Exam> _allExams;
        private List<User> _allStudents;
        private List<Question> _currentQuestions;

        public AdminMainForm(User admin)
        {
            InitializeComponent();
            _admin = admin;

            ApplyThemeStyles();
            lblAdminInfo.Text = $"Logged in as: {_admin.FullName} (Administrator)";

            // Load initial data
            RefreshDashboardStats();
            LoadExamsList();
            LoadExamsFilterDropdowns();
            LoadStudentsList();
            LoadAllAttempts();
        }

        private void ApplyThemeStyles()
        {
            UITheme.StyleDataGrid(dgvRecentAttempts);
            UITheme.StyleDataGrid(dgvExams);
            UITheme.StyleDataGrid(dgvQuestions);
            UITheme.StyleDataGrid(dgvStudents);
            UITheme.StyleDataGrid(dgvAllAttempts);

            UITheme.StylePrimaryButton(btnAddExam);
            UITheme.StyleSecondaryButton(btnEditExam);
            UITheme.StyleDangerButton(btnDeleteExam);

            UITheme.StylePrimaryButton(btnAddQuestion);
            UITheme.StyleSecondaryButton(btnEditQuestion);
            UITheme.StyleDangerButton(btnDeleteQuestion);

            UITheme.StyleSecondaryButton(btnEditStudent);
            UITheme.StyleSecondaryButton(btnResetStudentPwd);
            UITheme.StyleDangerButton(btnDeleteStudent);

            UITheme.StylePrimaryButton(btnViewDetailedScorecard);
        }

        // ========================================================
        // TAB 1: DASHBOARD
        // ========================================================

        private void RefreshDashboardStats()
        {
            var stats = DatabaseHelper.GetAdminDashboardStats();
            lblStatExams.Text = stats["TotalExams"].ToString();
            lblStatQuestions.Text = stats["TotalQuestions"].ToString();
            lblStatStudents.Text = stats["TotalStudents"].ToString();
            lblStatAttempts.Text = stats["TotalAttempts"].ToString();
            lblStatPassRate.Text = $"{stats["PassPercentage"]}%";

            // Recent attempts
            var attempts = DatabaseHelper.GetAllAttempts();
            dgvRecentAttempts.Rows.Clear();
            int count = Math.Min(10, attempts.Count);
            for (int i = 0; i < count; i++)
            {
                var att = attempts[i];
                int rowIndex = dgvRecentAttempts.Rows.Add(
                    att.AttemptId,
                    att.RollNo,
                    att.StudentName,
                    att.SubjectCode,
                    att.ExamTitle,
                    $"{att.Score:0.#} / {att.TotalQuestions}",
                    $"{att.Percentage:0.0}%",
                    att.IsPassed ? "PASSED" : "FAILED",
                    att.StartTime.ToString("dd-MMM-yyyy hh:mm tt")
                );

                var statusCell = dgvRecentAttempts.Rows[rowIndex].Cells["colRecStatus"];
                statusCell.Style.ForeColor = att.IsPassed ? UITheme.SuccessDark : UITheme.Danger;
                statusCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void btnQuickAddExam_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabExams;
            btnAddExam_Click(sender, e);
        }

        private void btnQuickAddQuestion_Click(object sender, EventArgs e)
        {
            tabAdmin.SelectedTab = tabQuestions;
            btnAddQuestion_Click(sender, e);
        }

        // ========================================================
        // TAB 2: MANAGE EXAMS
        // ========================================================

        private void LoadExamsList()
        {
            _allExams = DatabaseHelper.GetAllExams(activeOnly: false);
            FilterExamsGrid();
        }

        private void FilterExamsGrid()
        {
            if (_allExams == null) return;
            string filter = txtSearchExams.Text.Trim().ToLowerInvariant();

            dgvExams.Rows.Clear();
            foreach (var exam in _allExams)
            {
                if (string.IsNullOrEmpty(filter) ||
                    exam.Title.ToLowerInvariant().Contains(filter) ||
                    exam.SubjectCode.ToLowerInvariant().Contains(filter))
                {
                    int rowIndex = dgvExams.Rows.Add(
                        exam.ExamId,
                        exam.SubjectCode,
                        exam.Title,
                        $"{exam.DurationMinutes} Mins",
                        exam.ActualQuestionCount,
                        $"{exam.PassPercentage:0.#}%",
                        exam.IsActive ? "Active" : "Inactive",
                        exam.CreatedAt.ToString("dd-MMM-yyyy")
                    );

                    var activeCell = dgvExams.Rows[rowIndex].Cells["colExActive"];
                    activeCell.Style.ForeColor = exam.IsActive ? UITheme.SuccessDark : UITheme.Danger;
                    activeCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        }

        private void txtSearchExams_TextChanged(object sender, EventArgs e)
        {
            FilterExamsGrid();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            using (var form = new ExamEditForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadExamsList();
                    LoadExamsFilterDropdowns();
                    RefreshDashboardStats();
                }
            }
        }

        private void btnEditExam_Click(object sender, EventArgs e)
        {
            if (dgvExams.CurrentRow == null)
            {
                MessageBox.Show("Please select an exam to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int examId = Convert.ToInt32(dgvExams.CurrentRow.Cells["colExId"].Value);
            var exam = DatabaseHelper.GetExamById(examId);
            if (exam != null)
            {
                using (var form = new ExamEditForm(exam))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadExamsList();
                        LoadExamsFilterDropdowns();
                    }
                }
            }
        }

        private void btnDeleteExam_Click(object sender, EventArgs e)
        {
            if (dgvExams.CurrentRow == null)
            {
                MessageBox.Show("Please select an exam to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int examId = Convert.ToInt32(dgvExams.CurrentRow.Cells["colExId"].Value);
            string examTitle = dgvExams.CurrentRow.Cells["colExTitle"].Value.ToString();

            var res = MessageBox.Show($"Are you sure you want to permanently delete the exam '{examTitle}'?\n\nWarning: All questions and student attempts for this exam will be removed.",
                "Confirm Exam Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                if (DatabaseHelper.DeleteExam(examId, out string msg))
                {
                    MessageBox.Show("Exam deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExamsList();
                    LoadExamsFilterDropdowns();
                    RefreshDashboardStats();
                }
                else
                {
                    MessageBox.Show(msg, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========================================================
        // TAB 3: MANAGE QUESTIONS
        // ========================================================

        private void LoadExamsFilterDropdowns()
        {
            var exams = DatabaseHelper.GetAllExams();

            // Setup Question Tab Exam Dropdown
            var qExams = new List<Exam>(exams);
            cmbQuestionExamFilter.DisplayMember = "Title";
            cmbQuestionExamFilter.ValueMember = "ExamId";
            cmbQuestionExamFilter.DataSource = qExams;

            // Setup Reports Tab Exam Dropdown (with 'All Exams' option)
            var reportExams = new List<Exam>
            {
                new Exam { ExamId = 0, Title = "-- All Examinations --", SubjectCode = "ALL" }
            };
            reportExams.AddRange(exams);
            cmbReportExamFilter.DisplayMember = "Title";
            cmbReportExamFilter.ValueMember = "ExamId";
            cmbReportExamFilter.DataSource = reportExams;

            if (qExams.Count > 0)
            {
                cmbQuestionExamFilter.SelectedIndex = 0;
            }
        }

        private void cmbQuestionExamFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestionsForSelectedExam();
        }

        private void LoadQuestionsForSelectedExam()
        {
            if (cmbQuestionExamFilter.SelectedItem == null) return;

            int examId = ((Exam)cmbQuestionExamFilter.SelectedItem).ExamId;
            _currentQuestions = DatabaseHelper.GetQuestionsByExamId(examId);
            FilterQuestionsGrid();
        }

        private void FilterQuestionsGrid()
        {
            if (_currentQuestions == null) return;
            string filter = txtSearchQuestions.Text.Trim().ToLowerInvariant();

            dgvQuestions.Rows.Clear();
            int qNum = 1;
            foreach (var q in _currentQuestions)
            {
                if (string.IsNullOrEmpty(filter) ||
                    q.QuestionText.ToLowerInvariant().Contains(filter) ||
                    q.OptionA.ToLowerInvariant().Contains(filter) ||
                    q.OptionB.ToLowerInvariant().Contains(filter) ||
                    q.OptionC.ToLowerInvariant().Contains(filter) ||
                    q.OptionD.ToLowerInvariant().Contains(filter))
                {
                    dgvQuestions.Rows.Add(
                        q.QuestionId,
                        qNum++,
                        q.QuestionText,
                        q.OptionA,
                        q.OptionB,
                        q.OptionC,
                        q.OptionD,
                        q.CorrectOption.ToString(),
                        q.Marks,
                        q.Explanation
                    );
                }
            }
        }

        private void txtSearchQuestions_TextChanged(object sender, EventArgs e)
        {
            FilterQuestionsGrid();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            int defaultExamId = 0;
            if (cmbQuestionExamFilter.SelectedItem != null)
            {
                defaultExamId = ((Exam)cmbQuestionExamFilter.SelectedItem).ExamId;
            }

            using (var form = new QuestionEditForm(defaultExamId: defaultExamId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadQuestionsForSelectedExam();
                    LoadExamsList();
                    RefreshDashboardStats();
                }
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null)
            {
                MessageBox.Show("Please select a question to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int questionId = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["colQId"].Value);
            var question = DatabaseHelper.GetQuestionById(questionId);
            if (question != null)
            {
                using (var form = new QuestionEditForm(question))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadQuestionsForSelectedExam();
                    }
                }
            }
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.CurrentRow == null)
            {
                MessageBox.Show("Please select a question to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int questionId = Convert.ToInt32(dgvQuestions.CurrentRow.Cells["colQId"].Value);
            int examId = ((Exam)cmbQuestionExamFilter.SelectedItem).ExamId;

            var res = MessageBox.Show("Are you sure you want to delete this question?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                if (DatabaseHelper.DeleteQuestion(questionId, examId, out string msg))
                {
                    MessageBox.Show("Question deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadQuestionsForSelectedExam();
                    LoadExamsList();
                    RefreshDashboardStats();
                }
                else
                {
                    MessageBox.Show(msg, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========================================================
        // TAB 4: MANAGE STUDENTS
        // ========================================================

        private void LoadStudentsList()
        {
            _allStudents = DatabaseHelper.GetAllStudents();
            FilterStudentsGrid();
        }

        private void FilterStudentsGrid()
        {
            if (_allStudents == null) return;
            string filter = txtSearchStudents.Text.Trim().ToLowerInvariant();

            dgvStudents.Rows.Clear();
            foreach (var stu in _allStudents)
            {
                if (string.IsNullOrEmpty(filter) ||
                    stu.FullName.ToLowerInvariant().Contains(filter) ||
                    stu.RollNo.ToLowerInvariant().Contains(filter) ||
                    stu.Email.ToLowerInvariant().Contains(filter) ||
                    stu.Username.ToLowerInvariant().Contains(filter))
                {
                    int rowIndex = dgvStudents.Rows.Add(
                        stu.UserId,
                        stu.RollNo,
                        stu.FullName,
                        stu.Username,
                        stu.Email,
                        stu.Phone,
                        stu.IsActive ? "Active" : "Deactivated",
                        stu.CreatedAt.ToString("dd-MMM-yyyy")
                    );

                    var activeCell = dgvStudents.Rows[rowIndex].Cells["colStudStatus"];
                    activeCell.Style.ForeColor = stu.IsActive ? UITheme.SuccessDark : UITheme.Danger;
                    activeCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        }

        private void txtSearchStudents_TextChanged(object sender, EventArgs e)
        {
            FilterStudentsGrid();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student from the list.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells["colStudId"].Value);
            var student = DatabaseHelper.GetUserById(studentId);
            if (student != null)
            {
                using (var form = new StudentEditForm(student))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadStudentsList();
                    }
                }
            }
        }

        private void btnResetStudentPwd_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells["colStudId"].Value);
            string studentName = dgvStudents.CurrentRow.Cells["colStudName"].Value.ToString();

            var promptRes = MessageBox.Show($"Reset password for '{studentName}' to default 'student123'?",
                "Confirm Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (promptRes == DialogResult.Yes)
            {
                if (DatabaseHelper.ResetStudentPassword(studentId, "student123", out string msg))
                {
                    MessageBox.Show($"Password for '{studentName}' has been reset to: student123", "Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msg, "Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells["colStudId"].Value);
            string studentName = dgvStudents.CurrentRow.Cells["colStudName"].Value.ToString();

            var res = MessageBox.Show($"Are you sure you want to permanently delete student account '{studentName}'?\n\nAll historical test results for this student will be deleted.",
                "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
            {
                if (DatabaseHelper.DeleteStudent(studentId, out string msg))
                {
                    MessageBox.Show("Student deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentsList();
                    RefreshDashboardStats();
                }
                else
                {
                    MessageBox.Show(msg, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ========================================================
        // TAB 5: RESULTS & REPORTS
        // ========================================================

        private void LoadAllAttempts()
        {
            int? examFilter = null;
            if (cmbReportExamFilter.SelectedItem != null)
            {
                int selId = ((Exam)cmbReportExamFilter.SelectedItem).ExamId;
                if (selId > 0) examFilter = selId;
            }

            var attempts = DatabaseHelper.GetAllAttempts(examId: examFilter);
            string filterText = txtSearchReportStudent.Text.Trim().ToLowerInvariant();

            dgvAllAttempts.Rows.Clear();
            foreach (var att in attempts)
            {
                if (string.IsNullOrEmpty(filterText) ||
                    att.StudentName.ToLowerInvariant().Contains(filterText) ||
                    att.RollNo.ToLowerInvariant().Contains(filterText) ||
                    att.ExamTitle.ToLowerInvariant().Contains(filterText) ||
                    att.SubjectCode.ToLowerInvariant().Contains(filterText))
                {
                    int rowIndex = dgvAllAttempts.Rows.Add(
                        att.AttemptId,
                        att.RollNo,
                        att.StudentName,
                        att.SubjectCode,
                        att.ExamTitle,
                        $"{att.Score:0.#} / {att.TotalQuestions}",
                        $"{att.Percentage:0.0}%",
                        att.IsPassed ? "PASSED" : "FAILED",
                        att.FormattedDuration,
                        att.StartTime.ToString("dd-MMM-yyyy hh:mm tt")
                    );

                    var statusCell = dgvAllAttempts.Rows[rowIndex].Cells["colRepStatus"];
                    statusCell.Style.ForeColor = att.IsPassed ? UITheme.SuccessDark : UITheme.Danger;
                    statusCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        }

        private void cmbReportExamFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllAttempts();
        }

        private void txtSearchReportStudent_TextChanged(object sender, EventArgs e)
        {
            LoadAllAttempts();
        }

        private void btnViewDetailedScorecard_Click(object sender, EventArgs e)
        {
            if (dgvAllAttempts.CurrentRow == null)
            {
                MessageBox.Show("Please select an attempt record from the table.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int attemptId = Convert.ToInt32(dgvAllAttempts.CurrentRow.Cells["colRepAttemptId"].Value);
            using (var rep = new ExamResultReportForm(attemptId))
            {
                rep.ShowDialog();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
