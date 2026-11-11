namespace NetworkedExamEngine.Forms
{
    partial class LoginForm
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
            this.pnlBranding = new System.Windows.Forms.Panel();
            this.lblBrandVersion = new System.Windows.Forms.Label();
            this.lblFeature5 = new System.Windows.Forms.Label();
            this.lblFeature4 = new System.Windows.Forms.Label();
            this.lblFeature3 = new System.Windows.Forms.Label();
            this.lblFeature2 = new System.Windows.Forms.Label();
            this.lblFeature1 = new System.Windows.Forms.Label();
            this.lblBrandDivider = new System.Windows.Forms.Label();
            this.lblBrandSubtitle = new System.Windows.Forms.Label();
            this.lblBrandTitle = new System.Windows.Forms.Label();
            this.lblBrandBadge = new System.Windows.Forms.Label();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnDbSettings = new System.Windows.Forms.Button();
            this.pnlRegisterPrompt = new System.Windows.Forms.Panel();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlTabSwitch = new System.Windows.Forms.Panel();
            this.btnTabAdmin = new System.Windows.Forms.Button();
            this.btnTabStudent = new System.Windows.Forms.Button();
            this.lblLoginSubheading = new System.Windows.Forms.Label();
            this.lblLoginHeading = new System.Windows.Forms.Label();
            this.pnlBranding.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRegisterPrompt.SuspendLayout();
            this.pnlTabSwitch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBranding
            // 
            this.pnlBranding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlBranding.Controls.Add(this.lblBrandVersion);
            this.pnlBranding.Controls.Add(this.lblFeature5);
            this.pnlBranding.Controls.Add(this.lblFeature4);
            this.pnlBranding.Controls.Add(this.lblFeature3);
            this.pnlBranding.Controls.Add(this.lblFeature2);
            this.pnlBranding.Controls.Add(this.lblFeature1);
            this.pnlBranding.Controls.Add(this.lblBrandDivider);
            this.pnlBranding.Controls.Add(this.lblBrandSubtitle);
            this.pnlBranding.Controls.Add(this.lblBrandTitle);
            this.pnlBranding.Controls.Add(this.lblBrandBadge);
            this.pnlBranding.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBranding.Location = new System.Drawing.Point(0, 0);
            this.pnlBranding.Name = "pnlBranding";
            this.pnlBranding.Padding = new System.Windows.Forms.Padding(32);
            this.pnlBranding.Size = new System.Drawing.Size(340, 561);
            this.pnlBranding.TabIndex = 0;
            // 
            // lblBrandVersion
            // 
            this.lblBrandVersion.AutoSize = true;
            this.lblBrandVersion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBrandVersion.Location = new System.Drawing.Point(32, 516);
            this.lblBrandVersion.Name = "lblBrandVersion";
            this.lblBrandVersion.Size = new System.Drawing.Size(227, 13);
            this.lblBrandVersion.TabIndex = 9;
            this.lblBrandVersion.Text = "MCA Project | .NET 4.8 | SSMS 2022 Engine";
            // 
            // lblFeature5
            // 
            this.lblFeature5.AutoSize = true;
            this.lblFeature5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFeature5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFeature5.Location = new System.Drawing.Point(32, 400);
            this.lblFeature5.Name = "lblFeature5";
            this.lblFeature5.Size = new System.Drawing.Size(248, 17);
            this.lblFeature5.TabIndex = 8;
            this.lblFeature5.Text = "✓ Centralized SQL Server Authentication";
            // 
            // lblFeature4
            // 
            this.lblFeature4.AutoSize = true;
            this.lblFeature4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFeature4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFeature4.Location = new System.Drawing.Point(32, 360);
            this.lblFeature4.Name = "lblFeature4";
            this.lblFeature4.Size = new System.Drawing.Size(246, 17);
            this.lblFeature4.TabIndex = 7;
            this.lblFeature4.Text = "✓ Full Review: Student vs Correct Key";
            // 
            // lblFeature3
            // 
            this.lblFeature3.AutoSize = true;
            this.lblFeature3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFeature3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFeature3.Location = new System.Drawing.Point(32, 320);
            this.lblFeature3.Name = "lblFeature3";
            this.lblFeature3.Size = new System.Drawing.Size(245, 17);
            this.lblFeature3.TabIndex = 6;
            this.lblFeature3.Text = "✓ Enforced Single Attempt Per Exam";
            // 
            // lblFeature2
            // 
            this.lblFeature2.AutoSize = true;
            this.lblFeature2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFeature2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFeature2.Location = new System.Drawing.Point(32, 280);
            this.lblFeature2.Name = "lblFeature2";
            this.lblFeature2.Size = new System.Drawing.Size(239, 17);
            this.lblFeature2.TabIndex = 5;
            this.lblFeature2.Text = "✓ Real-Time Countdown & Auto-Submit";
            // 
            // lblFeature1
            // 
            this.lblFeature1.AutoSize = true;
            this.lblFeature1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFeature1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblFeature1.Location = new System.Drawing.Point(32, 240);
            this.lblFeature1.Name = "lblFeature1";
            this.lblFeature1.Size = new System.Drawing.Size(232, 17);
            this.lblFeature1.TabIndex = 4;
            this.lblFeature1.Text = "✓ Dynamic Question Bank & Catalog";
            // 
            // lblBrandDivider
            // 
            this.lblBrandDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblBrandDivider.Location = new System.Drawing.Point(35, 205);
            this.lblBrandDivider.Name = "lblBrandDivider";
            this.lblBrandDivider.Size = new System.Drawing.Size(260, 1);
            this.lblBrandDivider.TabIndex = 3;
            // 
            // lblBrandSubtitle
            // 
            this.lblBrandSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBrandSubtitle.Location = new System.Drawing.Point(32, 140);
            this.lblBrandSubtitle.Name = "lblBrandSubtitle";
            this.lblBrandSubtitle.Size = new System.Drawing.Size(275, 50);
            this.lblBrandSubtitle.TabIndex = 2;
            this.lblBrandSubtitle.Text = "Scalable Computer-Based Examination & Performance Analytics System";
            // 
            // lblBrandTitle
            // 
            this.lblBrandTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandTitle.ForeColor = System.Drawing.Color.White;
            this.lblBrandTitle.Location = new System.Drawing.Point(30, 65);
            this.lblBrandTitle.Name = "lblBrandTitle";
            this.lblBrandTitle.Size = new System.Drawing.Size(280, 70);
            this.lblBrandTitle.TabIndex = 1;
            this.lblBrandTitle.Text = "Networked Exam Engine";
            // 
            // lblBrandBadge
            // 
            this.lblBrandBadge.AutoSize = true;
            this.lblBrandBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblBrandBadge.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBrandBadge.ForeColor = System.Drawing.Color.White;
            this.lblBrandBadge.Location = new System.Drawing.Point(32, 35);
            this.lblBrandBadge.Name = "lblBrandBadge";
            this.lblBrandBadge.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.lblBrandBadge.Size = new System.Drawing.Size(95, 19);
            this.lblBrandBadge.TabIndex = 0;
            this.lblBrandBadge.Text = "MCA PROJECT";
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.btnDbSettings);
            this.pnlRight.Controls.Add(this.pnlRegisterPrompt);
            this.pnlRight.Controls.Add(this.btnLogin);
            this.pnlRight.Controls.Add(this.lblStatus);
            this.pnlRight.Controls.Add(this.chkShowPassword);
            this.pnlRight.Controls.Add(this.txtPassword);
            this.pnlRight.Controls.Add(this.lblPassword);
            this.pnlRight.Controls.Add(this.txtUsername);
            this.pnlRight.Controls.Add(this.lblUsername);
            this.pnlRight.Controls.Add(this.pnlTabSwitch);
            this.pnlRight.Controls.Add(this.lblLoginSubheading);
            this.pnlRight.Controls.Add(this.lblLoginHeading);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(340, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(40);
            this.pnlRight.Size = new System.Drawing.Size(544, 561);
            this.pnlRight.TabIndex = 1;
            // 
            // btnDbSettings
            // 
            this.btnDbSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDbSettings.Location = new System.Drawing.Point(300, 510);
            this.btnDbSettings.Name = "btnDbSettings";
            this.btnDbSettings.Size = new System.Drawing.Size(204, 30);
            this.btnDbSettings.TabIndex = 11;
            this.btnDbSettings.Text = "⚙ Database Settings";
            this.btnDbSettings.UseVisualStyleBackColor = true;
            this.btnDbSettings.Click += new System.EventHandler(this.btnDbSettings_Click);
            // 
            // pnlRegisterPrompt
            // 
            this.pnlRegisterPrompt.Controls.Add(this.lnkRegister);
            this.pnlRegisterPrompt.Controls.Add(this.lblNoAccount);
            this.pnlRegisterPrompt.Location = new System.Drawing.Point(43, 448);
            this.pnlRegisterPrompt.Name = "pnlRegisterPrompt";
            this.pnlRegisterPrompt.Size = new System.Drawing.Size(460, 30);
            this.pnlRegisterPrompt.TabIndex = 10;
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lnkRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lnkRegister.Location = new System.Drawing.Point(215, 6);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(126, 17);
            this.lnkRegister.TabIndex = 1;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Register Now Here";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNoAccount.Location = new System.Drawing.Point(62, 6);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(150, 17);
            this.lblNoAccount.TabIndex = 0;
            this.lblNoAccount.Text = "Don\'t have an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(43, 395);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(460, 44);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Sign In to Portal";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblStatus.Location = new System.Drawing.Point(43, 360);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(460, 28);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkShowPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.chkShowPassword.Location = new System.Drawing.Point(395, 335);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(108, 19);
            this.chkShowPassword.TabIndex = 7;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPassword.Location = new System.Drawing.Point(43, 302);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(460, 27);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblPassword.Location = new System.Drawing.Point(40, 280);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 17);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUsername.Location = new System.Drawing.Point(43, 230);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(460, 27);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblUsername.Location = new System.Drawing.Point(40, 208);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // pnlTabSwitch
            // 
            this.pnlTabSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlTabSwitch.Controls.Add(this.btnTabAdmin);
            this.pnlTabSwitch.Controls.Add(this.btnTabStudent);
            this.pnlTabSwitch.Location = new System.Drawing.Point(43, 140);
            this.pnlTabSwitch.Name = "pnlTabSwitch";
            this.pnlTabSwitch.Padding = new System.Windows.Forms.Padding(4);
            this.pnlTabSwitch.Size = new System.Drawing.Size(460, 44);
            this.pnlTabSwitch.TabIndex = 2;
            // 
            // btnTabAdmin
            // 
            this.btnTabAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTabAdmin.FlatAppearance.BorderSize = 0;
            this.btnTabAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabAdmin.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTabAdmin.Location = new System.Drawing.Point(230, 4);
            this.btnTabAdmin.Name = "btnTabAdmin";
            this.btnTabAdmin.Size = new System.Drawing.Size(226, 36);
            this.btnTabAdmin.TabIndex = 1;
            this.btnTabAdmin.Text = "Administrator";
            this.btnTabAdmin.UseVisualStyleBackColor = true;
            this.btnTabAdmin.Click += new System.EventHandler(this.btnTabAdmin_Click);
            // 
            // btnTabStudent
            // 
            this.btnTabStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTabStudent.FlatAppearance.BorderSize = 0;
            this.btnTabStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTabStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTabStudent.Location = new System.Drawing.Point(4, 4);
            this.btnTabStudent.Name = "btnTabStudent";
            this.btnTabStudent.Size = new System.Drawing.Size(226, 36);
            this.btnTabStudent.TabIndex = 0;
            this.btnTabStudent.Text = "Student Portal";
            this.btnTabStudent.UseVisualStyleBackColor = true;
            this.btnTabStudent.Click += new System.EventHandler(this.btnTabStudent_Click);
            // 
            // lblLoginSubheading
            // 
            this.lblLoginSubheading.AutoSize = true;
            this.lblLoginSubheading.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLoginSubheading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLoginSubheading.Location = new System.Drawing.Point(40, 75);
            this.lblLoginSubheading.Name = "lblLoginSubheading";
            this.lblLoginSubheading.Size = new System.Drawing.Size(306, 17);
            this.lblLoginSubheading.TabIndex = 1;
            this.lblLoginSubheading.Text = "Sign in with your student credentials to take exams";
            // 
            // lblLoginHeading
            // 
            this.lblLoginHeading.AutoSize = true;
            this.lblLoginHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblLoginHeading.Location = new System.Drawing.Point(37, 35);
            this.lblLoginHeading.Name = "lblLoginHeading";
            this.lblLoginHeading.Size = new System.Drawing.Size(325, 32);
            this.lblLoginHeading.TabIndex = 0;
            this.lblLoginHeading.Text = "Student Examination Portal";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlBranding);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Networked Examination & Assessment Engine - Authentication";
            this.pnlBranding.ResumeLayout(false);
            this.pnlBranding.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlRegisterPrompt.ResumeLayout(false);
            this.pnlRegisterPrompt.PerformLayout();
            this.pnlTabSwitch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBranding;
        private System.Windows.Forms.Label lblBrandBadge;
        private System.Windows.Forms.Label lblBrandTitle;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Label lblBrandDivider;
        private System.Windows.Forms.Label lblFeature1;
        private System.Windows.Forms.Label lblFeature2;
        private System.Windows.Forms.Label lblFeature3;
        private System.Windows.Forms.Label lblFeature4;
        private System.Windows.Forms.Label lblFeature5;
        private System.Windows.Forms.Label lblBrandVersion;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblLoginHeading;
        private System.Windows.Forms.Label lblLoginSubheading;
        private System.Windows.Forms.Panel pnlTabSwitch;
        private System.Windows.Forms.Button btnTabStudent;
        private System.Windows.Forms.Button btnTabAdmin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlRegisterPrompt;
        private System.Windows.Forms.Label lblNoAccount;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.Button btnDbSettings;
    }
}
