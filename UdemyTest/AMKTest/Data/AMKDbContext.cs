using AMKTest.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AMKTest.Data
{
    public class AMKDbContext : DbContext
    {

        public AMKDbContext(DbContextOptions<AMKDbContext> options) : base(options)
        {
            

        }

        public DbSet<Region> TblRegion { get; set; }
        public DbSet<Walk> TblWalk { get; set; }
        public DbSet<WalkDifficulty> TblWalkDifficulty { get; set; }
    }
}
