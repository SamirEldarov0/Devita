using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        [StringLength(maximumLength:50)]
        [Required]
        public string Image { get; set; }
        [StringLength(maximumLength:50)]
        public string FIcon { get; set; }
        [StringLength(maximumLength: 50)]
        public string TIcon { get; set; }
        [StringLength(maximumLength: 50)]
        public string IIcon { get; set; }
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }
        [StringLength(maximumLength: 20)]
        public string Role { get; set; }
        public int Order { get; set; }





    }
}
