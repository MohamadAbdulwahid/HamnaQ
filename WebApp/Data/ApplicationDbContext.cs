using HamnaQ.Models;
using Microsoft.EntityFrameworkCore;

namespace HamnaQ.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Question> Questions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configure Quiz-Question relationship
        modelBuilder.Entity<Question>()
            .HasOne(q => q.Quiz)
            .WithMany(qz => qz.Questions)
            .HasForeignKey(q => q.QuizId);
            
        // Configure User-Quiz relationship
        modelBuilder.Entity<Quiz>()
            .HasOne(q => q.CreatedBy)
            .WithMany(u => u.CreatedQuizzes)
            .HasForeignKey(q => q.CreatedById);
    }
}