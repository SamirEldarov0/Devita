using Devita.Models;
using Microsoft.EntityFrameworkCore;

namespace Devita.DAL
{
    public class DevitaDbContext:DbContext
    {
        public DevitaDbContext(DbContextOptions<DevitaDbContext> options):base(options)
        {
            
        }

        public DbSet<AboutInfo> AboutInfos { get; set; }
        public DbSet<AboutPromotion> AboutPromotions { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<BrandLogo> BrandLogos { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<ProductCampaign> ProductCampaigns { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<MidPromotion> MidPromotions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<UpPromotion> UpPromotions { get; set; }






    }
}
