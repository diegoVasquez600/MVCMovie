﻿using System.ComponentModel.DataAnnotations;

namespace MVCMovie.Models
{
    public class Movie
    {
        [Key]
        public int IdMovie { get; set; }
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        public int GenreId { get; set; }
        public virtual Genre? Genre { get; set; }
        public int Year { get; set; }
    }
}
