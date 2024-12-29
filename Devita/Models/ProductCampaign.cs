namespace Devita.Models
{
    public class ProductCampaign
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CampaignId { get; set; }
        public Product Product { get; set; }
        public Campaign Campaign { get; set; }
    }
}
