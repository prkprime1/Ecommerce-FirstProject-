using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LugaPasalWeb.Controllers
{
    public class SharedController : Controller
    {
        public JsonResult UploadImage()
        {
            JsonResult result = new JsonResult();
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            try
            {
                var file = Request.Files[0];
                var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName); // name change garna ko lagi name chgange garnu parcha 
                var path = Path.Combine(Server.MapPath("~/Content/images/"), fileName);
                file.SaveAs(path);
                result.Data = new { sucess = true, ImageURL = string.Format($"/Content/images/{fileName}") };
            }
            catch (Exception ex)
            {
                result.Data = new { sucess = false, Message = ex.Message };
            }
            return result;
        }

    }
}