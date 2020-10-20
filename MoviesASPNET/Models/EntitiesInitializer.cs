using System.Collections.Generic;
using System.Data.Entity;

namespace MoviesASPNET.Models
{
    public class EntitiesInitializer: DropCreateDatabaseIfModelChanges<MoviesContext>
    {
        protected override void Seed(MoviesContext context)
        {
            var genres = new List<Genre>
            {
                new Genre{Name="Sci-Fi"},
                new Genre{Name="Comedy"},
                new Genre{Name="Thriller"},
                new Genre{Name="Crime"},
                new Genre{Name="Horror"},
                new Genre{Name="Action"},
                new Genre{Name="Fantasy"},
                new Genre{Name="Drama"},
            };

            var languages = new List<Language>
            {
                new Language{Name="English"},
                new Language{Name="Chinese"},
                new Language{Name="Russian"},
                new Language{Name="French"},
                new Language{Name="Hindi"},
                new Language{Name="Spanish"},
                new Language{Name="Portuguese"},
                new Language{Name="Arabic"},
                new Language{Name="Japanese"},
                new Language{Name="Ukrainian"},
                new Language{Name="Persian"},
                new Language{Name="Polish"},
            };

            languages.ForEach(genre => context.Languages.Add(genre));
            genres.ForEach(genre => context.Genres.Add(genre));
            context.SaveChanges();  
        }
    }
}