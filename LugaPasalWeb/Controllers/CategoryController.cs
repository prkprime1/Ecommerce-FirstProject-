using LugaPasalModals;
using LugaPasalServices;
using LugaPasalWeb.Models.VirwModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LugaPasalWeb.Controllers
{
   
    public class CategoryController : Controller
    {
        CategoryProcess process = null;

        public CategoryController()
        {
            process = new CategoryProcess();
        }

        public ActionResult Showall()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(CategoryModal modal)
        {
            if (ModelState.IsValid)
            {
                int id = process.Save(modal);
                if (id > 0)
                {
                    return RedirectToAction("Index");
                }
               
            }
            return PartialView();

        }
        [HttpGet]
        public ActionResult Index(string Search, int? pageNo)
        {
            CategoryViewModal modal = new CategoryViewModal();
          

           
            
                var All = process.GetAll();
                if (string.IsNullOrEmpty(Search) == false)
                {
                    All = All.Where(p => p.Name != null && p.Name.Contains(Search)).ToList();
                }
            modal.Pager = new pager(500 , pageNo);

            return PartialView(All);
            

            
        }
        [HttpGet]
        public ActionResult Edit(int id )
        {
            if (ModelState.IsValid)
            {
                var result = process.GetOne(id);
                return PartialView(result);

            }
            return PartialView();

        }
        [HttpPost]
        public ActionResult Edit(int id, CategoryModal modal)
        {
            var result = process.Edit(id, modal);
            return RedirectToAction("Index");

        }
       
        public ActionResult Details(int id)
        {
            var result = process.GetOne(id);
            return View(result);

        }

        public ActionResult Delete(int id)
        {
            var result = process.DeleteEmploye(id);
            return RedirectToAction("Index");
        }

    }

}