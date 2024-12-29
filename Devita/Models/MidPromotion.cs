using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class MidPromotion
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Img { get; set; }
        public int Order { get; set; }
    }
}
