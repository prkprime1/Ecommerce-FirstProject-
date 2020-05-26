using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LugaPasalWeb.Controllers
{
    public class WidgetController : Controller
    {
        // GET: Widget
        public ActionResult Products()
        {
            return View();
        }
    }
}