using Microsoft.EntityFrameworkCore;
using SMM.Domain.Entities;

namespace SMM.Persistence.Context
{
    public class MediaManagerDbContext : DbContext
    {
        public MediaManagerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Folder> Folders => Set<Folder>();
        public DbSet<Media> Medias => Set<Media>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MediaManagerDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
