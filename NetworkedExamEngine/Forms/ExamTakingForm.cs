using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class ExamTakingForm : Form
    {
        private int _studentId;
        private int _examId;
        private Exam _exam;
        private User _student;
        private List<Question> _questions;
        private int _currentIndex = 0;

        private int _totalSecondsRemaining;
        private int _totalDurationSeconds;
        private bool _isSubmitting = false;

        private Button[] _paletteButtons;

        public ExamTakingForm(int studentId, int examId)
        {
            InitializeComponent();
            _studentId = studentId;
            _examId = examId;

            ApplyStyles();
            LoadExamAndQuestions();
        }

        private void ApplyStyles()
        {
            UITheme.StylePrimaryButton(btnNext);
            UITheme.StyleSecondaryButton(btnPrev);
            UITheme.StyleSecondaryButton(btnClear);
            UITheme.StyleSecondaryButton(btnMarkReview);
            UITheme.StyleSuccessButton(btnSubmit);
        }

        private void LoadExamAndQuestions()
        {
            _student = DatabaseHelper.GetUserById(_studentId);
            _exam = DatabaseHelper.GetExamById(_examId);

            if (_exam == null || _student == null)
            {
                MessageBox.Show("Failed to load examination details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Verify student hasn't already attempted
            if (DatabaseHelper.HasStudentAttemptedExam(_studentId, _examId))
            {
                MessageBox.Show("You have already completed this examination. Only one attempt is permitted per student.",
                    "Attempt Already Completed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            _questions = DatabaseHelper.GetQuestionsByExamId(_examId);
            if (_questions.Count == 0)
            {
                MessageBox.Show("This examination currently has no questions assigned by the administrator.",
                    "No Questions Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            // Initialize Header
            lblExamTitle.Text = $"{_exam.SubjectCode}: {_exam.Title}";
            lblStudentInfo.Text = $"Candidate: {_student.FullName} (Roll No: {_student.RollNo})";

            // Initialize Timer
            _totalDurationSeconds = _exam.DurationMinutes * 60;
            _totalSecondsRemaining = _totalDurationSeconds;
            UpdateTimerDisplay();
            examTimer.Start();

            // Setup Question Palette
            SetupQuestionPalette();

            // Load First Question
            _currentIndex = 0;
            DisplayCurrentQuestion();
        }

        private void SetupQuestionPalette()
        {
            pnlPalette.Controls.Clear();
            _paletteButtons = new Button[_questions.Count];

            for (int i = 0; i < _questions.Count; i++)
            {
                int qNum = i + 1;
                var btn = new Button
                {
                    Text = qNum.ToString(),
                    Width = 46,
                    Height = 42,
                    Margin = new Padding(4),
                    Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(241, 245, 249),
                    ForeColor = UITheme.TextPrimary,
                    Tag = i,
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
                btn.FlatAppearance.BorderSize = 1;

                btn.Click += PaletteButton_Click;
                _paletteButtons[i] = btn;
                pnlPalette.Controls.Add(btn);
            }
        }

        private void PaletteButton_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            var btn = (Button)sender;
            _currentIndex = (int)btn.Tag;
            DisplayCurrentQuestion();
        }

        private void DisplayCurrentQuestion()
        {
            if (_currentIndex < 0 || _currentIndex >= _questions.Count) return;

            var q = _questions[_currentIndex];

            lblQuestionNumber.Text = $"Question {_currentIndex + 1} of {_questions.Count}";
            prgProgress.Maximum = _questions.Count;
            prgProgress.Value = _currentIndex + 1;

            txtQuestionStatement.Text = q.QuestionText;
            rdoOptionA.Text = $"A) {q.OptionA}";
            rdoOptionB.Text = $"B) {q.OptionB}";
            rdoOptionC.Text = $"C) {q.OptionC}";
            rdoOptionD.Text = $"D) {q.OptionD}";

            // Restore selection
            rdoOptionA.Checked = false;
            rdoOptionB.Checked = false;
            rdoOptionC.Checked = false;
            rdoOptionD.Checked = false;

            if (q.SelectedOption.HasValue)
            {
                switch (char.ToUpper(q.SelectedOption.Value))
                {
                    case 'A': rdoOptionA.Checked = true; break;
                    case 'B': rdoOptionB.Checked = true; break;
                    case 'C': rdoOptionC.Checked = true; break;
                    case 'D': rdoOptionD.Checked = true; break;
                }
            }

            // Update Review button appearance
            if (q.IsMarkedForReview)
            {
                btnMarkReview.BackColor = UITheme.Warning;
                btnMarkReview.ForeColor = Color.White;
                btnMarkReview.Text = "★ Marked for Review";
            }
            else
            {
                btnMarkReview.BackColor = Color.White;
                btnMarkReview.ForeColor = UITheme.TextPrimary;
                btnMarkReview.Text = "☆ Mark for Review";
            }

            // Update Nav buttons
            btnPrev.Enabled = (_currentIndex > 0);
            btnNext.Text = (_currentIndex == _questions.Count - 1) ? "Finish ▶" : "Next Question ▶";

            UpdatePaletteButtonColors();
            UpdateStatsCounters();
        }

        private void SaveCurrentSelection()
        {
            if (_currentIndex < 0 || _currentIndex >= _questions.Count) return;

            var q = _questions[_currentIndex];

            if (rdoOptionA.Checked) q.SelectedOption = 'A';
            else if (rdoOptionB.Checked) q.SelectedOption = 'B';
            else if (rdoOptionC.Checked) q.SelectedOption = 'C';
            else if (rdoOptionD.Checked) q.SelectedOption = 'D';
            else q.SelectedOption = null;
        }

        private void UpdatePaletteButtonColors()
        {
            for (int i = 0; i < _questions.Count; i++)
            {
                var q = _questions[i];
                var btn = _paletteButtons[i];

                if (i == _currentIndex)
                {
                    btn.FlatAppearance.BorderSize = 3;
                    btn.FlatAppearance.BorderColor = UITheme.Accent;
                }
                else
                {
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
                }

                if (q.IsMarkedForReview)
                {
                    btn.BackColor = Color.FromArgb(245, 158, 11); // Amber
                    btn.ForeColor = Color.White;
                }
                else if (q.SelectedOption.HasValue)
                {
                    btn.BackColor = Color.FromArgb(16, 185, 129); // Emerald Green
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(241, 245, 249);
                    btn.ForeColor = UITheme.TextPrimary;
                }
            }
        }

        private void UpdateStatsCounters()
        {
            int answered = 0;
            int marked = 0;

            foreach (var q in _questions)
            {
                if (q.SelectedOption.HasValue) answered++;
                if (q.IsMarkedForReview) marked++;
            }

            int unanswered = _questions.Count - answered;

            lblAnsweredStat.Text = $"{answered} Answered";
            lblUnansweredStat.Text = $"{unanswered} Unanswered";
            lblMarkedStat.Text = $"{marked} Marked for Review";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            if (_currentIndex < _questions.Count - 1)
            {
                _currentIndex++;
                DisplayCurrentQuestion();
            }
            else
            {
                PromptSubmission(false);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            if (_currentIndex > 0)
            {
                _currentIndex--;
                DisplayCurrentQuestion();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rdoOptionA.Checked = false;
            rdoOptionB.Checked = false;
            rdoOptionC.Checked = false;
            rdoOptionD.Checked = false;
            if (_currentIndex >= 0 && _currentIndex < _questions.Count)
            {
                _questions[_currentIndex].SelectedOption = null;
            }
            UpdatePaletteButtonColors();
            UpdateStatsCounters();
        }

        private void btnMarkReview_Click(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            if (_currentIndex >= 0 && _currentIndex < _questions.Count)
            {
                _questions[_currentIndex].IsMarkedForReview = !_questions[_currentIndex].IsMarkedForReview;
            }
            DisplayCurrentQuestion();
        }

        private void Option_CheckedChanged(object sender, EventArgs e)
        {
            SaveCurrentSelection();
            UpdatePaletteButtonColors();
            UpdateStatsCounters();
        }

        private void examTimer_Tick(object sender, EventArgs e)
        {
            if (_totalSecondsRemaining > 0)
            {
                _totalSecondsRemaining--;
                UpdateTimerDisplay();
            }
            else
            {
                examTimer.Stop();
                MessageBox.Show("Time has expired! Your exam will now be automatically submitted.",
                    "Examination Time Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SubmitExam(true);
            }
        }

        private void UpdateTimerDisplay()
        {
            int mins = _totalSecondsRemaining / 60;
            int secs = _totalSecondsRemaining % 60;
            lblTimer.Text = $"{mins:D2}:{secs:D2}";

            // Turn red when remaining time is less than 5 minutes
            if (_totalSecondsRemaining < 300)
            {
                lblTimer.ForeColor = UITheme.Danger;
                pnlTimerBox.BackColor = Color.FromArgb(254, 226, 226);
            }
            else
            {
                lblTimer.ForeColor = UITheme.PrimaryDark;
                pnlTimerBox.BackColor = Color.FromArgb(241, 245, 249);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            PromptSubmission(false);
        }

        private void PromptSubmission(bool isTimeExpired)
        {
            SaveCurrentSelection();

            int answered = 0;
            foreach (var q in _questions)
            {
                if (q.SelectedOption.HasValue) answered++;
            }
            int unanswered = _questions.Count - answered;

            string promptMsg = $"Are you sure you want to submit your examination?\n\n" +
                               $"• Total Questions: {_questions.Count}\n" +
                               $"• Answered Questions: {answered}\n" +
                               $"• Unanswered Questions: {unanswered}\n\n" +
                               $"Notice: You are only allowed ONE attempt per exam. Once submitted, your answers cannot be altered.";

            var res = MessageBox.Show(promptMsg, "Confirm Final Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                SubmitExam(false);
            }
        }

        private void SubmitExam(bool isTimedOut)
        {
            if (_isSubmitting) return;
            _isSubmitting = true;
            examTimer.Stop();

            SaveCurrentSelection();

            int elapsedSeconds = _totalDurationSeconds - _totalSecondsRemaining;
            if (elapsedSeconds < 1) elapsedSeconds = 1;

            if (DatabaseHelper.SubmitExamAttempt(_studentId, _examId, _questions, elapsedSeconds, isTimedOut, out int attemptId, out string message))
            {
                MessageBox.Show("Your exam has been successfully evaluated! Opening your full performance scorecard.",
                    "Examination Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                using (var reportForm = new ExamResultReportForm(attemptId))
                {
                    reportForm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(message, "Submission Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _isSubmitting = false;
            }
        }

        private void ExamTakingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isSubmitting)
            {
                var res = MessageBox.Show("Warning: Are you sure you want to quit this examination? Unsaved progress will be lost and you will not be able to retake it.",
                    "Quit Exam Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
