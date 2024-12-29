using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public double DiscountPercent { get; set; }
        public List<ProductCampaign> ProductCampaigns { get; set; }

    }
}
