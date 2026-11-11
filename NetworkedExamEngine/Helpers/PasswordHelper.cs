using System;
using System.Security.Cryptography;
using System.Text;

namespace NetworkedExamEngine.Helpers
{
    public static class PasswordHelper
    {
        public static string HashPassword(string plainPassword)
        {
            if (string.IsNullOrEmpty(plainPassword)) return string.Empty;

            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
                var sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            if (string.IsNullOrEmpty(enteredPassword) || string.IsNullOrEmpty(storedHash))
                return false;

            string enteredHash = HashPassword(enteredPassword);
            return string.Equals(enteredHash, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
