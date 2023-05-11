using Microsoft.EntityFrameworkCore;
using UgraTech.Models;

namespace UgraTech.Context
{
    public class AppealsDbContext : DbContext
    {
        public AppealsDbContext(DbContextOptions<AppealsDbContext> options) : base(options)
        {
            
        }
        public DbSet<Appeals> Appeals { get; set; } 
    }
}
