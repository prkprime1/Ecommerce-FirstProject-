using LugaPasalModals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaPasalWeb.Models.VirwModels
{
    public class HomeViewModels
    {
        public List<CategoryModal> FeaturedCategory { get; set; }
        public List<ProductModals> products { get; set; }

    }
}