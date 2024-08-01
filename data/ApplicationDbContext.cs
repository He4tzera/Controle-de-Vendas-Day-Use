using Controle.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        public DbSet<DayuseModel>Dayuse { get; set; }
    }
}
