using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        // 4 Steps to add a table
        // 1. Create a Model Class
        // 2. Add DB Set
        // 3. add-migration AddDiaryEntryTable
        // 4. update-database

        public DbSet<DiaryEntry> DiaryEntries { get; set; } // entity framework core part 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(

                new DiaryEntry { Id = 1, Title = "Went Hiking", Content = "Went Hiking with Joe", Created = "24.11.2025" },
                new DiaryEntry { Id = 2, Title = "Prepping for Meeting", Content = "Prepared slides for the Q4 review.", Created = "20.11.2024" }
                );
        }
    }
}
