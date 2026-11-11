namespace NetworkedExamEngine.Forms
{
    partial class ExamTakingForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.pnlTimerBox = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimerTitle = new System.Windows.Forms.Label();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.lblExamTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlPalette = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMarkedStat = new System.Windows.Forms.Label();
            this.lblUnansweredStat = new System.Windows.Forms.Label();
            this.lblAnsweredStat = new System.Windows.Forms.Label();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.lblLegendReview = new System.Windows.Forms.Label();
            this.lblLegendUnans = new System.Windows.Forms.Label();
            this.lblLegendAns = new System.Windows.Forms.Label();
            this.lblPaletteTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlQuestionCard = new System.Windows.Forms.Panel();
            this.pnlActionBar = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnMarkReview = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.rdoOptionD = new System.Windows.Forms.RadioButton();
            this.rdoOptionC = new System.Windows.Forms.RadioButton();
            this.rdoOptionB = new System.Windows.Forms.RadioButton();
            this.rdoOptionA = new System.Windows.Forms.RadioButton();
            this.txtQuestionStatement = new System.Windows.Forms.TextBox();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.examTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlTopHeader.SuspendLayout();
            this.pnlTimerBox.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlQuestionCard.SuspendLayout();
            this.pnlActionBar.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlTopHeader.Controls.Add(this.pnlTimerBox);
            this.pnlTopHeader.Controls.Add(this.lblStudentInfo);
            this.pnlTopHeader.Controls.Add(this.lblExamTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Padding = new System.Windows.Forms.Padding(24, 12, 24, 12);
            this.pnlTopHeader.Size = new System.Drawing.Size(1084, 75);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // pnlTimerBox
            // 
            this.pnlTimerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTimerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlTimerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimerBox.Controls.Add(this.lblTimer);
            this.pnlTimerBox.Controls.Add(this.lblTimerTitle);
            this.pnlTimerBox.Location = new System.Drawing.Point(890, 10);
            this.pnlTimerBox.Name = "pnlTimerBox";
            this.pnlTimerBox.Size = new System.Drawing.Size(170, 55);
            this.pnlTimerBox.TabIndex = 2;
            // 
            // lblTimer
            // 
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTimer.Location = new System.Drawing.Point(0, 18);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(168, 35);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "15:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimerTitle
            // 
            this.lblTimerTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTimerTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblTimerTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTimerTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTimerTitle.Name = "lblTimerTitle";
            this.lblTimerTitle.Size = new System.Drawing.Size(168, 18);
            this.lblTimerTitle.TabIndex = 0;
            this.lblTimerTitle.Text = "TIME REMAINING";
            this.lblTimerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStudentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblStudentInfo.Location = new System.Drawing.Point(24, 42);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(262, 17);
            this.lblStudentInfo.TabIndex = 1;
            this.lblStudentInfo.Text = "Candidate: Rahul Sharma (Roll: MCA2026-001)";
            // 
            // lblExamTitle
            // 
            this.lblExamTitle.AutoSize = true;
            this.lblExamTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblExamTitle.ForeColor = System.Drawing.Color.White;
            this.lblExamTitle.Location = new System.Drawing.Point(22, 14);
            this.lblExamTitle.Name = "lblExamTitle";
            this.lblExamTitle.Size = new System.Drawing.Size(434, 25);
            this.lblExamTitle.TabIndex = 0;
            this.lblExamTitle.Text = "MCA-NET-501: C# & .NET 4.8 Framework Architecture";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.btnSubmit);
            this.pnlSidebar.Controls.Add(this.pnlPalette);
            this.pnlSidebar.Controls.Add(this.lblMarkedStat);
            this.pnlSidebar.Controls.Add(this.lblUnansweredStat);
            this.pnlSidebar.Controls.Add(this.lblAnsweredStat);
            this.pnlSidebar.Controls.Add(this.pnlLegend);
            this.pnlSidebar.Controls.Add(this.lblPaletteTitle);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Location = new System.Drawing.Point(804, 75);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(16);
            this.pnlSidebar.Size = new System.Drawing.Size(280, 636);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(16, 574);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(246, 44);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit Examination";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlPalette
            // 
            this.pnlPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPalette.AutoScroll = true;
            this.pnlPalette.Location = new System.Drawing.Point(16, 175);
            this.pnlPalette.Name = "pnlPalette";
            this.pnlPalette.Size = new System.Drawing.Size(246, 385);
            this.pnlPalette.TabIndex = 5;
            // 
            // lblMarkedStat
            // 
            this.lblMarkedStat.AutoSize = true;
            this.lblMarkedStat.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMarkedStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblMarkedStat.Location = new System.Drawing.Point(16, 148);
            this.lblMarkedStat.Name = "lblMarkedStat";
            this.lblMarkedStat.Size = new System.Drawing.Size(123, 15);
            this.lblMarkedStat.TabIndex = 4;
            this.lblMarkedStat.Text = "0 Marked for Review";
            // 
            // lblUnansweredStat
            // 
            this.lblUnansweredStat.AutoSize = true;
            this.lblUnansweredStat.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblUnansweredStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblUnansweredStat.Location = new System.Drawing.Point(135, 125);
            this.lblUnansweredStat.Name = "lblUnansweredStat";
            this.lblUnansweredStat.Size = new System.Drawing.Size(95, 15);
            this.lblUnansweredStat.TabIndex = 3;
            this.lblUnansweredStat.Text = "10 Unanswered";
            // 
            // lblAnsweredStat
            // 
            this.lblAnsweredStat.AutoSize = true;
            this.lblAnsweredStat.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblAnsweredStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblAnsweredStat.Location = new System.Drawing.Point(16, 125);
            this.lblAnsweredStat.Name = "lblAnsweredStat";
            this.lblAnsweredStat.Size = new System.Drawing.Size(76, 15);
            this.lblAnsweredStat.TabIndex = 2;
            this.lblAnsweredStat.Text = "0 Answered";
            // 
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLegend.Controls.Add(this.lblLegendReview);
            this.pnlLegend.Controls.Add(this.lblLegendUnans);
            this.pnlLegend.Controls.Add(this.lblLegendAns);
            this.pnlLegend.Location = new System.Drawing.Point(16, 42);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLegend.Size = new System.Drawing.Size(246, 72);
            this.pnlLegend.TabIndex = 1;
            // 
            // lblLegendReview
            // 
            this.lblLegendReview.AutoSize = true;
            this.lblLegendReview.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblLegendReview.Location = new System.Drawing.Point(10, 48);
            this.lblLegendReview.Name = "lblLegendReview";
            this.lblLegendReview.Size = new System.Drawing.Size(155, 13);
            this.lblLegendReview.TabIndex = 2;
            this.lblLegendReview.Text = "■ Yellow: Marked for Review";
            // 
            // lblLegendUnans
            // 
            this.lblLegendUnans.AutoSize = true;
            this.lblLegendUnans.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendUnans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLegendUnans.Location = new System.Drawing.Point(10, 28);
            this.lblLegendUnans.Name = "lblLegendUnans";
            this.lblLegendUnans.Size = new System.Drawing.Size(126, 13);
            this.lblLegendUnans.TabIndex = 1;
            this.lblLegendUnans.Text = "■ Gray: Not Answered";
            // 
            // lblLegendAns
            // 
            this.lblLegendAns.AutoSize = true;
            this.lblLegendAns.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLegendAns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.lblLegendAns.Location = new System.Drawing.Point(10, 8);
            this.lblLegendAns.Name = "lblLegendAns";
            this.lblLegendAns.Size = new System.Drawing.Size(107, 13);
            this.lblLegendAns.TabIndex = 0;
            this.lblLegendAns.Text = "■ Green: Answered";
            // 
            // lblPaletteTitle
            // 
            this.lblPaletteTitle.AutoSize = true;
            this.lblPaletteTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPaletteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblPaletteTitle.Location = new System.Drawing.Point(12, 15);
            this.lblPaletteTitle.Name = "lblPaletteTitle";
            this.lblPaletteTitle.Size = new System.Drawing.Size(126, 20);
            this.lblPaletteTitle.TabIndex = 0;
            this.lblPaletteTitle.Text = "Question Palette";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlMain.Controls.Add(this.pnlQuestionCard);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(24);
            this.pnlMain.Size = new System.Drawing.Size(804, 636);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlQuestionCard
            // 
            this.pnlQuestionCard.BackColor = System.Drawing.Color.White;
            this.pnlQuestionCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestionCard.Controls.Add(this.pnlActionBar);
            this.pnlQuestionCard.Controls.Add(this.grpOptions);
            this.pnlQuestionCard.Controls.Add(this.txtQuestionStatement);
            this.pnlQuestionCard.Controls.Add(this.prgProgress);
            this.pnlQuestionCard.Controls.Add(this.lblQuestionNumber);
            this.pnlQuestionCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuestionCard.Location = new System.Drawing.Point(24, 24);
            this.pnlQuestionCard.Name = "pnlQuestionCard";
            this.pnlQuestionCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlQuestionCard.Size = new System.Drawing.Size(756, 588);
            this.pnlQuestionCard.TabIndex = 0;
            // 
            // pnlActionBar
            // 
            this.pnlActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlActionBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActionBar.Controls.Add(this.btnNext);
            this.pnlActionBar.Controls.Add(this.btnMarkReview);
            this.pnlActionBar.Controls.Add(this.btnClear);
            this.pnlActionBar.Controls.Add(this.btnPrev);
            this.pnlActionBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActionBar.Location = new System.Drawing.Point(24, 508);
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Padding = new System.Windows.Forms.Padding(8);
            this.pnlActionBar.Size = new System.Drawing.Size(706, 54);
            this.pnlActionBar.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(540, 7);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 38);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next Question ▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMarkReview
            // 
            this.btnMarkReview.Location = new System.Drawing.Point(270, 7);
            this.btnMarkReview.Name = "btnMarkReview";
            this.btnMarkReview.Size = new System.Drawing.Size(160, 38);
            this.btnMarkReview.TabIndex = 2;
            this.btnMarkReview.Text = "☆ Mark for Review";
            this.btnMarkReview.UseVisualStyleBackColor = true;
            this.btnMarkReview.Click += new System.EventHandler(this.btnMarkReview_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Choice";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(10, 7);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(125, 38);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "◀ Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.Controls.Add(this.rdoOptionD);
            this.grpOptions.Controls.Add(this.rdoOptionC);
            this.grpOptions.Controls.Add(this.rdoOptionB);
            this.grpOptions.Controls.Add(this.rdoOptionA);
            this.grpOptions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.grpOptions.Location = new System.Drawing.Point(24, 200);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(16);
            this.grpOptions.Size = new System.Drawing.Size(706, 295);
            this.grpOptions.TabIndex = 3;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Select Your Answer Choice";
            // 
            // rdoOptionD
            // 
            this.rdoOptionD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOptionD.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoOptionD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOptionD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoOptionD.Location = new System.Drawing.Point(20, 225);
            this.rdoOptionD.Name = "rdoOptionD";
            this.rdoOptionD.Size = new System.Drawing.Size(666, 50);
            this.rdoOptionD.TabIndex = 3;
            this.rdoOptionD.TabStop = true;
            this.rdoOptionD.Text = "Option D text goes here...";
            this.rdoOptionD.UseVisualStyleBackColor = true;
            this.rdoOptionD.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoOptionC
            // 
            this.rdoOptionC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOptionC.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoOptionC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOptionC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoOptionC.Location = new System.Drawing.Point(20, 160);
            this.rdoOptionC.Name = "rdoOptionC";
            this.rdoOptionC.Size = new System.Drawing.Size(666, 50);
            this.rdoOptionC.TabIndex = 2;
            this.rdoOptionC.TabStop = true;
            this.rdoOptionC.Text = "Option C text goes here...";
            this.rdoOptionC.UseVisualStyleBackColor = true;
            this.rdoOptionC.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoOptionB
            // 
            this.rdoOptionB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOptionB.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoOptionB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOptionB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoOptionB.Location = new System.Drawing.Point(20, 95);
            this.rdoOptionB.Name = "rdoOptionB";
            this.rdoOptionB.Size = new System.Drawing.Size(666, 50);
            this.rdoOptionB.TabIndex = 1;
            this.rdoOptionB.TabStop = true;
            this.rdoOptionB.Text = "Option B text goes here...";
            this.rdoOptionB.UseVisualStyleBackColor = true;
            this.rdoOptionB.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // rdoOptionA
            // 
            this.rdoOptionA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoOptionA.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdoOptionA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoOptionA.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoOptionA.Location = new System.Drawing.Point(20, 30);
            this.rdoOptionA.Name = "rdoOptionA";
            this.rdoOptionA.Size = new System.Drawing.Size(666, 50);
            this.rdoOptionA.TabIndex = 0;
            this.rdoOptionA.TabStop = true;
            this.rdoOptionA.Text = "Option A text goes here...";
            this.rdoOptionA.UseVisualStyleBackColor = true;
            this.rdoOptionA.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // txtQuestionStatement
            // 
            this.txtQuestionStatement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestionStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtQuestionStatement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestionStatement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtQuestionStatement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtQuestionStatement.Location = new System.Drawing.Point(24, 75);
            this.txtQuestionStatement.Multiline = true;
            this.txtQuestionStatement.Name = "txtQuestionStatement";
            this.txtQuestionStatement.ReadOnly = true;
            this.txtQuestionStatement.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtQuestionStatement.Size = new System.Drawing.Size(706, 110);
            this.txtQuestionStatement.TabIndex = 2;
            this.txtQuestionStatement.Text = "Question text loading...";
            // 
            // prgProgress
            // 
            this.prgProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgProgress.Location = new System.Drawing.Point(24, 52);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(706, 8);
            this.prgProgress.TabIndex = 1;
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblQuestionNumber.Location = new System.Drawing.Point(20, 22);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(155, 21);
            this.lblQuestionNumber.TabIndex = 0;
            this.lblQuestionNumber.Text = "Question 1 of 10";
            // 
            // examTimer
            // 
            this.examTimer.Interval = 1000;
            this.examTimer.Tick += new System.EventHandler(this.examTimer_Tick);
            // 
            // ExamTakingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTopHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "ExamTakingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination in Progress - Assessment Engine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamTakingForm_FormClosing);
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlTimerBox.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlQuestionCard.ResumeLayout(false);
            this.pnlQuestionCard.PerformLayout();
            this.pnlActionBar.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Panel pnlTimerBox;
        private System.Windows.Forms.Label lblTimerTitle;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblPaletteTitle;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblLegendAns;
        private System.Windows.Forms.Label lblLegendUnans;
        private System.Windows.Forms.Label lblLegendReview;
        private System.Windows.Forms.Label lblAnsweredStat;
        private System.Windows.Forms.Label lblUnansweredStat;
        private System.Windows.Forms.Label lblMarkedStat;
        private System.Windows.Forms.FlowLayoutPanel pnlPalette;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlQuestionCard;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.TextBox txtQuestionStatement;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.RadioButton rdoOptionA;
        private System.Windows.Forms.RadioButton rdoOptionB;
        private System.Windows.Forms.RadioButton rdoOptionC;
        private System.Windows.Forms.RadioButton rdoOptionD;
        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnMarkReview;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer examTimer;
    }
}
