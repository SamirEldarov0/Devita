using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public List<ProductTag> ProductTags { get; set; }

    }
}
