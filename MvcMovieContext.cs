using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

//Creates a DbSet<Movie> property for the entity set.In Entity Framework terminology, an entity set typically corresponds to a database table...
//...an entity corresponds to a row in the table.

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movies> Movie { get; set; }
    }
}