using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "First Entry",
                    Content = "This is the content of the first entry.",
                    Created = DateTime.FromOADate(2025 - 02 - 11)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Second Entry",
                    Content = "This is the content of the second entry.",
                    Created = DateTime.FromOADate(2025 - 02 - 12)
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "Third Entry",
                    Content = "This is the content of the third entry.",
                    Created = DateTime.FromOADate(2025 - 02 - 13)
                }
                );
        }
    }
}
