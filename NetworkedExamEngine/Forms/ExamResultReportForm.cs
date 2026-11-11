using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Forms
{
    public partial class ExamResultReportForm : Form
    {
        private int _attemptId;
        private ExamAttempt _summary;
        private List<AttemptAnswer> _answers;

        public ExamResultReportForm(int attemptId)
        {
            InitializeComponent();
            _attemptId = attemptId;
            UITheme.StylePrimaryButton(btnClose);
            LoadReportData();
        }

        private void LoadReportData()
        {
            _summary = DatabaseHelper.GetAttemptSummary(_attemptId);
            if (_summary == null)
            {
                MessageBox.Show("Attempt record could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _answers = DatabaseHelper.GetAttemptAnswersReview(_attemptId);

            // Populate Header
            lblExamTitle.Text = $"{_summary.SubjectCode}: {_summary.ExamTitle}";
            lblStudentInfo.Text = $"Student: {_summary.StudentName} (Roll No: {_summary.RollNo}) | Date: {_summary.StartTime:dd-MMM-yyyy hh:mm tt}";

            // Populate Scorecard
            lblScoreValue.Text = $"{_summary.Score:0.#} / {_summary.TotalQuestions}";
            lblPercentageValue.Text = $"{_summary.Percentage:0.0}%";
            lblDurationValue.Text = _summary.FormattedDuration;
            lblCorrectCount.Text = _summary.CorrectAnswers.ToString();
            lblWrongCount.Text = _summary.WrongAnswers.ToString();
            int skipped = _summary.TotalQuestions - _summary.AnsweredQuestions;
            lblSkippedCount.Text = Math.Max(0, skipped).ToString();

            if (_summary.IsPassed)
            {
                pnlResultBadge.BackColor = UITheme.Success;
                lblResultStatus.Text = "PASSED";
            }
            else
            {
                pnlResultBadge.BackColor = UITheme.Danger;
                lblResultStatus.Text = "FAILED";
            }

            // Populate Question-by-Question Review Breakdown
            PopulateQuestionBreakdown();
        }

        private void PopulateQuestionBreakdown()
        {
            pnlQuestionsContainer.SuspendLayout();
            pnlQuestionsContainer.Controls.Clear();

            if (_answers == null || _answers.Count == 0)
            {
                var lblEmpty = new Label
                {
                    Text = "No question answers recorded for this attempt.",
                    Font = UITheme.FontRegular,
                    ForeColor = UITheme.TextSecondary,
                    AutoSize = true,
                    Padding = new Padding(20)
                };
                pnlQuestionsContainer.Controls.Add(lblEmpty);
                pnlQuestionsContainer.ResumeLayout();
                return;
            }

            int questionWidth = pnlQuestionsContainer.ClientSize.Width - 35;
            if (questionWidth < 600) questionWidth = 600;

            for (int i = 0; i < _answers.Count; i++)
            {
                var ans = _answers[i];
                var card = CreateQuestionCard(ans, i + 1, questionWidth);
                pnlQuestionsContainer.Controls.Add(card);
            }

            pnlQuestionsContainer.ResumeLayout();
        }

        private Panel CreateQuestionCard(AttemptAnswer ans, int qNum, int width)
        {
            var pnlCard = new Panel
            {
                Width = width,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 0, 16),
                Padding = new Padding(18),
                BorderStyle = BorderStyle.FixedSingle
            };

            int currentY = 16;

            // 1. Top Header Row: "Question N of Total" + Status Badge
            var lblQHeader = new Label
            {
                Text = $"Question {qNum} of {_answers.Count}",
                Font = UITheme.FontTitle,
                ForeColor = UITheme.TextSecondary,
                Location = new Point(18, currentY),
                AutoSize = true
            };
            pnlCard.Controls.Add(lblQHeader);

            // Status Badge
            var lblBadge = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Padding = new Padding(8, 3, 8, 3),
                Location = new Point(width - 210, currentY - 2)
            };

            if (!ans.SelectedOption.HasValue)
            {
                lblBadge.Text = "⊘ NOT ANSWERED (0)";
                lblBadge.BackColor = Color.FromArgb(254, 243, 199);
                lblBadge.ForeColor = Color.FromArgb(180, 83, 9);
            }
            else if (ans.IsCorrect)
            {
                lblBadge.Text = "✓ CORRECT (+1 Mark)";
                lblBadge.BackColor = Color.FromArgb(220, 252, 231);
                lblBadge.ForeColor = Color.FromArgb(21, 128, 61);
            }
            else
            {
                lblBadge.Text = "✗ INCORRECT (0 Marks)";
                lblBadge.BackColor = Color.FromArgb(254, 226, 226);
                lblBadge.ForeColor = Color.FromArgb(185, 28, 28);
            }
            pnlCard.Controls.Add(lblBadge);

            currentY += 32;

            // 2. Question Text
            var lblQText = new Label
            {
                Text = ans.QuestionText,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold),
                ForeColor = UITheme.TextPrimary,
                Location = new Point(18, currentY),
                Width = width - 36,
                AutoSize = true,
                MaximumSize = new Size(width - 36, 0)
            };
            pnlCard.Controls.Add(lblQText);
            currentY += lblQText.PreferredHeight + 14;

            // 3. Choices Preview
            string[] opts = new string[]
            {
                $"A) {ans.OptionA}",
                $"B) {ans.OptionB}",
                $"C) {ans.OptionC}",
                $"D) {ans.OptionD}"
            };

            foreach (var opt in opts)
            {
                var lblOpt = new Label
                {
                    Text = opt,
                    Font = UITheme.FontRegular,
                    ForeColor = UITheme.TextSecondary,
                    Location = new Point(28, currentY),
                    Width = width - 56,
                    AutoSize = true,
                    MaximumSize = new Size(width - 56, 0)
                };
                pnlCard.Controls.Add(lblOpt);
                currentY += lblOpt.PreferredHeight + 4;
            }

            currentY += 8;

            // 4. Comparison Box (Student Answer vs Correct Answer)
            var pnlComparison = new Panel
            {
                Location = new Point(18, currentY),
                Width = width - 36,
                BackColor = Color.FromArgb(248, 250, 252),
                Padding = new Padding(12),
                BorderStyle = BorderStyle.FixedSingle
            };

            int compY = 8;

            // Student's Answer Line
            var lblYourAnswerTitle = new Label
            {
                Text = "Your Answer: ",
                Font = UITheme.FontRegularBold,
                ForeColor = UITheme.TextPrimary,
                Location = new Point(10, compY),
                AutoSize = true
            };
            var lblYourAnswerVal = new Label
            {
                Text = ans.SelectedOptionText,
                Font = UITheme.FontRegular,
                ForeColor = !ans.SelectedOption.HasValue ? UITheme.Warning : (ans.IsCorrect ? UITheme.SuccessDark : UITheme.Danger),
                Location = new Point(120, compY),
                AutoSize = true,
                MaximumSize = new Size(pnlComparison.Width - 140, 0)
            };
            pnlComparison.Controls.Add(lblYourAnswerTitle);
            pnlComparison.Controls.Add(lblYourAnswerVal);
            compY += Math.Max(lblYourAnswerVal.PreferredHeight, 20) + 6;

            // Correct Answer Line
            var lblCorrectAnswerTitle = new Label
            {
                Text = "Correct Answer: ",
                Font = UITheme.FontRegularBold,
                ForeColor = UITheme.TextPrimary,
                Location = new Point(10, compY),
                AutoSize = true
            };
            var lblCorrectAnswerVal = new Label
            {
                Text = ans.CorrectOptionText,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = UITheme.SuccessDark,
                Location = new Point(120, compY),
                AutoSize = true,
                MaximumSize = new Size(pnlComparison.Width - 140, 0)
            };
            pnlComparison.Controls.Add(lblCorrectAnswerTitle);
            pnlComparison.Controls.Add(lblCorrectAnswerVal);
            compY += Math.Max(lblCorrectAnswerVal.PreferredHeight, 20) + 8;

            // Explanation Line (if available)
            if (!string.IsNullOrEmpty(ans.Explanation))
            {
                var lblExplTitle = new Label
                {
                    Text = "Explanation: ",
                    Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Bold),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Location = new Point(10, compY),
                    AutoSize = true
                };
                var lblExplVal = new Label
                {
                    Text = ans.Explanation,
                    Font = UITheme.FontSmall,
                    ForeColor = Color.FromArgb(71, 85, 105),
                    Location = new Point(120, compY),
                    AutoSize = true,
                    MaximumSize = new Size(pnlComparison.Width - 140, 0)
                };
                pnlComparison.Controls.Add(lblExplTitle);
                pnlComparison.Controls.Add(lblExplVal);
                compY += lblExplVal.PreferredHeight + 6;
            }

            pnlComparison.Height = compY + 8;
            pnlCard.Controls.Add(pnlComparison);
            currentY += pnlComparison.Height + 16;

            pnlCard.Height = currentY;
            return pnlCard;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
