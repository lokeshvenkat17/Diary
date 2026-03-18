using Diary.App.Models;
using Microsoft.EntityFrameworkCore;

namespace Diary.App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>  options) : base(options)
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
                    Title = "Went Hiking",
                    Content = "Went hiking with Aishu",
                    Created = new DateTime(2026, 3, 17, 10, 53, 38, 700, DateTimeKind.Local).AddTicks(9220)
                },

                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went Shopping",
                    Content = "Went shopping with Aishu",
                    Created = new DateTime(2026, 3, 17, 10, 53, 38, 700, DateTimeKind.Local).AddTicks(9542)
                },

                new DiaryEntry
                {
                    Id = 3,
                    Title = "Went Diving",
                    Content = "Went diving with Aishu",
                    Created = new DateTime(2026, 3, 17, 10, 53, 38, 700, DateTimeKind.Local).AddTicks(9544)
                });
        }
    }
}
