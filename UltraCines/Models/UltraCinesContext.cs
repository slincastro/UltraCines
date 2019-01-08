using Microsoft.EntityFrameworkCore;

namespace UltraCines.Models
{
    public class UltraCinesContext : DbContext
    {
        public UltraCinesContext(DbContextOptions<UltraCinesContext> options) : base(options)         
        {         
        }       
        
        public DbSet<Movie> Movies     { get; set; }     
    }
}