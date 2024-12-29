using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [StringLength(maximumLength:40)]
        public string Image { get; set; }
        public bool? RowStatus { get; set; }
        public Product Product { get; set; }
    }
}
