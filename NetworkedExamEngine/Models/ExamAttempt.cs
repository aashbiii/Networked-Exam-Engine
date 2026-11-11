using System;

namespace NetworkedExamEngine.Models
{
    public class ExamAttempt
    {
        public int AttemptId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RollNo { get; set; }
        public int ExamId { get; set; }
        public string ExamTitle { get; set; }
        public string SubjectCode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int DurationTakenSeconds { get; set; }
        public int TotalQuestions { get; set; }
        public int AnsweredQuestions { get; set; }
        public int CorrectAnswers { get; set; }
        public int WrongAnswers { get; set; }
        public decimal Score { get; set; }
        public decimal Percentage { get; set; }
        public string Status { get; set; } // "Completed" or "TimedOut"
        public bool IsPassed { get; set; }

        public string FormattedDuration
        {
            get
            {
                var ts = TimeSpan.FromSeconds(DurationTakenSeconds);
                return $"{(int)ts.TotalMinutes}m {ts.Seconds}s";
            }
        }
    }
}
