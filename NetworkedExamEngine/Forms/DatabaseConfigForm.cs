using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Helpers;

namespace NetworkedExamEngine.Forms
{
    public partial class DatabaseConfigForm : Form
    {
        public DatabaseConfigForm()
        {
            InitializeComponent();
            UITheme.StylePrimaryButton(btnSave);
            UITheme.StyleSecondaryButton(btnTestConnection);
            UITheme.StyleSecondaryButton(btnCancel);
            LoadCurrentSettings();
        }

        private void LoadCurrentSettings()
        {
            try
            {
                var builder = new SqlConnectionStringBuilder(DatabaseHelper.ConnectionString);
                txtServer.Text = builder.DataSource;
                txtDatabase.Text = builder.InitialCatalog;

                if (builder.IntegratedSecurity)
                {
                    rdoWindowsAuth.Checked = true;
                }
                else
                {
                    rdoSqlAuth.Checked = true;
                    txtUsername.Text = builder.UserID;
                    txtPassword.Text = builder.Password;
                }
            }
            catch
            {
                txtServer.Text = ".";
                txtDatabase.Text = "ExamEngineDB";
                rdoSqlAuth.Checked = true;
                txtUsername.Text = "sa";
            }
            UpdateAuthControls();
        }

        private void rdoSqlAuth_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAuthControls();
        }

        private void rdoWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAuthControls();
        }

        private void UpdateAuthControls()
        {
            bool isSqlAuth = rdoSqlAuth.Checked;
            txtUsername.Enabled = isSqlAuth;
            txtPassword.Enabled = isSqlAuth;
        }

        private string BuildConnectionString()
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = txtServer.Text.Trim(),
                InitialCatalog = txtDatabase.Text.Trim(),
                TrustServerCertificate = true
            };

            if (rdoWindowsAuth.Checked)
            {
                builder.IntegratedSecurity = true;
            }
            else
            {
                builder.IntegratedSecurity = false;
                builder.UserID = txtUsername.Text.Trim();
                builder.Password = txtPassword.Text;
            }

            return builder.ConnectionString;
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            lblTestResult.Text = "Testing connection...";
            lblTestResult.ForeColor = UITheme.Accent;
            btnTestConnection.Enabled = false;
            Application.DoEvents();

            string connStr = BuildConnectionString();
            if (DatabaseHelper.TestConnection(connStr, out string error))
            {
                lblTestResult.ForeColor = UITheme.Success;
                lblTestResult.Text = "✓ Connection succeeded! Ready to save.";
            }
            else
            {
                lblTestResult.ForeColor = UITheme.Danger;
                lblTestResult.Text = "✗ Connection failed: " + error;
            }
            btnTestConnection.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connStr = BuildConnectionString();
            DatabaseHelper.SaveConnectionStringToConfig(connStr);
            MessageBox.Show("Database connection parameters updated successfully!",
                "Settings Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
