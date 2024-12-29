using Devita.DAL;
using Devita.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Devita.Controllers
{
    public class ProductController : Controller
    {
        private readonly DevitaDbContext _context;

        public ProductController(DevitaDbContext context)
        {
            _context = context;
        }

        public IActionResult Action()
        {
            return View();
        }

        public IActionResult Petail(int id=22)
        {
            return View();
        }
        //public IActionResult Detail(int id = 20)
        //{
        //    return View();
        //}
        public IActionResult Detail2(int id=16)
        {
            Product product = _context.Products
                .Include(x=>x.ProductImages).Include(x=>x.Category).Include(x=>x.Color).Include(x=>x.ProductTags).ThenInclude(x=>x.Tag)
                .Include(x=>x.ProductCampaigns).ThenInclude(x=>x.Campaign)
                .Include(x=>x.Brand)
                .FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            var relatedProducts=_context.Products
                .Include(x => x.ProductImages).Include(x => x.Category).Include(x => x.Color).Include(x => x.ProductTags).ThenInclude(x => x.Tag)
                .Include(x => x.ProductCampaigns).ThenInclude(x => x.Campaign)
                .Include(x => x.Brand)
                .Where(x=>x.CategoryId==product.CategoryId).ToList();
            ViewBag.RelatedProducts=relatedProducts;
            return View(product);

        }

    }
}
