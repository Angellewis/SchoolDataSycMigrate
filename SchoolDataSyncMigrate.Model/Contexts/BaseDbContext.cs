using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SchoolDataSyncMigrate.Core.BaseModel;
using SchoolDataSyncMigrate.Model.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchoolDataSyncMigrate.Model.Contexts
{
    public interface IDbContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
    public abstract class BaseDbContext : DbContext, IDbContext
    {
        public BaseDbContext(DbContextOptions options) : base(options)
        {
        }

        private void SetAuditEntities()
        {
            foreach (var entry in ChangeTracker.Entries<IBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:

                        entry.Entity.CreatedDate = DateTimeOffset.UtcNow;
                        break;

                    case EntityState.Modified:
                        entry.Property(x => x.CreatedDate).IsModified = false;
                        break;

                    case EntityState.Deleted:
                        entry.Property(x => x.CreatedDate).IsModified = false;
                        entry.State = EntityState.Modified;
                        break;

                    default:
                        break;
                }
            }
        }
        public override int SaveChanges()
        {
            SetAuditEntities();
            return base.SaveChanges();
        }
        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            SetAuditEntities();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            SetAuditEntities();
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
