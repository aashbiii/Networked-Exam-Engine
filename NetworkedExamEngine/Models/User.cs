using System;

namespace NetworkedExamEngine.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // "Admin" or "Student"
        public string RollNo { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        public bool IsAdmin => string.Equals(Role, "Admin", StringComparison.OrdinalIgnoreCase);
        public bool IsStudent => string.Equals(Role, "Student", StringComparison.OrdinalIgnoreCase);
    }
}
