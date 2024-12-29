using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class Color
    {
        public int Id { get; set; }
        [StringLength(maximumLength:70)]
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}
