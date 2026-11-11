using System;

namespace NetworkedExamEngine.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Title { get; set; }
        public string SubjectCode { get; set; }
        public string Description { get; set; }
        public int DurationMinutes { get; set; }
        public int TotalQuestions { get; set; }
        public decimal PassPercentage { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        // Additional helper properties for Student views and analytics
        public int ActualQuestionCount { get; set; }
        public bool IsAttemptedByStudent { get; set; }
        public int? ExistingAttemptId { get; set; }
        public decimal? ExistingScore { get; set; }
        public decimal? ExistingPercentage { get; set; }
        public bool? ExistingIsPassed { get; set; }
    }
}
