using Averis.WEBMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Averis.WEBMVC.Data
{
    public class AverisDbContext:DbContext
    {
        public AverisDbContext(DbContextOptions <AverisDbContext> options):base(options)
        {
            
        }
        public DbSet<AverisSlider> Sliders { get; set; }
        public DbSet<AverisAbout> Abouts { get; set; }
        public DbSet<AverisLiText> LiTexts { get; set; }
        public DbSet<AverisHomeCards> HomeCards { get; set; }
        public DbSet<AverisDetailProductImages> DetailProductImages { get; set; }
        public DbSet<AverisHomeCategory> HomeCategories { get; set; }
        public DbSet<FinanceProduct> FinanceProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AverisDbContext).Assembly);
        }
    }
}