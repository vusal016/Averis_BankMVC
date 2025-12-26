using Averis.WEBMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Averis.WEBMVC.Data.Configurations
{
    public class AverisLitextConfiguration : IEntityTypeConfiguration<AverisLiText>
    {
        public void Configure(EntityTypeBuilder<AverisLiText> builder)
        {
            builder.HasKey(litext => litext.Id);
            
         
            builder.Property(litext => litext.Id)
                .ValueGeneratedOnAdd();
                
            builder.Property(litext => litext.Litext)
                   .IsRequired()
                   .HasMaxLength(500);
            }
        }
    }
    