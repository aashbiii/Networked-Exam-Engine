namespace NetworkedExamEngine.Forms
{
    partial class AdminMainForm
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
            this.lblAdminInfo = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.dgvRecentAttempts = new System.Windows.Forms.DataGridView();
            this.colRecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlRecentHeader = new System.Windows.Forms.Panel();
            this.btnQuickAddQuestion = new System.Windows.Forms.Button();
            this.btnQuickAddExam = new System.Windows.Forms.Button();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.pnlKpiCards = new System.Windows.Forms.Panel();
            this.pnlCard5 = new System.Windows.Forms.Panel();
            this.lblStatPassRate = new System.Windows.Forms.Label();
            this.lblCard5Title = new System.Windows.Forms.Label();
            this.pnlCard4 = new System.Windows.Forms.Panel();
            this.lblStatAttempts = new System.Windows.Forms.Label();
            this.lblCard4Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblStatStudents = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblStatQuestions = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblStatExams = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.tabExams = new System.Windows.Forms.TabPage();
            this.dgvExams = new System.Windows.Forms.DataGridView();
            this.colExId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlExamsToolbar = new System.Windows.Forms.Panel();
            this.txtSearchExams = new System.Windows.Forms.TextBox();
            this.lblSearchExams = new System.Windows.Forms.Label();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnEditExam = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.tabQuestions = new System.Windows.Forms.TabPage();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.colQId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQOptA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQOptB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQOptC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQOptD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQCorrect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQMarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQExplanation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlQuestionsToolbar = new System.Windows.Forms.Panel();
            this.txtSearchQuestions = new System.Windows.Forms.TextBox();
            this.lblSearchQuestions = new System.Windows.Forms.Label();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.btnEditQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.cmbQuestionExamFilter = new System.Windows.Forms.ComboBox();
            this.lblFilterExam = new System.Windows.Forms.Label();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colStudId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStudentsToolbar = new System.Windows.Forms.Panel();
            this.txtSearchStudents = new System.Windows.Forms.TextBox();
            this.lblSearchStudents = new System.Windows.Forms.Label();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnResetStudentPwd = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.dgvAllAttempts = new System.Windows.Forms.DataGridView();
            this.colRepAttemptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepRoll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRepDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlReportsToolbar = new System.Windows.Forms.Panel();
            this.btnViewDetailedScorecard = new System.Windows.Forms.Button();
            this.txtSearchReportStudent = new System.Windows.Forms.TextBox();
            this.lblSearchReportStudent = new System.Windows.Forms.Label();
            this.cmbReportExamFilter = new System.Windows.Forms.ComboBox();
            this.lblReportExam = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentAttempts)).BeginInit();
            this.pnlRecentHeader.SuspendLayout();
            this.pnlKpiCards.SuspendLayout();
            this.pnlCard5.SuspendLayout();
            this.pnlCard4.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.tabExams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).BeginInit();
            this.pnlExamsToolbar.SuspendLayout();
            this.tabQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.pnlQuestionsToolbar.SuspendLayout();
            this.tabStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.pnlStudentsToolbar.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAttempts)).BeginInit();
            this.pnlReportsToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.btnLogout);
            this.pnlHeader.Controls.Add(this.lblAdminInfo);
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(24, 14, 24, 14);
            this.pnlHeader.Size = new System.Drawing.Size(1164, 80);
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
            this.btnLogout.Location = new System.Drawing.Point(1040, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Sign Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblAdminInfo
            // 
            this.lblAdminInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAdminInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblAdminInfo.Location = new System.Drawing.Point(640, 29);
            this.lblAdminInfo.Name = "lblAdminInfo";
            this.lblAdminInfo.Size = new System.Drawing.Size(380, 20);
            this.lblAdminInfo.TabIndex = 2;
            this.lblAdminInfo.Text = "Logged in as: Administrator";
            this.lblAdminInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 46);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(434, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Centralized Assessment Management, Question Banking, and Performance Metrics";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(395, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Examination Engine Admin Console";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabDashboard);
            this.tabAdmin.Controls.Add(this.tabExams);
            this.tabAdmin.Controls.Add(this.tabQuestions);
            this.tabAdmin.Controls.Add(this.tabStudents);
            this.tabAdmin.Controls.Add(this.tabReports);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabAdmin.Location = new System.Drawing.Point(0, 80);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Drawing.Point(18, 8);
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(1164, 621);
            this.tabAdmin.TabIndex = 1;
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabDashboard.Controls.Add(this.dgvRecentAttempts);
            this.tabDashboard.Controls.Add(this.pnlRecentHeader);
            this.tabDashboard.Controls.Add(this.pnlKpiCards);
            this.tabDashboard.Location = new System.Drawing.Point(4, 38);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(20);
            this.tabDashboard.Size = new System.Drawing.Size(1156, 579);
            this.tabDashboard.TabIndex = 0;
            this.tabDashboard.Text = "  📊 Overview Dashboard  ";
            // 
            // dgvRecentAttempts
            // 
            this.dgvRecentAttempts.AllowUserToAddRows = false;
            this.dgvRecentAttempts.AllowUserToDeleteRows = false;
            this.dgvRecentAttempts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentAttempts.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentAttempts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentAttempts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecId,
            this.colRecRoll,
            this.colRecStudent,
            this.colRecSubject,
            this.colRecTitle,
            this.colRecScore,
            this.colRecPercent,
            this.colRecStatus,
            this.colRecDate});
            this.dgvRecentAttempts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentAttempts.Location = new System.Drawing.Point(20, 180);
            this.dgvRecentAttempts.MultiSelect = false;
            this.dgvRecentAttempts.Name = "dgvRecentAttempts";
            this.dgvRecentAttempts.ReadOnly = true;
            this.dgvRecentAttempts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentAttempts.Size = new System.Drawing.Size(1116, 379);
            this.dgvRecentAttempts.TabIndex = 2;
            // 
            // colRecId
            // 
            this.colRecId.FillWeight = 40F;
            this.colRecId.HeaderText = "ID";
            this.colRecId.Name = "colRecId";
            this.colRecId.ReadOnly = true;
            this.colRecId.Visible = false;
            // 
            // colRecRoll
            // 
            this.colRecRoll.FillWeight = 90F;
            this.colRecRoll.HeaderText = "Roll No";
            this.colRecRoll.Name = "colRecRoll";
            this.colRecRoll.ReadOnly = true;
            // 
            // colRecStudent
            // 
            this.colRecStudent.FillWeight = 130F;
            this.colRecStudent.HeaderText = "Student Name";
            this.colRecStudent.Name = "colRecStudent";
            this.colRecStudent.ReadOnly = true;
            // 
            // colRecSubject
            // 
            this.colRecSubject.FillWeight = 80F;
            this.colRecSubject.HeaderText = "Subject";
            this.colRecSubject.Name = "colRecSubject";
            this.colRecSubject.ReadOnly = true;
            // 
            // colRecTitle
            // 
            this.colRecTitle.FillWeight = 180F;
            this.colRecTitle.HeaderText = "Exam Title";
            this.colRecTitle.Name = "colRecTitle";
            this.colRecTitle.ReadOnly = true;
            // 
            // colRecScore
            // 
            this.colRecScore.FillWeight = 70F;
            this.colRecScore.HeaderText = "Score";
            this.colRecScore.Name = "colRecScore";
            this.colRecScore.ReadOnly = true;
            // 
            // colRecPercent
            // 
            this.colRecPercent.FillWeight = 70F;
            this.colRecPercent.HeaderText = "Percentage";
            this.colRecPercent.Name = "colRecPercent";
            this.colRecPercent.ReadOnly = true;
            // 
            // colRecStatus
            // 
            this.colRecStatus.FillWeight = 80F;
            this.colRecStatus.HeaderText = "Result";
            this.colRecStatus.Name = "colRecStatus";
            this.colRecStatus.ReadOnly = true;
            // 
            // colRecDate
            // 
            this.colRecDate.FillWeight = 110F;
            this.colRecDate.HeaderText = "Date Submitted";
            this.colRecDate.Name = "colRecDate";
            this.colRecDate.ReadOnly = true;
            // 
            // pnlRecentHeader
            // 
            this.pnlRecentHeader.Controls.Add(this.btnQuickAddQuestion);
            this.pnlRecentHeader.Controls.Add(this.btnQuickAddExam);
            this.pnlRecentHeader.Controls.Add(this.lblRecentTitle);
            this.pnlRecentHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRecentHeader.Location = new System.Drawing.Point(20, 130);
            this.pnlRecentHeader.Name = "pnlRecentHeader";
            this.pnlRecentHeader.Size = new System.Drawing.Size(1116, 50);
            this.pnlRecentHeader.TabIndex = 1;
            // 
            // btnQuickAddQuestion
            // 
            this.btnQuickAddQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickAddQuestion.Location = new System.Drawing.Point(950, 8);
            this.btnQuickAddQuestion.Name = "btnQuickAddQuestion";
            this.btnQuickAddQuestion.Size = new System.Drawing.Size(160, 34);
            this.btnQuickAddQuestion.TabIndex = 2;
            this.btnQuickAddQuestion.Text = "+ Add Question";
            this.btnQuickAddQuestion.UseVisualStyleBackColor = true;
            this.btnQuickAddQuestion.Click += new System.EventHandler(this.btnQuickAddQuestion_Click);
            // 
            // btnQuickAddExam
            // 
            this.btnQuickAddExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuickAddExam.Location = new System.Drawing.Point(780, 8);
            this.btnQuickAddExam.Name = "btnQuickAddExam";
            this.btnQuickAddExam.Size = new System.Drawing.Size(160, 34);
            this.btnQuickAddExam.TabIndex = 1;
            this.btnQuickAddExam.Text = "+ Create New Exam";
            this.btnQuickAddExam.UseVisualStyleBackColor = true;
            this.btnQuickAddExam.Click += new System.EventHandler(this.btnQuickAddExam_Click);
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.AutoSize = true;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRecentTitle.Location = new System.Drawing.Point(0, 14);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(262, 21);
            this.lblRecentTitle.TabIndex = 0;
            this.lblRecentTitle.Text = "Recent Examination Submissions";
            // 
            // pnlKpiCards
            // 
            this.pnlKpiCards.Controls.Add(this.pnlCard5);
            this.pnlKpiCards.Controls.Add(this.pnlCard4);
            this.pnlKpiCards.Controls.Add(this.pnlCard3);
            this.pnlKpiCards.Controls.Add(this.pnlCard2);
            this.pnlKpiCards.Controls.Add(this.pnlCard1);
            this.pnlKpiCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlKpiCards.Location = new System.Drawing.Point(20, 20);
            this.pnlKpiCards.Name = "pnlKpiCards";
            this.pnlKpiCards.Size = new System.Drawing.Size(1116, 110);
            this.pnlKpiCards.TabIndex = 0;
            // 
            // pnlCard5
            // 
            this.pnlCard5.BackColor = System.Drawing.Color.White;
            this.pnlCard5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard5.Controls.Add(this.lblStatPassRate);
            this.pnlCard5.Controls.Add(this.lblCard5Title);
            this.pnlCard5.Location = new System.Drawing.Point(896, 0);
            this.pnlCard5.Name = "pnlCard5";
            this.pnlCard5.Padding = new System.Windows.Forms.Padding(14);
            this.pnlCard5.Size = new System.Drawing.Size(210, 95);
            this.pnlCard5.TabIndex = 4;
            // 
            // lblStatPassRate
            // 
            this.lblStatPassRate.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatPassRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblStatPassRate.Location = new System.Drawing.Point(14, 38);
            this.lblStatPassRate.Name = "lblStatPassRate";
            this.lblStatPassRate.Size = new System.Drawing.Size(180, 42);
            this.lblStatPassRate.TabIndex = 1;
            this.lblStatPassRate.Text = "85.0%";
            // 
            // lblCard5Title
            // 
            this.lblCard5Title.AutoSize = true;
            this.lblCard5Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCard5Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCard5Title.Location = new System.Drawing.Point(14, 14);
            this.lblCard5Title.Name = "lblCard5Title";
            this.lblCard5Title.Size = new System.Drawing.Size(107, 15);
            this.lblCard5Title.TabIndex = 0;
            this.lblCard5Title.Text = "OVERALL PASS RATE";
            // 
            // pnlCard4
            // 
            this.pnlCard4.BackColor = System.Drawing.Color.White;
            this.pnlCard4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard4.Controls.Add(this.lblStatAttempts);
            this.pnlCard4.Controls.Add(this.lblCard4Title);
            this.pnlCard4.Location = new System.Drawing.Point(672, 0);
            this.pnlCard4.Name = "pnlCard4";
            this.pnlCard4.Padding = new System.Windows.Forms.Padding(14);
            this.pnlCard4.Size = new System.Drawing.Size(210, 95);
            this.pnlCard4.TabIndex = 3;
            // 
            // lblStatAttempts
            // 
            this.lblStatAttempts.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatAttempts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblStatAttempts.Location = new System.Drawing.Point(14, 38);
            this.lblStatAttempts.Name = "lblStatAttempts";
            this.lblStatAttempts.Size = new System.Drawing.Size(180, 42);
            this.lblStatAttempts.TabIndex = 1;
            this.lblStatAttempts.Text = "128";
            // 
            // lblCard4Title
            // 
            this.lblCard4Title.AutoSize = true;
            this.lblCard4Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCard4Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCard4Title.Location = new System.Drawing.Point(14, 14);
            this.lblCard4Title.Name = "lblCard4Title";
            this.lblCard4Title.Size = new System.Drawing.Size(126, 15);
            this.lblCard4Title.TabIndex = 0;
            this.lblCard4Title.Text = "TESTS EVALUATED";
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard3.Controls.Add(this.lblStatStudents);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Location = new System.Drawing.Point(448, 0);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Padding = new System.Windows.Forms.Padding(14);
            this.pnlCard3.Size = new System.Drawing.Size(210, 95);
            this.pnlCard3.TabIndex = 2;
            // 
            // lblStatStudents
            // 
            this.lblStatStudents.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatStudents.Location = new System.Drawing.Point(14, 38);
            this.lblStatStudents.Name = "lblStatStudents";
            this.lblStatStudents.Size = new System.Drawing.Size(180, 42);
            this.lblStatStudents.TabIndex = 1;
            this.lblStatStudents.Text = "45";
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.AutoSize = true;
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCard3Title.Location = new System.Drawing.Point(14, 14);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(142, 15);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "ENROLLED STUDENTS";
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard2.Controls.Add(this.lblStatQuestions);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Location = new System.Drawing.Point(224, 0);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Padding = new System.Windows.Forms.Padding(14);
            this.pnlCard2.Size = new System.Drawing.Size(210, 95);
            this.pnlCard2.TabIndex = 1;
            // 
            // lblStatQuestions
            // 
            this.lblStatQuestions.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatQuestions.Location = new System.Drawing.Point(14, 38);
            this.lblStatQuestions.Name = "lblStatQuestions";
            this.lblStatQuestions.Size = new System.Drawing.Size(180, 42);
            this.lblStatQuestions.TabIndex = 1;
            this.lblStatQuestions.Text = "40";
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.AutoSize = true;
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCard2Title.Location = new System.Drawing.Point(14, 14);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(121, 15);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "QUESTION BANK";
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard1.Controls.Add(this.lblStatExams);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Location = new System.Drawing.Point(0, 0);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Padding = new System.Windows.Forms.Padding(14);
            this.pnlCard1.Size = new System.Drawing.Size(210, 95);
            this.pnlCard1.TabIndex = 0;
            // 
            // lblStatExams
            // 
            this.lblStatExams.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblStatExams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatExams.Location = new System.Drawing.Point(14, 38);
            this.lblStatExams.Name = "lblStatExams";
            this.lblStatExams.Size = new System.Drawing.Size(180, 42);
            this.lblStatExams.TabIndex = 1;
            this.lblStatExams.Text = "4";
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.AutoSize = true;
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCard1Title.Location = new System.Drawing.Point(14, 14);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(89, 15);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "TOTAL EXAMS";
            // 
            // tabExams
            // 
            this.tabExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabExams.Controls.Add(this.dgvExams);
            this.tabExams.Controls.Add(this.pnlExamsToolbar);
            this.tabExams.Location = new System.Drawing.Point(4, 38);
            this.tabExams.Name = "tabExams";
            this.tabExams.Padding = new System.Windows.Forms.Padding(20);
            this.tabExams.Size = new System.Drawing.Size(1156, 579);
            this.tabExams.TabIndex = 1;
            this.tabExams.Text = "  📋 Manage Exams  ";
            // 
            // dgvExams
            // 
            this.dgvExams.AllowUserToAddRows = false;
            this.dgvExams.AllowUserToDeleteRows = false;
            this.dgvExams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExams.BackgroundColor = System.Drawing.Color.White;
            this.dgvExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExId,
            this.colExSubject,
            this.colExTitle,
            this.colExDuration,
            this.colExQuestions,
            this.colExPass,
            this.colExActive,
            this.colExCreated});
            this.dgvExams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExams.Location = new System.Drawing.Point(20, 75);
            this.dgvExams.MultiSelect = false;
            this.dgvExams.Name = "dgvExams";
            this.dgvExams.ReadOnly = true;
            this.dgvExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExams.Size = new System.Drawing.Size(1116, 484);
            this.dgvExams.TabIndex = 1;
            // 
            // colExId
            // 
            this.colExId.FillWeight = 40F;
            this.colExId.HeaderText = "ID";
            this.colExId.Name = "colExId";
            this.colExId.ReadOnly = true;
            this.colExId.Visible = false;
            // 
            // colExSubject
            // 
            this.colExSubject.FillWeight = 80F;
            this.colExSubject.HeaderText = "Subject Code";
            this.colExSubject.Name = "colExSubject";
            this.colExSubject.ReadOnly = true;
            // 
            // colExTitle
            // 
            this.colExTitle.FillWeight = 220F;
            this.colExTitle.HeaderText = "Exam Title";
            this.colExTitle.Name = "colExTitle";
            this.colExTitle.ReadOnly = true;
            // 
            // colExDuration
            // 
            this.colExDuration.FillWeight = 70F;
            this.colExDuration.HeaderText = "Duration";
            this.colExDuration.Name = "colExDuration";
            this.colExDuration.ReadOnly = true;
            // 
            // colExQuestions
            // 
            this.colExQuestions.FillWeight = 60F;
            this.colExQuestions.HeaderText = "Questions";
            this.colExQuestions.Name = "colExQuestions";
            this.colExQuestions.ReadOnly = true;
            // 
            // colExPass
            // 
            this.colExPass.FillWeight = 60F;
            this.colExPass.HeaderText = "Pass (%)";
            this.colExPass.Name = "colExPass";
            this.colExPass.ReadOnly = true;
            // 
            // colExActive
            // 
            this.colExActive.FillWeight = 70F;
            this.colExActive.HeaderText = "Status";
            this.colExActive.Name = "colExActive";
            this.colExActive.ReadOnly = true;
            // 
            // colExCreated
            // 
            this.colExCreated.FillWeight = 90F;
            this.colExCreated.HeaderText = "Created Date";
            this.colExCreated.Name = "colExCreated";
            this.colExCreated.ReadOnly = true;
            // 
            // pnlExamsToolbar
            // 
            this.pnlExamsToolbar.Controls.Add(this.txtSearchExams);
            this.pnlExamsToolbar.Controls.Add(this.lblSearchExams);
            this.pnlExamsToolbar.Controls.Add(this.btnDeleteExam);
            this.pnlExamsToolbar.Controls.Add(this.btnEditExam);
            this.pnlExamsToolbar.Controls.Add(this.btnAddExam);
            this.pnlExamsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlExamsToolbar.Location = new System.Drawing.Point(20, 20);
            this.pnlExamsToolbar.Name = "pnlExamsToolbar";
            this.pnlExamsToolbar.Size = new System.Drawing.Size(1116, 55);
            this.pnlExamsToolbar.TabIndex = 0;
            // 
            // txtSearchExams
            // 
            this.txtSearchExams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchExams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchExams.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchExams.Location = new System.Drawing.Point(860, 13);
            this.txtSearchExams.Name = "txtSearchExams";
            this.txtSearchExams.Size = new System.Drawing.Size(250, 25);
            this.txtSearchExams.TabIndex = 4;
            this.txtSearchExams.TextChanged += new System.EventHandler(this.txtSearchExams_TextChanged);
            // 
            // lblSearchExams
            // 
            this.lblSearchExams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchExams.AutoSize = true;
            this.lblSearchExams.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchExams.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSearchExams.Location = new System.Drawing.Point(775, 17);
            this.lblSearchExams.Name = "lblSearchExams";
            this.lblSearchExams.Size = new System.Drawing.Size(78, 15);
            this.lblSearchExams.TabIndex = 3;
            this.lblSearchExams.Text = "Search Exam:";
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Location = new System.Drawing.Point(290, 8);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(125, 36);
            this.btnDeleteExam.TabIndex = 2;
            this.btnDeleteExam.Text = "Delete Exam";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // btnEditExam
            // 
            this.btnEditExam.Location = new System.Drawing.Point(155, 8);
            this.btnEditExam.Name = "btnEditExam";
            this.btnEditExam.Size = new System.Drawing.Size(125, 36);
            this.btnEditExam.TabIndex = 1;
            this.btnEditExam.Text = "Edit Exam";
            this.btnEditExam.UseVisualStyleBackColor = true;
            this.btnEditExam.Click += new System.EventHandler(this.btnEditExam_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(0, 8);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(145, 36);
            this.btnAddExam.TabIndex = 0;
            this.btnAddExam.Text = "+ Add New Exam";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // tabQuestions
            // 
            this.tabQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabQuestions.Controls.Add(this.dgvQuestions);
            this.tabQuestions.Controls.Add(this.pnlQuestionsToolbar);
            this.tabQuestions.Location = new System.Drawing.Point(4, 38);
            this.tabQuestions.Name = "tabQuestions";
            this.tabQuestions.Padding = new System.Windows.Forms.Padding(20);
            this.tabQuestions.Size = new System.Drawing.Size(1156, 579);
            this.tabQuestions.TabIndex = 2;
            this.tabQuestions.Text = "  ❓ Manage Questions  ";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQId,
            this.colQNum,
            this.colQText,
            this.colQOptA,
            this.colQOptB,
            this.colQOptC,
            this.colQOptD,
            this.colQCorrect,
            this.colQMarks,
            this.colQExplanation});
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestions.Location = new System.Drawing.Point(20, 80);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(1116, 479);
            this.dgvQuestions.TabIndex = 1;
            // 
            // colQId
            // 
            this.colQId.FillWeight = 40F;
            this.colQId.HeaderText = "ID";
            this.colQId.Name = "colQId";
            this.colQId.ReadOnly = true;
            this.colQId.Visible = false;
            // 
            // colQNum
            // 
            this.colQNum.FillWeight = 40F;
            this.colQNum.HeaderText = "#";
            this.colQNum.Name = "colQNum";
            this.colQNum.ReadOnly = true;
            // 
            // colQText
            // 
            this.colQText.FillWeight = 240F;
            this.colQText.HeaderText = "Question Statement";
            this.colQText.Name = "colQText";
            this.colQText.ReadOnly = true;
            // 
            // colQOptA
            // 
            this.colQOptA.FillWeight = 110F;
            this.colQOptA.HeaderText = "Option A";
            this.colQOptA.Name = "colQOptA";
            this.colQOptA.ReadOnly = true;
            // 
            // colQOptB
            // 
            this.colQOptB.FillWeight = 110F;
            this.colQOptB.HeaderText = "Option B";
            this.colQOptB.Name = "colQOptB";
            this.colQOptB.ReadOnly = true;
            // 
            // colQOptC
            // 
            this.colQOptC.FillWeight = 110F;
            this.colQOptC.HeaderText = "Option C";
            this.colQOptC.Name = "colQOptC";
            this.colQOptC.ReadOnly = true;
            // 
            // colQOptD
            // 
            this.colQOptD.FillWeight = 110F;
            this.colQOptD.HeaderText = "Option D";
            this.colQOptD.Name = "colQOptD";
            this.colQOptD.ReadOnly = true;
            // 
            // colQCorrect
            // 
            this.colQCorrect.FillWeight = 50F;
            this.colQCorrect.HeaderText = "Key";
            this.colQCorrect.Name = "colQCorrect";
            this.colQCorrect.ReadOnly = true;
            // 
            // colQMarks
            // 
            this.colQMarks.FillWeight = 45F;
            this.colQMarks.HeaderText = "Marks";
            this.colQMarks.Name = "colQMarks";
            this.colQMarks.ReadOnly = true;
            // 
            // colQExplanation
            // 
            this.colQExplanation.FillWeight = 140F;
            this.colQExplanation.HeaderText = "Explanation";
            this.colQExplanation.Name = "colQExplanation";
            this.colQExplanation.ReadOnly = true;
            // 
            // pnlQuestionsToolbar
            // 
            this.pnlQuestionsToolbar.Controls.Add(this.txtSearchQuestions);
            this.pnlQuestionsToolbar.Controls.Add(this.lblSearchQuestions);
            this.pnlQuestionsToolbar.Controls.Add(this.btnDeleteQuestion);
            this.pnlQuestionsToolbar.Controls.Add(this.btnEditQuestion);
            this.pnlQuestionsToolbar.Controls.Add(this.btnAddQuestion);
            this.pnlQuestionsToolbar.Controls.Add(this.cmbQuestionExamFilter);
            this.pnlQuestionsToolbar.Controls.Add(this.lblFilterExam);
            this.pnlQuestionsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuestionsToolbar.Location = new System.Drawing.Point(20, 20);
            this.pnlQuestionsToolbar.Name = "pnlQuestionsToolbar";
            this.pnlQuestionsToolbar.Size = new System.Drawing.Size(1116, 60);
            this.pnlQuestionsToolbar.TabIndex = 0;
            // 
            // txtSearchQuestions
            // 
            this.txtSearchQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchQuestions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchQuestions.Location = new System.Drawing.Point(900, 15);
            this.txtSearchQuestions.Name = "txtSearchQuestions";
            this.txtSearchQuestions.Size = new System.Drawing.Size(210, 25);
            this.txtSearchQuestions.TabIndex = 6;
            this.txtSearchQuestions.TextChanged += new System.EventHandler(this.txtSearchQuestions_TextChanged);
            // 
            // lblSearchQuestions
            // 
            this.lblSearchQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchQuestions.AutoSize = true;
            this.lblSearchQuestions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSearchQuestions.Location = new System.Drawing.Point(842, 19);
            this.lblSearchQuestions.Name = "lblSearchQuestions";
            this.lblSearchQuestions.Size = new System.Drawing.Size(48, 15);
            this.lblSearchQuestions.TabIndex = 5;
            this.lblSearchQuestions.Text = "Search:";
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.Location = new System.Drawing.Point(680, 11);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(130, 34);
            this.btnDeleteQuestion.TabIndex = 4;
            this.btnDeleteQuestion.Text = "Delete Question";
            this.btnDeleteQuestion.UseVisualStyleBackColor = true;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // btnEditQuestion
            // 
            this.btnEditQuestion.Location = new System.Drawing.Point(545, 11);
            this.btnEditQuestion.Name = "btnEditQuestion";
            this.btnEditQuestion.Size = new System.Drawing.Size(125, 34);
            this.btnEditQuestion.TabIndex = 3;
            this.btnEditQuestion.Text = "Edit Question";
            this.btnEditQuestion.UseVisualStyleBackColor = true;
            this.btnEditQuestion.Click += new System.EventHandler(this.btnEditQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(385, 11);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(150, 34);
            this.btnAddQuestion.TabIndex = 2;
            this.btnAddQuestion.Text = "+ Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // cmbQuestionExamFilter
            // 
            this.cmbQuestionExamFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuestionExamFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbQuestionExamFilter.FormattingEnabled = true;
            this.cmbQuestionExamFilter.Location = new System.Drawing.Point(90, 16);
            this.cmbQuestionExamFilter.Name = "cmbQuestionExamFilter";
            this.cmbQuestionExamFilter.Size = new System.Drawing.Size(270, 25);
            this.cmbQuestionExamFilter.TabIndex = 1;
            this.cmbQuestionExamFilter.SelectedIndexChanged += new System.EventHandler(this.cmbQuestionExamFilter_SelectedIndexChanged);
            // 
            // lblFilterExam
            // 
            this.lblFilterExam.AutoSize = true;
            this.lblFilterExam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblFilterExam.Location = new System.Drawing.Point(0, 20);
            this.lblFilterExam.Name = "lblFilterExam";
            this.lblFilterExam.Size = new System.Drawing.Size(83, 15);
            this.lblFilterExam.TabIndex = 0;
            this.lblFilterExam.Text = "Select Exam:";
            // 
            // tabStudents
            // 
            this.tabStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Controls.Add(this.pnlStudentsToolbar);
            this.tabStudents.Location = new System.Drawing.Point(4, 38);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(20);
            this.tabStudents.Size = new System.Drawing.Size(1156, 579);
            this.tabStudents.TabIndex = 3;
            this.tabStudents.Text = "  🎓 Manage Students  ";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudId,
            this.colStudRoll,
            this.colStudName,
            this.colStudUser,
            this.colStudEmail,
            this.colStudPhone,
            this.colStudStatus,
            this.colStudCreated});
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(20, 75);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(1116, 484);
            this.dgvStudents.TabIndex = 1;
            // 
            // colStudId
            // 
            this.colStudId.FillWeight = 40F;
            this.colStudId.HeaderText = "ID";
            this.colStudId.Name = "colStudId";
            this.colStudId.ReadOnly = true;
            this.colStudId.Visible = false;
            // 
            // colStudRoll
            // 
            this.colStudRoll.FillWeight = 90F;
            this.colStudRoll.HeaderText = "Roll Number";
            this.colStudRoll.Name = "colStudRoll";
            this.colStudRoll.ReadOnly = true;
            // 
            // colStudName
            // 
            this.colStudName.FillWeight = 140F;
            this.colStudName.HeaderText = "Full Name";
            this.colStudName.Name = "colStudName";
            this.colStudName.ReadOnly = true;
            // 
            // colStudUser
            // 
            this.colStudUser.FillWeight = 100F;
            this.colStudUser.HeaderText = "Username";
            this.colStudUser.Name = "colStudUser";
            this.colStudUser.ReadOnly = true;
            // 
            // colStudEmail
            // 
            this.colStudEmail.FillWeight = 150F;
            this.colStudEmail.HeaderText = "Email Address";
            this.colStudEmail.Name = "colStudEmail";
            this.colStudEmail.ReadOnly = true;
            // 
            // colStudPhone
            // 
            this.colStudPhone.FillWeight = 90F;
            this.colStudPhone.HeaderText = "Phone";
            this.colStudPhone.Name = "colStudPhone";
            this.colStudPhone.ReadOnly = true;
            // 
            // colStudStatus
            // 
            this.colStudStatus.FillWeight = 75F;
            this.colStudStatus.HeaderText = "Account Status";
            this.colStudStatus.Name = "colStudStatus";
            this.colStudStatus.ReadOnly = true;
            // 
            // colStudCreated
            // 
            this.colStudCreated.FillWeight = 90F;
            this.colStudCreated.HeaderText = "Joined Date";
            this.colStudCreated.Name = "colStudCreated";
            this.colStudCreated.ReadOnly = true;
            // 
            // pnlStudentsToolbar
            // 
            this.pnlStudentsToolbar.Controls.Add(this.txtSearchStudents);
            this.pnlStudentsToolbar.Controls.Add(this.lblSearchStudents);
            this.pnlStudentsToolbar.Controls.Add(this.btnDeleteStudent);
            this.pnlStudentsToolbar.Controls.Add(this.btnResetStudentPwd);
            this.pnlStudentsToolbar.Controls.Add(this.btnEditStudent);
            this.pnlStudentsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStudentsToolbar.Location = new System.Drawing.Point(20, 20);
            this.pnlStudentsToolbar.Name = "pnlStudentsToolbar";
            this.pnlStudentsToolbar.Size = new System.Drawing.Size(1116, 55);
            this.pnlStudentsToolbar.TabIndex = 0;
            // 
            // txtSearchStudents
            // 
            this.txtSearchStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchStudents.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchStudents.Location = new System.Drawing.Point(860, 13);
            this.txtSearchStudents.Name = "txtSearchStudents";
            this.txtSearchStudents.Size = new System.Drawing.Size(250, 25);
            this.txtSearchStudents.TabIndex = 4;
            this.txtSearchStudents.TextChanged += new System.EventHandler(this.txtSearchStudents_TextChanged);
            // 
            // lblSearchStudents
            // 
            this.lblSearchStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchStudents.AutoSize = true;
            this.lblSearchStudents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSearchStudents.Location = new System.Drawing.Point(760, 17);
            this.lblSearchStudents.Name = "lblSearchStudents";
            this.lblSearchStudents.Size = new System.Drawing.Size(94, 15);
            this.lblSearchStudents.TabIndex = 3;
            this.lblSearchStudents.Text = "Search Student:";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(340, 8);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(130, 36);
            this.btnDeleteStudent.TabIndex = 2;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnResetStudentPwd
            // 
            this.btnResetStudentPwd.Location = new System.Drawing.Point(165, 8);
            this.btnResetStudentPwd.Name = "btnResetStudentPwd";
            this.btnResetStudentPwd.Size = new System.Drawing.Size(165, 36);
            this.btnResetStudentPwd.TabIndex = 1;
            this.btnResetStudentPwd.Text = "Reset Password";
            this.btnResetStudentPwd.UseVisualStyleBackColor = true;
            this.btnResetStudentPwd.Click += new System.EventHandler(this.btnResetStudentPwd_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Location = new System.Drawing.Point(0, 8);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(155, 36);
            this.btnEditStudent.TabIndex = 0;
            this.btnEditStudent.Text = "Edit Student Profile";
            this.btnEditStudent.UseVisualStyleBackColor = true;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);
            // 
            // tabReports
            // 
            this.tabReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.tabReports.Controls.Add(this.dgvAllAttempts);
            this.tabReports.Controls.Add(this.pnlReportsToolbar);
            this.tabReports.Location = new System.Drawing.Point(4, 38);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(20);
            this.tabReports.Size = new System.Drawing.Size(1156, 579);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "  📈 Results & Reports  ";
            // 
            // dgvAllAttempts
            // 
            this.dgvAllAttempts.AllowUserToAddRows = false;
            this.dgvAllAttempts.AllowUserToDeleteRows = false;
            this.dgvAllAttempts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllAttempts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllAttempts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAttempts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRepAttemptId,
            this.colRepRoll,
            this.colRepStudent,
            this.colRepSubject,
            this.colRepTitle,
            this.colRepScore,
            this.colRepPercent,
            this.colRepStatus,
            this.colRepDuration,
            this.colRepDate});
            this.dgvAllAttempts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllAttempts.Location = new System.Drawing.Point(20, 80);
            this.dgvAllAttempts.MultiSelect = false;
            this.dgvAllAttempts.Name = "dgvAllAttempts";
            this.dgvAllAttempts.ReadOnly = true;
            this.dgvAllAttempts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllAttempts.Size = new System.Drawing.Size(1116, 479);
            this.dgvAllAttempts.TabIndex = 1;
            // 
            // colRepAttemptId
            // 
            this.colRepAttemptId.FillWeight = 40F;
            this.colRepAttemptId.HeaderText = "ID";
            this.colRepAttemptId.Name = "colRepAttemptId";
            this.colRepAttemptId.ReadOnly = true;
            this.colRepAttemptId.Visible = false;
            // 
            // colRepRoll
            // 
            this.colRepRoll.FillWeight = 80F;
            this.colRepRoll.HeaderText = "Roll No";
            this.colRepRoll.Name = "colRepRoll";
            this.colRepRoll.ReadOnly = true;
            // 
            // colRepStudent
            // 
            this.colRepStudent.FillWeight = 120F;
            this.colRepStudent.HeaderText = "Student Name";
            this.colRepStudent.Name = "colRepStudent";
            this.colRepStudent.ReadOnly = true;
            // 
            // colRepSubject
            // 
            this.colRepSubject.FillWeight = 80F;
            this.colRepSubject.HeaderText = "Subject";
            this.colRepSubject.Name = "colRepSubject";
            this.colRepSubject.ReadOnly = true;
            // 
            // colRepTitle
            // 
            this.colRepTitle.FillWeight = 180F;
            this.colRepTitle.HeaderText = "Exam Title";
            this.colRepTitle.Name = "colRepTitle";
            this.colRepTitle.ReadOnly = true;
            // 
            // colRepScore
            // 
            this.colRepScore.FillWeight = 65F;
            this.colRepScore.HeaderText = "Score";
            this.colRepScore.Name = "colRepScore";
            this.colRepScore.ReadOnly = true;
            // 
            // colRepPercent
            // 
            this.colRepPercent.FillWeight = 65F;
            this.colRepPercent.HeaderText = "Percentage";
            this.colRepPercent.Name = "colRepPercent";
            this.colRepPercent.ReadOnly = true;
            // 
            // colRepStatus
            // 
            this.colRepStatus.FillWeight = 75F;
            this.colRepStatus.HeaderText = "Result";
            this.colRepStatus.Name = "colRepStatus";
            this.colRepStatus.ReadOnly = true;
            // 
            // colRepDuration
            // 
            this.colRepDuration.FillWeight = 75F;
            this.colRepDuration.HeaderText = "Time Taken";
            this.colRepDuration.Name = "colRepDuration";
            this.colRepDuration.ReadOnly = true;
            // 
            // colRepDate
            // 
            this.colRepDate.FillWeight = 110F;
            this.colRepDate.HeaderText = "Date Submitted";
            this.colRepDate.Name = "colRepDate";
            this.colRepDate.ReadOnly = true;
            // 
            // pnlReportsToolbar
            // 
            this.pnlReportsToolbar.Controls.Add(this.btnViewDetailedScorecard);
            this.pnlReportsToolbar.Controls.Add(this.txtSearchReportStudent);
            this.pnlReportsToolbar.Controls.Add(this.lblSearchReportStudent);
            this.pnlReportsToolbar.Controls.Add(this.cmbReportExamFilter);
            this.pnlReportsToolbar.Controls.Add(this.lblReportExam);
            this.pnlReportsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportsToolbar.Location = new System.Drawing.Point(20, 20);
            this.pnlReportsToolbar.Name = "pnlReportsToolbar";
            this.pnlReportsToolbar.Size = new System.Drawing.Size(1116, 60);
            this.pnlReportsToolbar.TabIndex = 0;
            // 
            // btnViewDetailedScorecard
            // 
            this.btnViewDetailedScorecard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDetailedScorecard.Location = new System.Drawing.Point(850, 10);
            this.btnViewDetailedScorecard.Name = "btnViewDetailedScorecard";
            this.btnViewDetailedScorecard.Size = new System.Drawing.Size(260, 40);
            this.btnViewDetailedScorecard.TabIndex = 4;
            this.btnViewDetailedScorecard.Text = "🔍 View Full Performance Scorecard";
            this.btnViewDetailedScorecard.UseVisualStyleBackColor = true;
            this.btnViewDetailedScorecard.Click += new System.EventHandler(this.btnViewDetailedScorecard_Click);
            // 
            // txtSearchReportStudent
            // 
            this.txtSearchReportStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchReportStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchReportStudent.Location = new System.Drawing.Point(470, 17);
            this.txtSearchReportStudent.Name = "txtSearchReportStudent";
            this.txtSearchReportStudent.Size = new System.Drawing.Size(220, 25);
            this.txtSearchReportStudent.TabIndex = 3;
            this.txtSearchReportStudent.TextChanged += new System.EventHandler(this.txtSearchReportStudent_TextChanged);
            // 
            // lblSearchReportStudent
            // 
            this.lblSearchReportStudent.AutoSize = true;
            this.lblSearchReportStudent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearchReportStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSearchReportStudent.Location = new System.Drawing.Point(370, 21);
            this.lblSearchReportStudent.Name = "lblSearchReportStudent";
            this.lblSearchReportStudent.Size = new System.Drawing.Size(94, 15);
            this.lblSearchReportStudent.TabIndex = 2;
            this.lblSearchReportStudent.Text = "Search Student:";
            // 
            // cmbReportExamFilter
            // 
            this.cmbReportExamFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportExamFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbReportExamFilter.FormattingEnabled = true;
            this.cmbReportExamFilter.Location = new System.Drawing.Point(85, 17);
            this.cmbReportExamFilter.Name = "cmbReportExamFilter";
            this.cmbReportExamFilter.Size = new System.Drawing.Size(260, 25);
            this.cmbReportExamFilter.TabIndex = 1;
            this.cmbReportExamFilter.SelectedIndexChanged += new System.EventHandler(this.cmbReportExamFilter_SelectedIndexChanged);
            // 
            // lblReportExam
            // 
            this.lblReportExam.AutoSize = true;
            this.lblReportExam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblReportExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblReportExam.Location = new System.Drawing.Point(0, 21);
            this.lblReportExam.Name = "lblReportExam";
            this.lblReportExam.Size = new System.Drawing.Size(78, 15);
            this.lblReportExam.TabIndex = 0;
            this.lblReportExam.Text = "Filter Exam:";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 701);
            this.Controls.Add(this.tabAdmin);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator Control Center - Networked Exam Engine";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentAttempts)).EndInit();
            this.pnlRecentHeader.ResumeLayout(false);
            this.pnlRecentHeader.PerformLayout();
            this.pnlKpiCards.ResumeLayout(false);
            this.pnlCard5.ResumeLayout(false);
            this.pnlCard5.PerformLayout();
            this.pnlCard4.ResumeLayout(false);
            this.pnlCard4.PerformLayout();
            this.pnlCard3.ResumeLayout(false);
            this.pnlCard3.PerformLayout();
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard2.PerformLayout();
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard1.PerformLayout();
            this.tabExams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExams)).EndInit();
            this.pnlExamsToolbar.ResumeLayout(false);
            this.pnlExamsToolbar.PerformLayout();
            this.tabQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.pnlQuestionsToolbar.ResumeLayout(false);
            this.pnlQuestionsToolbar.PerformLayout();
            this.tabStudents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.pnlStudentsToolbar.ResumeLayout(false);
            this.pnlStudentsToolbar.PerformLayout();
            this.tabReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAttempts)).EndInit();
            this.pnlReportsToolbar.ResumeLayout(false);
            this.pnlReportsToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblAdminInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.Panel pnlKpiCards;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblStatExams;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblStatQuestions;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblStatStudents;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Panel pnlCard4;
        private System.Windows.Forms.Label lblStatAttempts;
        private System.Windows.Forms.Label lblCard4Title;
        private System.Windows.Forms.Panel pnlCard5;
        private System.Windows.Forms.Label lblStatPassRate;
        private System.Windows.Forms.Label lblCard5Title;
        private System.Windows.Forms.Panel pnlRecentHeader;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.Button btnQuickAddExam;
        private System.Windows.Forms.Button btnQuickAddQuestion;
        private System.Windows.Forms.DataGridView dgvRecentAttempts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecDate;
        private System.Windows.Forms.TabPage tabExams;
        private System.Windows.Forms.Panel pnlExamsToolbar;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Button btnEditExam;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Label lblSearchExams;
        private System.Windows.Forms.TextBox txtSearchExams;
        private System.Windows.Forms.DataGridView dgvExams;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExCreated;
        private System.Windows.Forms.TabPage tabQuestions;
        private System.Windows.Forms.Panel pnlQuestionsToolbar;
        private System.Windows.Forms.Label lblFilterExam;
        private System.Windows.Forms.ComboBox cmbQuestionExamFilter;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnEditQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
        private System.Windows.Forms.Label lblSearchQuestions;
        private System.Windows.Forms.TextBox txtSearchQuestions;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQOptA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQOptB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQOptC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQOptD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQCorrect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQMarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQExplanation;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.Panel pnlStudentsToolbar;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnResetStudentPwd;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label lblSearchStudents;
        private System.Windows.Forms.TextBox txtSearchStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudCreated;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Panel pnlReportsToolbar;
        private System.Windows.Forms.Label lblReportExam;
        private System.Windows.Forms.ComboBox cmbReportExamFilter;
        private System.Windows.Forms.Label lblSearchReportStudent;
        private System.Windows.Forms.TextBox txtSearchReportStudent;
        private System.Windows.Forms.Button btnViewDetailedScorecard;
        private System.Windows.Forms.DataGridView dgvAllAttempts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepAttemptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepRoll;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRepDate;
    }
}
