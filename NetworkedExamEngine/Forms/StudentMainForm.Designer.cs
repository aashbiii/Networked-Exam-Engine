namespace NetworkedExamEngine.Forms
{
    partial class StudentMainForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblStudentRoll = new System.Windows.Forms.Label();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.tabStudent = new System.Windows.Forms.TabControl();
            this.tabAvailableExams = new System.Windows.Forms.TabPage();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.colExamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlExamsTop = new System.Windows.Forms.Panel();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.lblExamsInstructions = new System.Windows.Forms.Label();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.colHistAttemptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHistoryTop = new System.Windows.Forms.Panel();
            this.btnHistoryViewReport = new System.Windows.Forms.Button();
            this.lblHistoryTitle = new System.Windows.Forms.Label();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.pnlProfileCard = new System.Windows.Forms.Panel();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.lblProfPwdNote = new System.Windows.Forms.Label();
            this.txtProfNewPassword = new System.Windows.Forms.TextBox();
            this.lblProfNewPwd = new System.Windows.Forms.Label();
            this.txtProfPhone = new System.Windows.Forms.TextBox();
            this.lblProfPhone = new System.Windows.Forms.Label();
            this.txtProfEmail = new System.Windows.Forms.TextBox();
            this.lblProfEmail = new System.Windows.Forms.Label();
            this.txtProfRollNo = new System.Windows.Forms.TextBox();
            this.lblProfRoll = new System.Windows.Forms.Label();
            this.txtProfFullName = new System.Windows.Forms.TextBox();
            this.lblProfName = new System.Windows.Forms.Label();
            this.txtProfUsername = new System.Windows.Forms.TextBox();
            this.lblProfUser = new System.Windows.Forms.Label();
            this.lblProfileHeading = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.tabAvailableExams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.pnlExamsTop.SuspendLayout();
            this.tabHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.pnlHistoryTop.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.pnlProfileCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblStudentRoll);
            this.pnlHeader.Controls.Add(this.lblWelcomeTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(24, 14, 24, 14);
            this.pnlHeader.Size = new System.Drawing.Size(1044, 76);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(920, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 36);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblStudentRoll
            // 
            this.lblStudentRoll.AutoSize = true;
            this.lblStudentRoll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStudentRoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStudentRoll.Location = new System.Drawing.Point(24, 44);
            this.lblStudentRoll.Name = "lblStudentRoll";
            this.lblStudentRoll.Size = new System.Drawing.Size(306, 15);
            this.lblStudentRoll.TabIndex = 1;
            this.lblStudentRoll.Text = "Roll No: MCA2026-001 | Email: rahul.sharma@college.edu";
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeTitle.Location = new System.Drawing.Point(22, 14);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(248, 28);
            this.lblWelcomeTitle.TabIndex = 0;
            this.lblWelcomeTitle.Text = "Welcome, Rahul Sharma";
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.tabAvailableExams);
            this.tabStudent.Controls.Add(this.tabHistory);
            this.tabStudent.Controls.Add(this.tabProfile);
            this.tabStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabStudent.Location = new System.Drawing.Point(0, 76);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Drawing.Point(16, 8);
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(1044, 565);
            this.tabStudent.TabIndex = 1;
            // 
            // tabAvailableExams
            // 
            this.tabAvailableExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabAvailableExams.Controls.Add(this.dgvExams);
            this.tabAvailableExams.Controls.Add(this.pnlExamsTop);
            this.tabAvailableExams.Location = new System.Drawing.Point(4, 38);
            this.tabAvailableExams.Name = "tabAvailableExams";
            this.tabAvailableExams.Padding = new System.Windows.Forms.Padding(18);
            this.tabAvailableExams.Size = new System.Drawing.Size(1036, 523);
            this.tabAvailableExams.TabIndex = 0;
            this.tabAvailableExams.Text = "  Available Examinations  ";
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.AllowUserToDeleteRows = false;
            this.dgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExams.BackgroundColor = System.Drawing.Color.White;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExamId,
            this.colSubjectCode,
            this.colTitle,
            this.colDuration,
            this.colQuestions,
            this.colPassPercent,
            this.colStatus});
            this.dgvExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExams.Location = new System.Drawing.Point(18, 78);
            this.dgvExams.MultiSelect = false;
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.ReadOnly = true;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(1000, 427);
            this.dgvExams.TabIndex = 1;
            this.dgvExams.SelectionChanged += new System.EventHandler(this.dgvExams_SelectionChanged);
            // 
            // colExamId
            // 
            this.colExamId.FillWeight = 40F;
            this.colExamId.HeaderText = "Exam ID";
            this.colExamId.Name = "colExamId";
            this.colExamId.ReadOnly = true;
            this.colExamId.Visible = false;
            // 
            // colSubjectCode
            // 
            this.colSubjectCode.FillWeight = 80F;
            this.colSubjectCode.HeaderText = "Subject Code";
            this.colSubjectCode.Name = "colSubjectCode";
            this.colSubjectCode.ReadOnly = true;
            // 
            // colTitle
            // 
            this.colTitle.FillWeight = 220F;
            this.colTitle.HeaderText = "Examination Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.ReadOnly = true;
            // 
            // colDuration
            // 
            this.colDuration.FillWeight = 80F;
            this.colDuration.HeaderText = "Duration";
            this.colDuration.Name = "colDuration";
            this.colDuration.ReadOnly = true;
            // 
            // colQuestions
            // 
            this.colQuestions.FillWeight = 60F;
            this.colQuestions.HeaderText = "Questions";
            this.colQuestions.Name = "colQuestions";
            this.colQuestions.ReadOnly = true;
            // 
            // colPassPercent
            // 
            this.colPassPercent.FillWeight = 60F;
            this.colPassPercent.HeaderText = "Pass Mark";
            this.colPassPercent.Name = "colPassPercent";
            this.colPassPercent.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 140F;
            this.colStatus.HeaderText = "Attempt Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // pnlExamsTop
            // 
            this.pnlExamsTop.Controls.Add(this.btnViewReport);
            this.pnlExamsTop.Controls.Add(this.btnStartExam);
            this.pnlExamsTop.Controls.Add(this.lblExamsInstructions);
            this.pnlExamsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExamsTop.Location = new System.Drawing.Point(18, 18);
            this.pnlExamsTop.Name = "pnlExamsTop";
            this.pnlExamsTop.Size = new System.Drawing.Size(1000, 60);
            this.pnlExamsTop.TabIndex = 0;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewReport.Enabled = false;
            this.btnViewReport.Location = new System.Drawing.Point(580, 10);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(185, 40);
            this.btnViewReport.TabIndex = 2;
            this.btnViewReport.Text = "📄 View Scorecard";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // btnStartExam
            // 
            this.btnStartExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartExam.Location = new System.Drawing.Point(775, 10);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(225, 40);
            this.btnStartExam.TabIndex = 1;
            this.btnStartExam.Text = "🚀 Start Examination";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // lblExamsInstructions
            // 
            this.lblExamsInstructions.AutoSize = true;
            this.lblExamsInstructions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblExamsInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblExamsInstructions.Location = new System.Drawing.Point(0, 15);
            this.lblExamsInstructions.Name = "lblExamsInstructions";
            this.lblExamsInstructions.Size = new System.Drawing.Size(465, 17);
            this.lblExamsInstructions.TabIndex = 0;
            this.lblExamsInstructions.Text = "Select an examination below to view its details or begin your timed assessment.";
            // 
            // tabHistory
            // 
            this.tabHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabHistory.Controls.Add(this.dgvHistory);
            this.tabHistory.Controls.Add(this.pnlHistoryTop);
            this.tabHistory.Location = new System.Drawing.Point(4, 38);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(18);
            this.tabHistory.Size = new System.Drawing.Size(1036, 523);
            this.tabHistory.TabIndex = 1;
            this.tabHistory.Text = "  My Exam History & Reports  ";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHistAttemptId,
            this.colHistSubject,
            this.colHistTitle,
            this.colHistScore,
            this.colHistPercent,
            this.colHistStatus,
            this.colHistDuration,
            this.colHistDate});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(18, 78);
            this.dgvHistory.MultiSelect = false;
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistory.Size = new System.Drawing.Size(1000, 427);
            this.dgvHistory.TabIndex = 1;
            // 
            // colHistAttemptId
            // 
            this.colHistAttemptId.FillWeight = 40F;
            this.colHistAttemptId.HeaderText = "Attempt ID";
            this.colHistAttemptId.Name = "colHistAttemptId";
            this.colHistAttemptId.ReadOnly = true;
            this.colHistAttemptId.Visible = false;
            // 
            // colHistSubject
            // 
            this.colHistSubject.FillWeight = 80F;
            this.colHistSubject.HeaderText = "Subject Code";
            this.colHistSubject.Name = "colHistSubject";
            this.colHistSubject.ReadOnly = true;
            // 
            // colHistTitle
            // 
            this.colHistTitle.FillWeight = 200F;
            this.colHistTitle.HeaderText = "Exam Title";
            this.colHistTitle.Name = "colHistTitle";
            this.colHistTitle.ReadOnly = true;
            // 
            // colHistScore
            // 
            this.colHistScore.FillWeight = 70F;
            this.colHistScore.HeaderText = "Score";
            this.colHistScore.Name = "colHistScore";
            this.colHistScore.ReadOnly = true;
            // 
            // colHistPercent
            // 
            this.colHistPercent.FillWeight = 70F;
            this.colHistPercent.HeaderText = "Percentage";
            this.colHistPercent.Name = "colHistPercent";
            this.colHistPercent.ReadOnly = true;
            // 
            // colHistStatus
            // 
            this.colHistStatus.FillWeight = 80F;
            this.colHistStatus.HeaderText = "Result";
            this.colHistStatus.Name = "colHistStatus";
            this.colHistStatus.ReadOnly = true;
            // 
            // colHistDuration
            // 
            this.colHistDuration.FillWeight = 80F;
            this.colHistDuration.HeaderText = "Time Taken";
            this.colHistDuration.Name = "colHistDuration";
            this.colHistDuration.ReadOnly = true;
            // 
            // colHistDate
            // 
            this.colHistDate.FillWeight = 120F;
            this.colHistDate.HeaderText = "Date Submitted";
            this.colHistDate.Name = "colHistDate";
            this.colHistDate.ReadOnly = true;
            // 
            // pnlHistoryTop
            // 
            this.pnlHistoryTop.Controls.Add(this.btnHistoryViewReport);
            this.pnlHistoryTop.Controls.Add(this.lblHistoryTitle);
            this.pnlHistoryTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHistoryTop.Location = new System.Drawing.Point(18, 18);
            this.pnlHistoryTop.Name = "pnlHistoryTop";
            this.pnlHistoryTop.Size = new System.Drawing.Size(1000, 60);
            this.pnlHistoryTop.TabIndex = 0;
            // 
            // btnHistoryViewReport
            // 
            this.btnHistoryViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistoryViewReport.Location = new System.Drawing.Point(745, 10);
            this.btnHistoryViewReport.Name = "btnHistoryViewReport";
            this.btnHistoryViewReport.Size = new System.Drawing.Size(255, 40);
            this.btnHistoryViewReport.TabIndex = 1;
            this.btnHistoryViewReport.Text = "📊 View Detailed Review Report";
            this.btnHistoryViewReport.UseVisualStyleBackColor = true;
            this.btnHistoryViewReport.Click += new System.EventHandler(this.btnHistoryViewReport_Click);
            // 
            // lblHistoryTitle
            // 
            this.lblHistoryTitle.AutoSize = true;
            this.lblHistoryTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHistoryTitle.Location = new System.Drawing.Point(0, 15);
            this.lblHistoryTitle.Name = "lblHistoryTitle";
            this.lblHistoryTitle.Size = new System.Drawing.Size(434, 17);
            this.lblHistoryTitle.TabIndex = 0;
            this.lblHistoryTitle.Text = "All past completed exams with scores and question-by-question breakdown.";
            // 
            // tabProfile
            // 
            this.tabProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabProfile.Controls.Add(this.pnlProfileCard);
            this.tabProfile.Location = new System.Drawing.Point(4, 38);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(24);
            this.tabProfile.Size = new System.Drawing.Size(1036, 523);
            this.tabProfile.TabIndex = 2;
            this.tabProfile.Text = "  My Profile  ";
            // 
            // pnlProfileCard
            // 
            this.pnlProfileCard.BackColor = System.Drawing.Color.White;
            this.pnlProfileCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProfileCard.Controls.Add(this.btnUpdateProfile);
            this.pnlProfileCard.Controls.Add(this.lblProfPwdNote);
            this.pnlProfileCard.Controls.Add(this.txtProfNewPassword);
            this.pnlProfileCard.Controls.Add(this.lblProfNewPwd);
            this.pnlProfileCard.Controls.Add(this.txtProfPhone);
            this.pnlProfileCard.Controls.Add(this.lblProfPhone);
            this.pnlProfileCard.Controls.Add(this.txtProfEmail);
            this.pnlProfileCard.Controls.Add(this.lblProfEmail);
            this.pnlProfileCard.Controls.Add(this.txtProfRollNo);
            this.pnlProfileCard.Controls.Add(this.lblProfRoll);
            this.pnlProfileCard.Controls.Add(this.txtProfFullName);
            this.pnlProfileCard.Controls.Add(this.lblProfName);
            this.pnlProfileCard.Controls.Add(this.txtProfUsername);
            this.pnlProfileCard.Controls.Add(this.lblProfUser);
            this.pnlProfileCard.Controls.Add(this.lblProfileHeading);
            this.pnlProfileCard.Location = new System.Drawing.Point(30, 24);
            this.pnlProfileCard.Name = "pnlProfileCard";
            this.pnlProfileCard.Padding = new System.Windows.Forms.Padding(32);
            this.pnlProfileCard.Size = new System.Drawing.Size(650, 460);
            this.pnlProfileCard.TabIndex = 0;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(35, 385);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(260, 42);
            this.btnUpdateProfile.TabIndex = 14;
            this.btnUpdateProfile.Text = "Save Profile Changes";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // lblProfPwdNote
            // 
            this.lblProfPwdNote.AutoSize = true;
            this.lblProfPwdNote.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblProfPwdNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblProfPwdNote.Location = new System.Drawing.Point(35, 350);
            this.lblProfPwdNote.Name = "lblProfPwdNote";
            this.lblProfPwdNote.Size = new System.Drawing.Size(223, 13);
            this.lblProfPwdNote.TabIndex = 13;
            this.lblProfPwdNote.Text = "(Leave empty to keep current password)";
            // 
            // txtProfNewPassword
            // 
            this.txtProfNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfNewPassword.Location = new System.Drawing.Point(35, 322);
            this.txtProfNewPassword.Name = "txtProfNewPassword";
            this.txtProfNewPassword.Size = new System.Drawing.Size(570, 25);
            this.txtProfNewPassword.TabIndex = 12;
            this.txtProfNewPassword.UseSystemPasswordChar = true;
            // 
            // lblProfNewPwd
            // 
            this.lblProfNewPwd.AutoSize = true;
            this.lblProfNewPwd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfNewPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblProfNewPwd.Location = new System.Drawing.Point(32, 302);
            this.lblProfNewPwd.Name = "lblProfNewPwd";
            this.lblProfNewPwd.Size = new System.Drawing.Size(126, 15);
            this.lblProfNewPwd.TabIndex = 11;
            this.lblProfNewPwd.Text = "Change Password";
            // 
            // txtProfPhone
            // 
            this.txtProfPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfPhone.Location = new System.Drawing.Point(335, 255);
            this.txtProfPhone.Name = "txtProfPhone";
            this.txtProfPhone.Size = new System.Drawing.Size(270, 25);
            this.txtProfPhone.TabIndex = 10;
            // 
            // lblProfPhone
            // 
            this.lblProfPhone.AutoSize = true;
            this.lblProfPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblProfPhone.Location = new System.Drawing.Point(332, 235);
            this.lblProfPhone.Name = "lblProfPhone";
            this.lblProfPhone.Size = new System.Drawing.Size(91, 15);
            this.lblProfPhone.TabIndex = 9;
            this.lblProfPhone.Text = "Phone Number";
            // 
            // txtProfEmail
            // 
            this.txtProfEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfEmail.Location = new System.Drawing.Point(35, 255);
            this.txtProfEmail.Name = "txtProfEmail";
            this.txtProfEmail.Size = new System.Drawing.Size(275, 25);
            this.txtProfEmail.TabIndex = 8;
            // 
            // lblProfEmail
            // 
            this.lblProfEmail.AutoSize = true;
            this.lblProfEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblProfEmail.Location = new System.Drawing.Point(32, 235);
            this.lblProfEmail.Name = "lblProfEmail";
            this.lblProfEmail.Size = new System.Drawing.Size(83, 15);
            this.lblProfEmail.TabIndex = 7;
            this.lblProfEmail.Text = "Email Address";
            // 
            // txtProfRollNo
            // 
            this.txtProfRollNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtProfRollNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfRollNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfRollNo.Location = new System.Drawing.Point(335, 188);
            this.txtProfRollNo.Name = "txtProfRollNo";
            this.txtProfRollNo.ReadOnly = true;
            this.txtProfRollNo.Size = new System.Drawing.Size(270, 25);
            this.txtProfRollNo.TabIndex = 6;
            // 
            // lblProfRoll
            // 
            this.lblProfRoll.AutoSize = true;
            this.lblProfRoll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfRoll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblProfRoll.Location = new System.Drawing.Point(332, 168);
            this.lblProfRoll.Name = "lblProfRoll";
            this.lblProfRoll.Size = new System.Drawing.Size(126, 15);
            this.lblProfRoll.TabIndex = 5;
            this.lblProfRoll.Text = "Roll No / Student ID";
            // 
            // txtProfFullName
            // 
            this.txtProfFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfFullName.Location = new System.Drawing.Point(35, 188);
            this.txtProfFullName.Name = "txtProfFullName";
            this.txtProfFullName.Size = new System.Drawing.Size(275, 25);
            this.txtProfFullName.TabIndex = 4;
            // 
            // lblProfName
            // 
            this.lblProfName.AutoSize = true;
            this.lblProfName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblProfName.Location = new System.Drawing.Point(32, 168);
            this.lblProfName.Name = "lblProfName";
            this.lblProfName.Size = new System.Drawing.Size(62, 15);
            this.lblProfName.TabIndex = 3;
            this.lblProfName.Text = "Full Name";
            // 
            // txtProfUsername
            // 
            this.txtProfUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.txtProfUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtProfUsername.Location = new System.Drawing.Point(35, 120);
            this.txtProfUsername.Name = "txtProfUsername";
            this.txtProfUsername.ReadOnly = true;
            this.txtProfUsername.Size = new System.Drawing.Size(570, 25);
            this.txtProfUsername.TabIndex = 2;
            // 
            // lblProfUser
            // 
            this.lblProfUser.AutoSize = true;
            this.lblProfUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProfUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblProfUser.Location = new System.Drawing.Point(32, 100);
            this.lblProfUser.Name = "lblProfUser";
            this.lblProfUser.Size = new System.Drawing.Size(126, 15);
            this.lblProfUser.TabIndex = 1;
            this.lblProfUser.Text = "Username (Permanent)";
            // 
            // lblProfileHeading
            // 
            this.lblProfileHeading.AutoSize = true;
            this.lblProfileHeading.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProfileHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblProfileHeading.Location = new System.Drawing.Point(30, 28);
            this.lblProfileHeading.Name = "lblProfileHeading";
            this.lblProfileHeading.Size = new System.Drawing.Size(183, 25);
            this.lblProfileHeading.TabIndex = 0;
            this.lblProfileHeading.Text = "Student Credentials";
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 641);
            this.Controls.Add(this.tabStudent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Examination & Assessment Portal";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabStudent.ResumeLayout(false);
            this.tabAvailableExams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.pnlExamsTop.ResumeLayout(false);
            this.pnlExamsTop.PerformLayout();
            this.tabHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.pnlHistoryTop.ResumeLayout(false);
            this.pnlHistoryTop.PerformLayout();
            this.tabProfile.ResumeLayout(false);
            this.pnlProfileCard.ResumeLayout(false);
            this.pnlProfileCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblStudentRoll;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabStudent;
        private System.Windows.Forms.TabPage tabAvailableExams;
        private System.Windows.Forms.Panel pnlExamsTop;
        private System.Windows.Forms.Label lblExamsInstructions;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Panel pnlHistoryTop;
        private System.Windows.Forms.Label lblHistoryTitle;
        private System.Windows.Forms.Button btnHistoryViewReport;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistAttemptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistDate;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Panel pnlProfileCard;
        private System.Windows.Forms.Label lblProfileHeading;
        private System.Windows.Forms.Label lblProfUser;
        private System.Windows.Forms.TextBox txtProfUsername;
        private System.Windows.Forms.Label lblProfName;
        private System.Windows.Forms.TextBox txtProfFullName;
        private System.Windows.Forms.Label lblProfRoll;
        private System.Windows.Forms.TextBox txtProfRollNo;
        private System.Windows.Forms.Label lblProfEmail;
        private System.Windows.Forms.TextBox txtProfEmail;
        private System.Windows.Forms.Label lblProfPhone;
        private System.Windows.Forms.TextBox txtProfPhone;
        private System.Windows.Forms.Label lblProfNewPwd;
        private System.Windows.Forms.TextBox txtProfNewPassword;
        private System.Windows.Forms.Label lblProfPwdNote;
        private System.Windows.Forms.Button btnUpdateProfile;
    }
}
