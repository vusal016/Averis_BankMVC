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
            var financecategories = await _averisDb.HomeCategories.ToListAsync();
            var financeproducts = await _averisDb.FinanceProducts
                            .Include(finance => finance.Category).ToListAsync();
                              
            if (cards == null||!cards.Any())
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
                Cards= cards,
                HomeCategory= financecategories,
                FinanceProducts=financeproducts

            };
            
            return View(homeVm);
        }
        public async Task<IActionResult> Detail(string id)
        {
            var financesolution = await _averisDb.FinanceProducts
                .Include(finance=>finance.Category)
                .Include(finance => finance.ProductImages).FirstOrDefaultAsync(pi => pi.Id == id);  

            if (financesolution == null)
                return NotFound();
            FinanceDetailVM financeDetail = new FinanceDetailVM
            {
                FinanceProduct=financesolution
            };
            return View(financeDetail);
        }
    }
}
