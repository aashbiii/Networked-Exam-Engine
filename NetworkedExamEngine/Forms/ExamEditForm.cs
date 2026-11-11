using System;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class ExamEditForm : Form
    {
        private Exam _exam;
        private bool _isEditMode;

        public ExamEditForm(Exam exam = null)
        {
            InitializeComponent();
            _exam = exam;
            _isEditMode = exam != null && exam.ExamId > 0;

            UITheme.StylePrimaryButton(btnSave);
            UITheme.StyleSecondaryButton(btnCancel);

            if (_isEditMode)
            {
                lblHeaderTitle.Text = "Edit Examination";
                lblHeaderSubtitle.Text = "Modify parameters and settings for " + _exam.SubjectCode;
                txtTitle.Text = _exam.Title;
                txtSubjectCode.Text = _exam.SubjectCode;
                txtDescription.Text = _exam.Description;
                numDuration.Value = Math.Max(numDuration.Minimum, Math.Min(numDuration.Maximum, _exam.DurationMinutes));
                numTotalQuestions.Value = Math.Max(numTotalQuestions.Minimum, Math.Min(numTotalQuestions.Maximum, _exam.TotalQuestions));
                numPassPercentage.Value = Math.Max(numPassPercentage.Minimum, Math.Min(numPassPercentage.Maximum, _exam.PassPercentage));
                chkIsActive.Checked = _exam.IsActive;
            }
            else
            {
                lblHeaderTitle.Text = "Create New Examination";
                lblHeaderSubtitle.Text = "Setup a new test subject, duration, and passing criteria";
                numDuration.Value = 15;
                numTotalQuestions.Value = 10;
                numPassPercentage.Value = 50;
                chkIsActive.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string subjectCode = txtSubjectCode.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter the Exam Title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrEmpty(subjectCode))
            {
                MessageBox.Show("Please enter the Subject Code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubjectCode.Focus();
                return;
            }

            if (_exam == null)
            {
                _exam = new Exam();
            }

            _exam.Title = title;
            _exam.SubjectCode = subjectCode;
            _exam.Description = txtDescription.Text.Trim();
            _exam.DurationMinutes = (int)numDuration.Value;
            _exam.TotalQuestions = (int)numTotalQuestions.Value;
            _exam.PassPercentage = numPassPercentage.Value;
            _exam.IsActive = chkIsActive.Checked;

            btnSave.Enabled = false;
            if (DatabaseHelper.SaveExam(_exam, out string message))
            {
                MessageBox.Show("Exam saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
