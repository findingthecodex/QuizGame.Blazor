namespace QuizGame.Blazor.Components.Models;

public class QuizQuestion
{
        public string Question { get; set; } = "";
        public string CorrectAnswer { get; set; } = "";
        public List<string> Answers { get; set; } = new();
    
}