using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 80)]
        public string Icon { get; set; }
        [StringLength(maximumLength:350)]
        public string Desc { get; set; }
        public int Rate { get; set; }
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        [StringLength(maximumLength: 50)]
        public string Promotion { get; set; }
    }
}
