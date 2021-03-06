using Microsoft.EntityFrameworkCore;
using ShowdeBola.Models;

namespace ShowdeBola.Data
{
    public class ShowdeBolaContext : DbContext
    {
        public ShowdeBolaContext(DbContextOptions<ShowdeBolaContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie {get; set;}
        public DbSet<Actor> Actor {get; set;}
    }
}
