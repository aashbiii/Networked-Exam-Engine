using System;

namespace NetworkedExamEngine.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int ExamId { get; set; }
        public string ExamTitle { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public char CorrectOption { get; set; } // 'A', 'B', 'C', 'D'
        public int Marks { get; set; } = 1;
        public string Explanation { get; set; }
        public DateTime CreatedAt { get; set; }

        // Runtime selection tracking during an active exam attempt
        public char? SelectedOption { get; set; }
        public bool IsMarkedForReview { get; set; }
        public bool IsAnswered => SelectedOption.HasValue;
    }
}
