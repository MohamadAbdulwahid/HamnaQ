namespace HamnaQ.Models; 

public class Quiz
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string CreatedById { get; set; } = string.Empty;
    public ApplicationUser CreatedBy { get; set; } = null!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public QuizVisibility QuizVisibility { get; set; } = QuizVisibility.Public;
    public List<Question> Questions { get; set; } = [];
}

