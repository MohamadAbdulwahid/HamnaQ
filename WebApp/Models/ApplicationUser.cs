using Microsoft.AspNetCore.Identity;

namespace HamnaQ.Models;

public class ApplicationUser : IdentityUser
{
    public string DisplayName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public List<Quiz> CreatedQuizzes { get; set; } = [];
}