using Microsoft.EntityFrameworkCore;

namespace Mission06_Ochulo.Models
{
    public class MovieEntryContext : DbContext  //liaison from the app to the database 
    {
        public MovieEntryContext(DbContextOptions <MovieEntryContext> options) : base (options) //Constructor
        { }

        public DbSet<MovieEntry> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //seed data
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Television" },
                new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 8, CategoryName = "VHS" },
                new Category { CategoryId = 9, CategoryName = "SciFi" }
                
            );

        }
    }
}
