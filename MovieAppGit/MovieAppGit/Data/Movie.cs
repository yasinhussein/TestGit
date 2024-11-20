using System.ComponentModel.DataAnnotations;

namespace MovieAppGit.Data
{
    public class Movie
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [Range(1900, 2100, ErrorMessage = "Release year must be between 1900 and 2100.")]
        public int ReleaseYear { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        [StringLength(200)]
        public string Director { get; set; }

        [Range(0, 10, ErrorMessage = "Rating must be between 0 and 10.")]
        public double Rating { get; set; }

        public string Description { get; set; }
    }
}
