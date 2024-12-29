using Devita.Models;
using System.Collections.Generic;

namespace Devita.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider> Sliders { get; set; }
        public List<UpPromotion> UpPromotions { get; set; }
        public List<Feature> Features { get; set; }
        public Setting Setting { get; set; }
        public List<Product> NewProducts { get; set; }
        public List<Product> FeaturedProducts { get; set; }
        public List<Product> TopRatedProducts { get; set; }
        public List<Product> BestSellingProducts { get; set; }
        public List<Product> TopHeadphones { get; set; }
  
        public List<BrandLogo> BrandLogos { get; set; }
        public List<AboutInfo> AboutInfos { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        public List<Testimonial> Testimonials { get; set; }





    }
}
