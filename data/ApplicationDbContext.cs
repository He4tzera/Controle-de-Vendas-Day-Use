using Controle.Models;
using Microsoft.EntityFrameworkCore;

namespace Controle.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<DayuseModel> Dayuse { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<DayuseModel>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    // Assegura que CreatedAt não será modificado
                    entry.Property(p => p.CreatedAt).IsModified = false;
                    entry.Entity.EditedAt = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<DayuseModel>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.CreatedAt = DateTime.Now;
                }
                else if (entry.State == EntityState.Modified)
                {
                    // Assegura que CreatedAt não será modificado
                    entry.Property(p => p.CreatedAt).IsModified = false;
                    entry.Entity.EditedAt = DateTime.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
