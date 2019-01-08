using System.ComponentModel.DataAnnotations;

namespace UltraCines.Models
{
    public class Movie
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } 
    }
}