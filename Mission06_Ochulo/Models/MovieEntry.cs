﻿using System.ComponentModel.DataAnnotations;

namespace Mission06_Ochulo.Models
{
    public class MovieEntry
    {
        [Required]
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required.")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }

        // Not marked as [Required], so it's optional
        public bool Edited { get; set; }

        // Optional field
        public string LentTo { get; set; }

        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string Notes { get; set; }
    }
}