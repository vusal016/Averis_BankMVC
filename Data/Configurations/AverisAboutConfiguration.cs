using Averis.WEBMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Averis.WEBMVC.Data.Configurations
{
    public class AverisAboutConfiguration : IEntityTypeConfiguration<AverisAbout>
    {
        public void Configure(EntityTypeBuilder<AverisAbout> builder)
        {
            builder.HasKey(about => about.Id);
            builder.Property(about => about.LittleTitle)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(about => about.BigTitle)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(about => about.FirstText)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(about => about.SecondText)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(about => about.ButtonText)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(about => about.ButtonLink)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasMany(about => about.LiTexts)
                    .WithOne(about => about.AverisAbout)
                    .HasForeignKey(about => about.AverisAboutId)
                    .OnDelete(DeleteBehavior.Cascade);
                    
        }
    }
}
