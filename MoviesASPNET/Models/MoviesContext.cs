using System.Data.Entity;

namespace MoviesASPNET.Models
{
    public class MoviesContext: DbContext
    {
        public MoviesContext() : base("name=MoviesDbEntities")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Language> Languages { get; set; }
    }
}