using Averis.WEBMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Averis.WEBMVC.Data.Configurations
{
    public class DetailProductImagesConfiguration : IEntityTypeConfiguration<AverisDetailProductImages>
    {
        public void Configure(EntityTypeBuilder<AverisDetailProductImages> builder)
        {
            builder.HasKey(proimage => proimage.Id);
            builder.Property(proimage => proimage.ImageUrl)
                   .IsRequired()
                   .HasMaxLength(500);
        }
    }
}
