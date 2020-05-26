using LugaPasalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LugaPasalModals;
using System.Web.WebSockets;
using System.Web.UI;

namespace LugaPasalWeb.Controllers
{
    public class ProductController : Controller
    {
        ProductServices process = null;

        public ProductController()
        {
            process = new ProductServices();
        }

        public ActionResult ShowAll()
        {
            

                return View();
            
        }


        [HttpGet]
        public ActionResult Create()
        {
            CategoryProcess categoryService = new CategoryProcess();
            var categories = categoryService.GetAll();

            return PartialView(categories);
        }

        [HttpPost]
        public ActionResult Create(ProductModals modal)
        {
            int id = process.Save(modal);
            if (id > 0)
            {
                return RedirectToAction("Index");
            }
            return PartialView();
        }

        [HttpGet]
        public ActionResult Index(string Search, int? pageNO)
        {


            pageNO = pageNO.HasValue ? pageNO.Value >0? pageNO.Value : 1  : 1;

            



           
            var All = process.GetAll(pageNO.Value);
            if (string.IsNullOrEmpty(Search) == false)
            {
                All = All.Where(p => p.Name != null && p.Name.Contains(Search)).ToList();


            }

                
                      

            return PartialView(All);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var result = process.GetOne(id);
            return PartialView(result);

        }
        [HttpPost]
        public ActionResult Edit(int id, ProductModals modal)
        {
            var result = process.Edit(id, modal);
            return RedirectToAction("Index");

        }

        public ActionResult Details(int id)
        {
            var result = process.GetOne(id);
            return View(result);

        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var result = process.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

    }
}