using Averis.WEBMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Averis.WEBMVC.Data.Configurations
{
    public class FinanceProductConfiguration : IEntityTypeConfiguration<FinanceProduct>
    {
        public void Configure(EntityTypeBuilder<FinanceProduct> builder)
        {
            builder.HasKey(finance => finance.Id);
            builder.Property(finance => finance.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(finance => finance.Description)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(finance => finance.Link)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(finance => finance.ImageUrl)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(finance => finance.CratedAt)
                   .IsRequired();
            builder.Property(finance => finance.Client)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(finance => finance.ProjectUrl)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(finance => finance.DetailTitle)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.Property(finance => finance.DetailText)
                    .IsRequired()
                    .HasMaxLength(500);
            builder.HasMany(finance => finance.ProductImages)
                    .WithOne(finance => finance.FinanceProduct)
                    .HasForeignKey(finance => finance.FinanceProductId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
