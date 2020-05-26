using LugaPasalServices;
using LugaPasalWeb.Models.VirwModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LugaPasalWeb.Controllers
{
    public class HomeController : Controller
    {
        CategoryProcess process = null;

        public HomeController()
        {
            process = new CategoryProcess();
        }

        public ActionResult Index()
        {
            HomeViewModels model = new HomeViewModels();
           model.FeaturedCategory = process.GetFeaturedCategories();
            
            return View(model);
        }

        public ActionResult About()
        {
            
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}