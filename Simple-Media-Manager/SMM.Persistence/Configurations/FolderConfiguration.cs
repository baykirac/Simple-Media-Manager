using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain.Entities;

namespace SMM.Persistence.Configurations
{
    public class FolderConfiguration : IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
        {
            builder.ToTable("folders");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id)
                .UseIdentityColumn()
                .HasColumnName("id");

            builder.Property(f => f.FolderName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("folder_name");

            builder.Property(f => f.ParentId)
                .IsRequired()
                .HasColumnName("parent_id");

            builder.HasOne(f => f.Parent)
                .WithMany(f => f.Children)
                .HasForeignKey(f => f.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(f => f.Medias)
                .WithOne(m => m.Folder)
                .HasForeignKey(m => m.FolderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
        
    }
}
