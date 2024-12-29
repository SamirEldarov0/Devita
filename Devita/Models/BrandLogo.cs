using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class BrandLogo
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 100)]
        public string Img { get; set; }

    }
}
