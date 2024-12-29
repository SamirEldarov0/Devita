using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [StringLength(maximumLength:50)]
        [Required]
        public string Title { get; set; }
        [StringLength(maximumLength: 100)]
        public string Subtitle { get; set; }
        [Required]
        public double StartPrice { get; set; }
        [StringLength(maximumLength: 30)]
        public string BtnTxt { get; set; }
        [StringLength(maximumLength: 50)]
        public string BgImg { get; set; }

    }
}
