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
    }
}