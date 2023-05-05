using System.ComponentModel.DataAnnotations;

namespace MVCMovie.Models
{
    public class Genre
    {
        [Key]
        public int IdGenre { get; set; }
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}
