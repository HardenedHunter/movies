using System.Collections.Generic;
using System.ComponentModel;

namespace MoviesASPNET.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [DisplayName("Genre")]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}