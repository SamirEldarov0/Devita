using Devita.DAL;
using Devita.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Devita.Controllers
{
    public class HomeController : Controller
    {
        private readonly DevitaDbContext _context;

        public HomeController(DevitaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Sliders=_context.Sliders.ToList(),
                UpPromotions=_context.UpPromotions.ToList(),
                NewProducts=_context.Products.Include(x=>x.ProductImages).Include(x=>x.Category).Where(x=>x.IsNew==true).ToList(),
                FeaturedProducts=_context.Products.Include(x => x.ProductImages).Include(x => x.Category).Where(x=>x.IsFeatured).ToList(),
                TopRatedProducts=_context.Products.Include(x => x.ProductImages).Include(x => x.Category).Where(x=>x.IsTopRated).ToList(),
                TopHeadphones=_context.Products.Include(x => x.ProductImages).Include(x => x.Category).Where(x=>x.IsTopHeadPhone).ToList(),
                BestSellingProducts=_context.Products.Include(x => x.ProductImages).Include(x => x.Category).Where(x=>x.IsBestSelling).ToList(),
                Setting=_context.Settings.FirstOrDefault(),
                AboutInfos=_context.AboutInfos.ToList(),
                Testimonials=_context.Testimonials.ToList()  
            };
            return View(homeViewModel);
        }
        public IActionResult Colors()
        {
            var colors = _context.Colors.ToList();
            return Json(colors);
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
