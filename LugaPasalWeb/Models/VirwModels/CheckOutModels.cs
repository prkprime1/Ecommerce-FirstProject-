using LugaPasalModals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LugaPasalWeb.Models.VirwModels
{
    public class CheckOutModels
    {

        public List<ProductModals> CartProducts { get; set; }
        public List<int> cartProductID { get; set; }
    }
}