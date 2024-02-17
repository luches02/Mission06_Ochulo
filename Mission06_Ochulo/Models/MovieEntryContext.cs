using Microsoft.EntityFrameworkCore;

namespace Mission06_Ochulo.Models
{
    public class MovieEntryContext : DbContext
    {
        public MovieEntryContext(DbContextOptions <MovieEntryContext> options) : base (options) //Constructor
        { }

        public DbSet<MovieEntry> MovieEntries { get; set; }
    }
}
