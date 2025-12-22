using Averis.WEBMVC.Data;
using Averis.WEBMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AverisWEBMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AverisDbContext _averisDb;

        public HomeController(AverisDbContext averisDb)
        {
            _averisDb = averisDb;
        }

        public async Task<IActionResult> Index()
        {
            var slides = await _averisDb.Sliders.ToListAsync();
            var about = await _averisDb.Abouts
                            .Include(a => a.LiTexts)
                            .FirstOrDefaultAsync();
            var cards = await _averisDb.HomeCards.ToListAsync();
            if (cards == null|!cards.Any())
            {
                return NotFound("Kartlar tapilmadi");
            }
            if (slides == null||!slides.Any())
            {
                return NotFound("Slider tapılmadı");
            }
            
            if (about == null)
            {
                return NotFound("About məlumatı tapılmadı");
            }

            HomeVm homeVm = new HomeVm
            {
                Slider = slides,
                About = about,
                Cards= cards
            };
            
            return View(homeVm);
        }
    }
}
