namespace HamnaQ.Models;

public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; } = null!;
    public List<string> Options { get; set; } = [];
    public int CorrectAnswerIndex { get; set; }
    public TimeSpan TimeLimit { get; set; } = TimeSpan.FromSeconds(30); // seconds
}