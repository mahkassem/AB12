using AB12.Domain.Base.Common;
using AB12.Domain.Base.Schema;
using Microsoft.EntityFrameworkCore;

namespace AB12.Domain.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        // Audit Trailing
        private void Trail()
        {
            ChangeTracker.DetectChanges();

            // while adding
            var adding = this.ChangeTracker.Entries()
                .Where(track => track.State == EntityState.Added)
                .Select(track => track.Entity)
                .ToArray();

            foreach (var entity in adding)
            {
                if (entity is AuditableEntity auditableEntity)
                {
                    auditableEntity.CreatedAt = DateTime.UtcNow;
                    auditableEntity.UpdatedAt = DateTime.UtcNow;
                }
            }

            // while updating
            var updating = this.ChangeTracker.Entries()
                .Where(track => track.State == EntityState.Modified)
                .Select(track => track.Entity)
                .ToArray();

            foreach (var entity in updating)
            {
                if (entity is AuditableEntity auditableEntity)
                {
                    auditableEntity.UpdatedAt = DateTime.UtcNow;
                }
            }
        }

        public override int SaveChanges()
        {
            Trail();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            Trail();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            Trail();
            return base.SaveChangesAsync(cancellationToken);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
        {
            Trail();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
