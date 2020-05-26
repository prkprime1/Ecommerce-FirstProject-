using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LugaPasalModals
{
     public class CategoryModal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int ProductID { get; set; }

        public bool IsFeatured { get; set; }

    }
}
