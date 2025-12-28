using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMM.Domain.Entities;

namespace SMM.Persistence.Configurations
{
    public class MediaConfiguration : IEntityTypeConfiguration<Media>
    {
        public void Configure (EntityTypeBuilder<Media> builder)
        {
            builder.ToTable("medias");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            builder.Property(m => m.MediaName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("media_name");

            builder.Property(m => m.MediaUrl)
                .IsRequired()
                .HasMaxLength(300)
                .HasColumnName("media_url");

            builder.Property(m => m.FolderId)
                .IsRequired()
                .HasColumnName("folder_id");
        }
    }
}
