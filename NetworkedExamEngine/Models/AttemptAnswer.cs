using System;

namespace NetworkedExamEngine.Models
{
    public class AttemptAnswer
    {
        public int AnswerId { get; set; }
        public int AttemptId { get; set; }
        public int QuestionId { get; set; }
        public char? SelectedOption { get; set; } // 'A', 'B', 'C', 'D' or null
        public char CorrectOption { get; set; }
        public bool IsCorrect { get; set; }
        public int MarksObtained { get; set; }

        // Associated Question details for the question-by-question performance report
        public int QuestionNumber { get; set; }
        public string QuestionText { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public string Explanation { get; set; }

        public string SelectedOptionText
        {
            get
            {
                if (!SelectedOption.HasValue) return "Not Answered (Skipped)";
                switch (SelectedOption.Value)
                {
                    case 'A': return $"Option A: {OptionA}";
                    case 'B': return $"Option B: {OptionB}";
                    case 'C': return $"Option C: {OptionC}";
                    case 'D': return $"Option D: {OptionD}";
                    default: return "Not Answered";
                }
            }
        }

        public string CorrectOptionText
        {
            get
            {
                switch (CorrectOption)
                {
                    case 'A': return $"Option A: {OptionA}";
                    case 'B': return $"Option B: {OptionB}";
                    case 'C': return $"Option C: {OptionC}";
                    case 'D': return $"Option D: {OptionD}";
                    default: return $"Option {CorrectOption}";
                }
            }
        }
    }
}
