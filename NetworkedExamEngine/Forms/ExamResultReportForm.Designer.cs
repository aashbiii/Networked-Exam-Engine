namespace NetworkedExamEngine.Forms
{
    partial class ExamResultReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.pnlScorecard = new System.Windows.Forms.Panel();
            this.pnlMetricDuration = new System.Windows.Forms.Panel();
            this.lblDurationValue = new System.Windows.Forms.Label();
            this.lblDurationTitle = new System.Windows.Forms.Label();
            this.pnlMetricSkipped = new System.Windows.Forms.Panel();
            this.lblSkippedCount = new System.Windows.Forms.Label();
            this.lblSkippedTitle = new System.Windows.Forms.Label();
            this.pnlMetricWrong = new System.Windows.Forms.Panel();
            this.lblWrongCount = new System.Windows.Forms.Label();
            this.lblWrongTitle = new System.Windows.Forms.Label();
            this.pnlMetricCorrect = new System.Windows.Forms.Panel();
            this.lblCorrectCount = new System.Windows.Forms.Label();
            this.lblCorrectTitle = new System.Windows.Forms.Label();
            this.pnlMetricPercentage = new System.Windows.Forms.Panel();
            this.lblPercentageValue = new System.Windows.Forms.Label();
            this.lblPercentageTitle = new System.Windows.Forms.Label();
            this.pnlMetricScore = new System.Windows.Forms.Panel();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.pnlResultBadge = new System.Windows.Forms.Panel();
            this.lblResultStatus = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlQuestionsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlScorecard.SuspendLayout();
            this.pnlMetricDuration.SuspendLayout();
            this.pnlMetricSkipped.SuspendLayout();
            this.pnlMetricWrong.SuspendLayout();
            this.pnlMetricCorrect.SuspendLayout();
            this.pnlMetricPercentage.SuspendLayout();
            this.pnlMetricScore.SuspendLayout();
            this.pnlResultBadge.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.lblStudentInfo);
            this.pnlHeader.Controls.Add(this.lblExamTitle);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.pnlHeader.Size = new System.Drawing.Size(964, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblStudentInfo.Location = new System.Drawing.Point(520, 48);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(420, 36);
            this.lblStudentInfo.TabIndex = 3;
            this.lblStudentInfo.Text = "Student: Rahul Sharma (Roll: MCA-01) | Date: 22-Sep-2026";
            this.lblStudentInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExamTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblExamTitle.ForeColor = System.Drawing.Color.White;
            this.lblExamTitle.Location = new System.Drawing.Point(520, 16);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(420, 28);
            this.lblExamTitle.TabIndex = 2;
            this.lblExamTitle.Text = "MCA-NET-501: C# & .NET 4.8 Framework";
            this.lblExamTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 52);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(358, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Comprehensive review of student responses against answer key";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(342, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Examination Performance Report";
            // 
            // pnlScorecard
            // 
            this.pnlScorecard.BackColor = System.Drawing.Color.White;
            this.pnlScorecard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScorecard.Controls.Add(this.pnlMetricDuration);
            this.pnlScorecard.Controls.Add(this.pnlMetricSkipped);
            this.pnlScorecard.Controls.Add(this.pnlMetricWrong);
            this.pnlScorecard.Controls.Add(this.pnlMetricCorrect);
            this.pnlScorecard.Controls.Add(this.pnlMetricPercentage);
            this.pnlScorecard.Controls.Add(this.pnlMetricScore);
            this.pnlScorecard.Controls.Add(this.pnlResultBadge);
            this.pnlScorecard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlScorecard.Location = new System.Drawing.Point(0, 100);
            this.pnlScorecard.Name = "pnlScorecard";
            this.pnlScorecard.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
            this.pnlScorecard.Size = new System.Drawing.Size(964, 90);
            this.pnlScorecard.TabIndex = 1;
            // 
            // pnlMetricDuration
            // 
            this.pnlMetricDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMetricDuration.Controls.Add(this.lblDurationValue);
            this.pnlMetricDuration.Controls.Add(this.lblDurationTitle);
            this.pnlMetricDuration.Location = new System.Drawing.Point(810, 14);
            this.pnlMetricDuration.Name = "pnlMetricDuration";
            this.pnlMetricDuration.Size = new System.Drawing.Size(120, 60);
            this.pnlMetricDuration.TabIndex = 6;
            // 
            // lblDurationValue
            // 
            this.lblDurationValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDurationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDurationValue.Location = new System.Drawing.Point(0, 28);
            this.lblDurationValue.Name = "lblDurationValue";
            this.lblDurationValue.Size = new System.Drawing.Size(120, 24);
            this.lblDurationValue.TabIndex = 1;
            this.lblDurationValue.Text = "12m 45s";
            this.lblDurationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDurationTitle
            // 
            this.lblDurationTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDurationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDurationTitle.Location = new System.Drawing.Point(0, 6);
            this.lblDurationTitle.Name = "lblDurationTitle";
            this.lblDurationTitle.Size = new System.Drawing.Size(120, 18);
            this.lblDurationTitle.TabIndex = 0;
            this.lblDurationTitle.Text = "TIME TAKEN";
            this.lblDurationTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMetricSkipped
            // 
            this.pnlMetricSkipped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMetricSkipped.Controls.Add(this.lblSkippedCount);
            this.pnlMetricSkipped.Controls.Add(this.lblSkippedTitle);
            this.pnlMetricSkipped.Location = new System.Drawing.Point(680, 14);
            this.pnlMetricSkipped.Name = "pnlMetricSkipped";
            this.pnlMetricSkipped.Size = new System.Drawing.Size(115, 60);
            this.pnlMetricSkipped.TabIndex = 5;
            // 
            // lblSkippedCount
            // 
            this.lblSkippedCount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSkippedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblSkippedCount.Location = new System.Drawing.Point(0, 26);
            this.lblSkippedCount.Name = "lblSkippedCount";
            this.lblSkippedCount.Size = new System.Drawing.Size(115, 24);
            this.lblSkippedCount.TabIndex = 1;
            this.lblSkippedCount.Text = "0";
            this.lblSkippedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSkippedTitle
            // 
            this.lblSkippedTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSkippedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSkippedTitle.Location = new System.Drawing.Point(0, 6);
            this.lblSkippedTitle.Name = "lblSkippedTitle";
            this.lblSkippedTitle.Size = new System.Drawing.Size(115, 18);
            this.lblSkippedTitle.TabIndex = 0;
            this.lblSkippedTitle.Text = "SKIPPED (⊘)";
            this.lblSkippedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMetricWrong
            // 
            this.pnlMetricWrong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMetricWrong.Controls.Add(this.lblWrongCount);
            this.pnlMetricWrong.Controls.Add(this.lblWrongTitle);
            this.pnlMetricWrong.Location = new System.Drawing.Point(550, 14);
            this.pnlMetricWrong.Name = "pnlMetricWrong";
            this.pnlMetricWrong.Size = new System.Drawing.Size(115, 60);
            this.pnlMetricWrong.TabIndex = 4;
            // 
            // lblWrongCount
            // 
            this.lblWrongCount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblWrongCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblWrongCount.Location = new System.Drawing.Point(0, 26);
            this.lblWrongCount.Name = "lblWrongCount";
            this.lblWrongCount.Size = new System.Drawing.Size(115, 24);
            this.lblWrongCount.TabIndex = 1;
            this.lblWrongCount.Text = "2";
            this.lblWrongCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWrongTitle
            // 
            this.lblWrongTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblWrongTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWrongTitle.Location = new System.Drawing.Point(0, 6);
            this.lblWrongTitle.Name = "lblWrongTitle";
            this.lblWrongTitle.Size = new System.Drawing.Size(115, 18);
            this.lblWrongTitle.TabIndex = 0;
            this.lblWrongTitle.Text = "WRONG (✗)";
            this.lblWrongTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMetricCorrect
            // 
            this.pnlMetricCorrect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMetricCorrect.Controls.Add(this.lblCorrectCount);
            this.pnlMetricCorrect.Controls.Add(this.lblCorrectTitle);
            this.pnlMetricCorrect.Location = new System.Drawing.Point(420, 14);
            this.pnlMetricCorrect.Name = "pnlMetricCorrect";
            this.pnlMetricCorrect.Size = new System.Drawing.Size(115, 60);
            this.pnlMetricCorrect.TabIndex = 3;
            // 
            // lblCorrectCount
            // 
            this.lblCorrectCount.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCorrectCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblCorrectCount.Location = new System.Drawing.Point(0, 26);
            this.lblCorrectCount.Name = "lblCorrectCount";
            this.lblCorrectCount.Size = new System.Drawing.Size(115, 24);
            this.lblCorrectCount.TabIndex = 1;
            this.lblCorrectCount.Text = "8";
            this.lblCorrectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCorrectTitle
            // 
            this.lblCorrectTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCorrectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCorrectTitle.Location = new System.Drawing.Point(0, 6);
            this.lblCorrectTitle.Name = "lblCorrectTitle";
            this.lblCorrectTitle.Size = new System.Drawing.Size(115, 18);
            this.lblCorrectTitle.TabIndex = 0;
            this.lblCorrectTitle.Text = "CORRECT (✓)";
            this.lblCorrectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMetricPercentage
            // 
            this.pnlMetricPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMetricPercentage.Controls.Add(this.lblPercentageValue);
            this.pnlMetricPercentage.Controls.Add(this.lblPercentageTitle);
            this.pnlMetricPercentage.Location = new System.Drawing.Point(290, 14);
            this.pnlMetricPercentage.Name = "pnlMetricPercentage";
            this.pnlMetricPercentage.Size = new System.Drawing.Size(115, 60);
            this.pnlMetricPercentage.TabIndex = 2;
            // 
            // lblPercentageValue
            // 
            this.lblPercentageValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPercentageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblPercentageValue.Location = new System.Drawing.Point(0, 26);
            this.lblPercentageValue.Name = "lblPercentageValue";
            this.lblPercentageValue.Size = new System.Drawing.Size(115, 24);
            this.lblPercentageValue.TabIndex = 1;
            this.lblPercentageValue.Text = "80.0%";
            this.lblPercentageValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPercentageTitle
            // 
            this.lblPercentageTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblPercentageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPercentageTitle.Location = new System.Drawing.Point(0, 6);
            this.lblPercentageTitle.Name = "lblPercentageTitle";
            this.lblPercentageTitle.Size = new System.Drawing.Size(115, 18);
            this.lblPercentageTitle.TabIndex = 0;
            this.lblPercentageTitle.Text = "PERCENTAGE";
            this.lblPercentageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMetricScore
            // 
            this.pnlMetricScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMetricScore.Controls.Add(this.lblScoreValue);
            this.pnlMetricScore.Controls.Add(this.lblScoreTitle);
            this.pnlMetricScore.Location = new System.Drawing.Point(160, 14);
            this.pnlMetricScore.Name = "pnlMetricScore";
            this.pnlMetricScore.Size = new System.Drawing.Size(115, 60);
            this.pnlMetricScore.TabIndex = 1;
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblScoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblScoreValue.Location = new System.Drawing.Point(0, 26);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(115, 24);
            this.lblScoreValue.TabIndex = 1;
            this.lblScoreValue.Text = "8 / 10";
            this.lblScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblScoreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblScoreTitle.Location = new System.Drawing.Point(0, 6);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(115, 18);
            this.lblScoreTitle.TabIndex = 0;
            this.lblScoreTitle.Text = "TOTAL SCORE";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlResultBadge
            // 
            this.pnlResultBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlResultBadge.Controls.Add(this.lblResultStatus);
            this.pnlResultBadge.Location = new System.Drawing.Point(20, 14);
            this.pnlResultBadge.Name = "pnlResultBadge";
            this.pnlResultBadge.Size = new System.Drawing.Size(125, 60);
            this.pnlResultBadge.TabIndex = 0;
            // 
            // lblResultStatus
            // 
            this.lblResultStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblResultStatus.ForeColor = System.Drawing.Color.White;
            this.lblResultStatus.Location = new System.Drawing.Point(0, 0);
            this.lblResultStatus.Name = "lblResultStatus";
            this.lblResultStatus.Size = new System.Drawing.Size(125, 60);
            this.lblResultStatus.TabIndex = 0;
            this.lblResultStatus.Text = "PASSED";
            this.lblResultStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 655);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(18, 10, 18, 10);
            this.pnlBottom.Size = new System.Drawing.Size(964, 56);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(740, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close Performance Report";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlQuestionsContainer
            // 
            this.pnlQuestionsContainer.AutoScroll = true;
            this.pnlQuestionsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlQuestionsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestionsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlQuestionsContainer.Location = new System.Drawing.Point(0, 190);
            this.pnlQuestionsContainer.Name = "pnlQuestionsContainer";
            this.pnlQuestionsContainer.Padding = new System.Windows.Forms.Padding(20);
            this.pnlQuestionsContainer.Size = new System.Drawing.Size(964, 465);
            this.pnlQuestionsContainer.TabIndex = 3;
            this.pnlQuestionsContainer.WrapContents = false;
            // 
            // ExamResultReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(964, 711);
            this.Controls.Add(this.pnlQuestionsContainer);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlScorecard);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ExamResultReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detailed Examination Performance Report";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlScorecard.ResumeLayout(false);
            this.pnlMetricDuration.ResumeLayout(false);
            this.pnlMetricSkipped.ResumeLayout(false);
            this.pnlMetricWrong.ResumeLayout(false);
            this.pnlMetricCorrect.ResumeLayout(false);
            this.pnlMetricPercentage.ResumeLayout(false);
            this.pnlMetricScore.ResumeLayout(false);
            this.pnlResultBadge.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Panel pnlScorecard;
        private System.Windows.Forms.Panel pnlResultBadge;
        private System.Windows.Forms.Label lblResultStatus;
        private System.Windows.Forms.Panel pnlMetricScore;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Panel pnlMetricPercentage;
        private System.Windows.Forms.Label lblPercentageValue;
        private System.Windows.Forms.Label lblPercentageTitle;
        private System.Windows.Forms.Panel pnlMetricCorrect;
        private System.Windows.Forms.Label lblCorrectCount;
        private System.Windows.Forms.Label lblCorrectTitle;
        private System.Windows.Forms.Panel pnlMetricWrong;
        private System.Windows.Forms.Label lblWrongCount;
        private System.Windows.Forms.Label lblWrongTitle;
        private System.Windows.Forms.Panel pnlMetricSkipped;
        private System.Windows.Forms.Label lblSkippedCount;
        private System.Windows.Forms.Label lblSkippedTitle;
        private System.Windows.Forms.Panel pnlMetricDuration;
        private System.Windows.Forms.Label lblDurationValue;
        private System.Windows.Forms.Label lblDurationTitle;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel pnlQuestionsContainer;
    }
}
