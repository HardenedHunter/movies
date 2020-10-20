using System.Collections.Generic;
using System.ComponentModel;

namespace MoviesASPNET.Models
{
    public class Language
    {
        public int Id { get; set; }

        [DisplayName("Original Language")]
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}