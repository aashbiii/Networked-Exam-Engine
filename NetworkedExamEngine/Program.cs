using System;
using System.Windows.Forms;
using NetworkedExamEngine.Data;
using NetworkedExamEngine.Forms;

namespace NetworkedExamEngine
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check database connectivity on start; if unavailable, open DatabaseConfigForm helper
            string error;
            if (!DatabaseHelper.TestConnection(DatabaseHelper.ConnectionString, out error))
            {
                var choice = MessageBox.Show(
                    "The application could not establish an initial connection to SQL Server with current App.config settings:\n\n" +
                    error + "\n\n" +
                    "Would you like to open the Database Configuration settings to verify/update your server instance or credentials?\n\n" +
                    "(Click 'Yes' to configure now, or 'No' to proceed to Login)",
                    "Database Connection Notice",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (choice == DialogResult.Yes)
                {
                    using (var cfg = new DatabaseConfigForm())
                    {
                        cfg.ShowDialog();
                    }
                }
            }

            Application.Run(new LoginForm());
        }
    }
}
