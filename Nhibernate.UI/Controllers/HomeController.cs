using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nhibernate.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public JsonResult Index()
        {
			return Json(new { Result = true, Code = 0,Message = "" , data = ""}, JsonRequestBehavior.AllowGet);
        }

    }
}
