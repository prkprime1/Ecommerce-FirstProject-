using LugaPasalServices;
using LugaPasalWeb.Models.VirwModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LugaPasalWeb.Controllers
{
    public class ShopController : Controller
    {
        ProductServices productsService = new ProductServices();

        public ActionResult CheckOut()
        {
            CheckOutModels model = new CheckOutModels();

            var cartproductsCookie = Request.Cookies["CartProduct"];
            if (cartproductsCookie != null)
            {
                //var productID = cartproductsCookie.Value;// hamile uta - bata separate gareko
                //var ids = productID.Split('-'); // teslai split gareko

                //List<int> PpiDS = ids.Select(x => int.Parse(x)).ToList(); //teslai int ma convert gareko

                model.cartProductID = cartproductsCookie.Value.Split('-').Select(x => int.Parse(x)).ToList();

               
                model.CartProducts = productsService.GetOne(model.cartProductID);
            }

            return View(model);
        }
    }
}