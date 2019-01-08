using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace UltraCines.Models
{
    public class Movie
    {
        [JsonIgnore]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } 
    }
}