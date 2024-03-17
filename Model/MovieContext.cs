using Microsoft.EntityFrameworkCore;

namespace MovieAPI.Model
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }
    }
}