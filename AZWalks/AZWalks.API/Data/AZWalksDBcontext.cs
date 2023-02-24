using AZWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
namespace AZWalks.API.Data
{
    public class AZWalksDBcontext : DbContext
    {
        
        public AZWalksDBcontext(DbContextOptions<AZWalksDBcontext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDeficulty> WalkDeficulty { get; set; }
    }
}
