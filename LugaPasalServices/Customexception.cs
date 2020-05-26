using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LugaPasalServices
{
    public class Customexception : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Result = new ViewResult()

            {
                ViewName = "Error"
            };
            filterContext.ExceptionHandled = true;


        }
    }
}
