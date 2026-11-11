using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class QuestionEditForm : Form
    {
        private Question _question;
        private int _defaultExamId;
        private bool _isEditMode;

        public QuestionEditForm(Question question = null, int defaultExamId = 0)
        {
            InitializeComponent();
            _question = question;
            _defaultExamId = defaultExamId;
            _isEditMode = question != null && question.QuestionId > 0;

            UITheme.StylePrimaryButton(btnSave);
            UITheme.StyleSecondaryButton(btnCancel);

            LoadExamsDropdown();

            cmbCorrectOption.Items.Clear();
            cmbCorrectOption.Items.Add("A");
            cmbCorrectOption.Items.Add("B");
            cmbCorrectOption.Items.Add("C");
            cmbCorrectOption.Items.Add("D");
            cmbCorrectOption.SelectedIndex = 0;

            if (_isEditMode)
            {
                lblHeaderTitle.Text = "Edit MCQ Question";
                lblHeaderSubtitle.Text = "Modify question statement, choices, and answer key";
                txtQuestionText.Text = _question.QuestionText;
                txtOptionA.Text = _question.OptionA;
                txtOptionB.Text = _question.OptionB;
                txtOptionC.Text = _question.OptionC;
                txtOptionD.Text = _question.OptionD;
                cmbCorrectOption.SelectedItem = _question.CorrectOption.ToString();
                numMarks.Value = Math.Max(1, _question.Marks);
                txtExplanation.Text = _question.Explanation;
                SelectExamInDropdown(_question.ExamId);
            }
            else
            {
                lblHeaderTitle.Text = "Add New MCQ Question";
                lblHeaderSubtitle.Text = "Define new question text with 4 multiple choice options";
                numMarks.Value = 1;
                if (_defaultExamId > 0)
                {
                    SelectExamInDropdown(_defaultExamId);
                }
            }
        }

        private void LoadExamsDropdown()
        {
            var exams = DatabaseHelper.GetAllExams();
            cmbExam.DisplayMember = "Title";
            cmbExam.ValueMember = "ExamId";
            cmbExam.DataSource = exams;
        }

        private void SelectExamInDropdown(int examId)
        {
            for (int i = 0; i < cmbExam.Items.Count; i++)
            {
                if (((Exam)cmbExam.Items[i]).ExamId == examId)
                {
                    cmbExam.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbExam.SelectedItem == null)
            {
                MessageBox.Show("Please select an Exam for this question.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string qText = txtQuestionText.Text.Trim();
            string optA = txtOptionA.Text.Trim();
            string optB = txtOptionB.Text.Trim();
            string optC = txtOptionC.Text.Trim();
            string optD = txtOptionD.Text.Trim();

            if (string.IsNullOrEmpty(qText))
            {
                MessageBox.Show("Please enter the Question statement.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuestionText.Focus();
                return;
            }

            if (string.IsNullOrEmpty(optA) || string.IsNullOrEmpty(optB) || string.IsNullOrEmpty(optC) || string.IsNullOrEmpty(optD))
            {
                MessageBox.Show("All four choices (Option A, B, C, D) are required for an MCQ question.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCorrectOption.SelectedItem == null)
            {
                MessageBox.Show("Please specify the Correct Option (A, B, C, or D).", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_question == null)
            {
                _question = new Question();
            }

            _question.ExamId = ((Exam)cmbExam.SelectedItem).ExamId;
            _question.QuestionText = qText;
            _question.OptionA = optA;
            _question.OptionB = optB;
            _question.OptionC = optC;
            _question.OptionD = optD;
            _question.CorrectOption = Convert.ToChar(cmbCorrectOption.SelectedItem.ToString());
            _question.Marks = (int)numMarks.Value;
            _question.Explanation = txtExplanation.Text.Trim();

            btnSave.Enabled = false;
            if (DatabaseHelper.SaveQuestion(_question, out string message))
            {
                MessageBox.Show("Question saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
