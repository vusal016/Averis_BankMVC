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
            var slide = await _averisDb.Sliders.FirstOrDefaultAsync();
            var about = await _averisDb.Abouts.FirstOrDefaultAsync();
            
            if (slide == null)
            {
                return NotFound("Slider tapılmadı");
            }
            
            if (about == null)
            {
                return NotFound("About məlumatı tapılmadı");
            }

            HomeVm homeVm = new HomeVm
            {
                Slider = slide,
                About = about
            };
            
            return View(homeVm);
        }
    }
}
