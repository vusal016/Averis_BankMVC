using Averis.WEBMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Averis.WEBMVC.Data.Configurations
{
    public class AverisHomeCardsConfiguration : IEntityTypeConfiguration<AverisHomeCards>
    {
        public void Configure(EntityTypeBuilder<AverisHomeCards> builder)
        {
            builder.HasKey(card => card.Id);
            builder.Property(card => card.Title)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(card => card.Text)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(card => card.IconUrl)
                    .IsRequired()
                    .HasMaxLength(500);
        }
    }
}
