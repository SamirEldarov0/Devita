using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int ColorId { get; set; }
        [StringLength(maximumLength:50)]
        public string Name { get; set; }
        public double ProducingPrice { get; set; }
        public double Price { get; set; }
        public double DiscountedPrice { get; set; }
        public int Rate { get; set; }
        [StringLength(maximumLength: 50)]
        [Required]
        public string Code { get; set; }
        [StringLength(maximumLength: 1500)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 50)]
        public string ProtectionPlan { get; set; }
        public double RemoteHolder { get; set; }
        [StringLength(maximumLength: 50)]
        public string Case { get; set; }
        [StringLength(maximumLength: 50)]
        public string Antenna { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsTopRated { get; set; }
        public bool IsBestSelling { get; set; }
        public bool IsTopHeadPhone { get; set; }
        public Color Color { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public List<ProductImage> ProductImages { get; set; }
        public List<ProductCampaign> ProductCampaigns { get; set; }
        public List<ProductTag> ProductTags { get; set; }


    }
}
