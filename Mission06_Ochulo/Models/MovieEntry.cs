using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Ochulo.Models
{
    public class MovieEntry
    {
        [Required]
        [Key]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }

        public string? Director { get; set; }

        public string? Rating { get; set; }

        [Required(ErrorMessage = "Edited is required.")]
        public int Edited { get; set; }

        public string? LentTo { get; set; }

        [Required(ErrorMessage = "Copied To Plex is required.")]
        public int CopiedToPlex { get; set; }

        [MaxLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }
    }
}