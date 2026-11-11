namespace NetworkedExamEngine.Forms
{
    partial class QuestionEditForm
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
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblExam = new System.Windows.Forms.Label();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.lblCorrectOption = new System.Windows.Forms.Label();
            this.cmbCorrectOption = new System.Windows.Forms.ComboBox();
            this.lblMarks = new System.Windows.Forms.Label();
            this.numMarks = new System.Windows.Forms.NumericUpDown();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(24, 18, 24, 18);
            this.pnlHeader.Size = new System.Drawing.Size(624, 75);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 44);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(298, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Define question text with 4 multiple choice options";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(248, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Add New MCQ Question";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblExam.Location = new System.Drawing.Point(24, 88);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(73, 15);
            this.lblExam.TabIndex = 1;
            this.lblExam.Text = "Target Exam";
            // 
            // cmbExam
            // 
            this.cmbExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(27, 106);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(568, 25);
            this.cmbExam.TabIndex = 2;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblQuestionText.Location = new System.Drawing.Point(24, 140);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(120, 15);
            this.lblQuestionText.TabIndex = 3;
            this.lblQuestionText.Text = "Question Statement";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuestionText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtQuestionText.Location = new System.Drawing.Point(27, 158);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(568, 55);
            this.txtQuestionText.TabIndex = 4;
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOptionA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblOptionA.Location = new System.Drawing.Point(24, 222);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(58, 15);
            this.lblOptionA.TabIndex = 5;
            this.lblOptionA.Text = "Option A";
            // 
            // txtOptionA
            // 
            this.txtOptionA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionA.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtOptionA.Location = new System.Drawing.Point(27, 240);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(568, 24);
            this.txtOptionA.TabIndex = 6;
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOptionB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblOptionB.Location = new System.Drawing.Point(24, 272);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(57, 15);
            this.lblOptionB.TabIndex = 7;
            this.lblOptionB.Text = "Option B";
            // 
            // txtOptionB
            // 
            this.txtOptionB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtOptionB.Location = new System.Drawing.Point(27, 290);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(568, 24);
            this.txtOptionB.TabIndex = 8;
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOptionC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblOptionC.Location = new System.Drawing.Point(24, 322);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(56, 15);
            this.lblOptionC.TabIndex = 9;
            this.lblOptionC.Text = "Option C";
            // 
            // txtOptionC
            // 
            this.txtOptionC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionC.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtOptionC.Location = new System.Drawing.Point(27, 340);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(568, 24);
            this.txtOptionC.TabIndex = 10;
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOptionD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblOptionD.Location = new System.Drawing.Point(24, 372);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(58, 15);
            this.lblOptionD.TabIndex = 11;
            this.lblOptionD.Text = "Option D";
            // 
            // txtOptionD
            // 
            this.txtOptionD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptionD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtOptionD.Location = new System.Drawing.Point(27, 390);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(568, 24);
            this.txtOptionD.TabIndex = 12;
            // 
            // lblCorrectOption
            // 
            this.lblCorrectOption.AutoSize = true;
            this.lblCorrectOption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorrectOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCorrectOption.Location = new System.Drawing.Point(24, 425);
            this.lblCorrectOption.Name = "lblCorrectOption";
            this.lblCorrectOption.Size = new System.Drawing.Size(127, 15);
            this.lblCorrectOption.TabIndex = 13;
            this.lblCorrectOption.Text = "Correct Answer Choice";
            // 
            // cmbCorrectOption
            // 
            this.cmbCorrectOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorrectOption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmbCorrectOption.FormattingEnabled = true;
            this.cmbCorrectOption.Location = new System.Drawing.Point(27, 445);
            this.cmbCorrectOption.Name = "cmbCorrectOption";
            this.cmbCorrectOption.Size = new System.Drawing.Size(260, 25);
            this.cmbCorrectOption.TabIndex = 14;
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblMarks.Location = new System.Drawing.Point(312, 425);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(41, 15);
            this.lblMarks.TabIndex = 15;
            this.lblMarks.Text = "Marks";
            // 
            // numMarks
            // 
            this.numMarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numMarks.Location = new System.Drawing.Point(315, 445);
            this.numMarks.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMarks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMarks.Name = "numMarks";
            this.numMarks.Size = new System.Drawing.Size(280, 25);
            this.numMarks.TabIndex = 16;
            this.numMarks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblExplanation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblExplanation.Location = new System.Drawing.Point(24, 482);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(193, 15);
            this.lblExplanation.TabIndex = 17;
            this.lblExplanation.Text = "Explanation / Solution Justification";
            // 
            // txtExplanation
            // 
            this.txtExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExplanation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExplanation.Location = new System.Drawing.Point(27, 500);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.Size = new System.Drawing.Size(568, 48);
            this.txtExplanation.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 565);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(425, 42);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Question";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 565);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 42);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // QuestionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 630);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.numMarks);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.cmbCorrectOption);
            this.Controls.Add(this.lblCorrectOption);
            this.Controls.Add(this.txtOptionD);
            this.Controls.Add(this.lblOptionD);
            this.Controls.Add(this.txtOptionC);
            this.Controls.Add(this.lblOptionC);
            this.Controls.Add(this.txtOptionB);
            this.Controls.Add(this.lblOptionB);
            this.Controls.Add(this.txtOptionA);
            this.Controls.Add(this.lblOptionA);
            this.Controls.Add(this.txtQuestionText);
            this.Controls.Add(this.lblQuestionText);
            this.Controls.Add(this.cmbExam);
            this.Controls.Add(this.lblExam);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuestionEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Question Editor";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.ComboBox cmbExam;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.Label lblCorrectOption;
        private System.Windows.Forms.ComboBox cmbCorrectOption;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.NumericUpDown numMarks;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
