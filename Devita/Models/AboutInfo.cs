using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class AboutInfo
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 80)]
        public string Icon { get; set; }
        public int Count { get; set; }
        [StringLength(maximumLength: 30)]
        public string Title { get; set; }

    }
}
