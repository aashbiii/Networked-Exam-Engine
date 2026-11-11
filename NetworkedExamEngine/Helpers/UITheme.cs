using System.Drawing;
using System.Windows.Forms;

namespace NetworkedExamEngine.Helpers
{
    public static class UITheme
    {
        // Color Palette
        public static readonly Color Primary = Color.FromArgb(30, 41, 59);          // #1E293B (Dark Navy/Slate)
        public static readonly Color PrimaryDark = Color.FromArgb(15, 23, 42);      // #0F172A (Deep Slate)
        public static readonly Color PrimaryLight = Color.FromArgb(51, 65, 85);     // #334155 (Slate Medium)
        
        public static readonly Color Accent = Color.FromArgb(37, 99, 235);          // #2563EB (Royal Blue)
        public static readonly Color AccentHover = Color.FromArgb(29, 78, 216);     // #1D4ED8
        
        public static readonly Color Success = Color.FromArgb(16, 185, 129);       // #10B981 (Emerald Green)
        public static readonly Color SuccessDark = Color.FromArgb(5, 150, 105);
        
        public static readonly Color Danger = Color.FromArgb(239, 68, 68);         // #EF4444 (Coral Red)
        public static readonly Color DangerDark = Color.FromArgb(220, 38, 38);
        
        public static readonly Color Warning = Color.FromArgb(245, 158, 11);       // #F59E0B (Amber)
        public static readonly Color Info = Color.FromArgb(14, 165, 233);          // #0EA5E9 (Sky Blue)
        
        public static readonly Color Background = Color.FromArgb(248, 250, 252);   // #F8FAFC
        public static readonly Color CardBackground = Color.White;
        public static readonly Color Border = Color.FromArgb(226, 232, 240);       // #E2E8F0
        public static readonly Color BorderDark = Color.FromArgb(203, 213, 225);   // #CBD5E1

        public static readonly Color TextPrimary = Color.FromArgb(30, 41, 59);     // #1E293B
        public static readonly Color TextSecondary = Color.FromArgb(100, 116, 139);// #64748B
        public static readonly Color TextMuted = Color.FromArgb(148, 163, 184);    // #94A3B8

        // Standard Fonts
        public static readonly Font FontHeading = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static readonly Font FontSubheading = new Font("Segoe UI", 12F, FontStyle.Bold);
        public static readonly Font FontTitle = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        public static readonly Font FontRegular = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        public static readonly Font FontRegularBold = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static readonly Font FontSmall = new Font("Segoe UI", 8.5F, FontStyle.Regular);

        public static void StyleDataGrid(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.FromArgb(241, 245, 249);
            
            // Header
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(71, 85, 105);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(10, 8, 10, 8);
            dgv.ColumnHeadersHeight = 42;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Rows
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgv.DefaultCellStyle.Padding = new Padding(8, 6, 8, 6);
            
            // Alternating
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(238, 242, 255);
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 41, 59);

            dgv.RowTemplate.Height = 38;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.AllowUserToResizeRows = false;
            dgv.RowHeadersVisible = false;
        }

        public static void StylePrimaryButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Accent;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleSuccessButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Success;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleDangerButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Danger;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleSecondaryButton(Button btn)
        {
            if (btn == null) return;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = BorderDark;
            btn.FlatAppearance.BorderSize = 1;
            btn.BackColor = Color.White;
            btn.ForeColor = TextPrimary;
            btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            btn.Cursor = Cursors.Hand;
        }
    }
}
