using Averis.WEBMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Averis.WEBMVC.Data.Configurations
{
    public class HomeCategoryConfiguration : IEntityTypeConfiguration<AverisHomeCategory>
    {
        public void Configure(EntityTypeBuilder<AverisHomeCategory> builder)
        {
            builder.HasKey(category => category.Id);
            builder.Property(category => category.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.HasMany(category => category.FinanceProducts)
                    .WithOne(category => category.Category)
                    .HasForeignKey(category => category.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
                    
        }
    }
}
