using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LugaPasalModals
{
    public class ProductModals
    {
        public int pagenumber { get; set; }

        public int Id { get; set; }
        [Required]
        [MinLength(8), MaxLength(256)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public int  one { get; set; }
        public CategoryModal Category { get; set; }
    }
}
