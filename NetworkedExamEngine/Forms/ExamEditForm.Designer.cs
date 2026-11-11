namespace NetworkedExamEngine.Forms
{
    partial class ExamEditForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblSubjectCode = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.numTotalQuestions = new System.Windows.Forms.NumericUpDown();
            this.lblPassPercentage = new System.Windows.Forms.Label();
            this.numPassPercentage = new System.Windows.Forms.NumericUpDown();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassPercentage)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(544, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 46);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(287, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Setup a new test subject, duration, and passing criteria";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(22, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(248, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Create New Examination";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 95);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Exam / Course Name";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitle.Location = new System.Drawing.Point(27, 115);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(488, 25);
            this.txtTitle.TabIndex = 2;
            // 
            // lblSubjectCode
            // 
            this.lblSubjectCode.AutoSize = true;
            this.lblSubjectCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubjectCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblSubjectCode.Location = new System.Drawing.Point(24, 150);
            this.lblSubjectCode.Name = "lblSubjectCode";
            this.lblSubjectCode.Size = new System.Drawing.Size(80, 15);
            this.lblSubjectCode.TabIndex = 3;
            this.lblSubjectCode.Text = "Subject Code";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubjectCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSubjectCode.Location = new System.Drawing.Point(27, 170);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(488, 25);
            this.txtSubjectCode.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblDescription.Location = new System.Drawing.Point(24, 205);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(104, 15);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Exam Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescription.Location = new System.Drawing.Point(27, 225);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(488, 60);
            this.txtDescription.TabIndex = 6;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDuration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblDuration.Location = new System.Drawing.Point(24, 298);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(109, 15);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "Duration (Minutes)";
            // 
            // numDuration
            // 
            this.numDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numDuration.Location = new System.Drawing.Point(27, 318);
            this.numDuration.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(150, 25);
            this.numDuration.TabIndex = 8;
            this.numDuration.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblTotalQuestions.Location = new System.Drawing.Point(195, 298);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(92, 15);
            this.lblTotalQuestions.TabIndex = 9;
            this.lblTotalQuestions.Text = "Total Questions";
            // 
            // numTotalQuestions
            // 
            this.numTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numTotalQuestions.Location = new System.Drawing.Point(198, 318);
            this.numTotalQuestions.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numTotalQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTotalQuestions.Name = "numTotalQuestions";
            this.numTotalQuestions.Size = new System.Drawing.Size(145, 25);
            this.numTotalQuestions.TabIndex = 10;
            this.numTotalQuestions.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblPassPercentage
            // 
            this.lblPassPercentage.AutoSize = true;
            this.lblPassPercentage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPassPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblPassPercentage.Location = new System.Drawing.Point(365, 298);
            this.lblPassPercentage.Name = "lblPassPercentage";
            this.lblPassPercentage.Size = new System.Drawing.Size(107, 15);
            this.lblPassPercentage.TabIndex = 11;
            this.lblPassPercentage.Text = "Passing Marks (%)";
            // 
            // numPassPercentage
            // 
            this.numPassPercentage.DecimalPlaces = 1;
            this.numPassPercentage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPassPercentage.Location = new System.Drawing.Point(368, 318);
            this.numPassPercentage.Name = "numPassPercentage";
            this.numPassPercentage.Size = new System.Drawing.Size(147, 25);
            this.numPassPercentage.TabIndex = 12;
            this.numPassPercentage.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.chkIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.chkIsActive.Location = new System.Drawing.Point(27, 365);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(262, 21);
            this.chkIsActive.TabIndex = 13;
            this.chkIsActive.Text = "Active (Students can take this exam)";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(350, 42);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Examination";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ExamEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 485);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.numPassPercentage);
            this.Controls.Add(this.lblPassPercentage);
            this.Controls.Add(this.numTotalQuestions);
            this.Controls.Add(this.lblTotalQuestions);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lblSubjectCode);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Examination Details";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPassPercentage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblSubjectCode;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.NumericUpDown numTotalQuestions;
        private System.Windows.Forms.Label lblPassPercentage;
        private System.Windows.Forms.NumericUpDown numPassPercentage;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
