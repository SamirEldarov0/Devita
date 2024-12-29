using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        [Required]
        public string Title { get; set; }
        [StringLength(maximumLength: 100)]
        public string Subtitle { get; set; }
    }
}
