using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MoviesASPNET.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [DisplayName("Genre")]
        public int? GenreId { get; set; }

        [DisplayName("Original Language")]
        public int? LanguageId { get; set; }

        [DisplayName("Release Year")]
        [Required(ErrorMessage = "Year is required")]
        [Range(1895, 2030, ErrorMessage = "Year should be between 1895 and 2030")]
        public string ReleaseYear { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(127, MinimumLength = 1, ErrorMessage = "Name should consist of 1-127 characters")]
        public string Name { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual Language Language { get; set; }
    }
}