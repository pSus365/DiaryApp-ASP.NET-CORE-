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
        // 1 Create a Model Class
        // 2 Add DB Set
        // 3 add-migration AddDiaryEntryTable
        // 4 update-database

        public DbSet<DiaryEntry> DiaryEntries { get; set; } // entity framework core part 
    }
}
