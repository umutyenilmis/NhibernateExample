using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nhibernate.Core.Service.Interfaces;
using Nhibernate.Core.Service.Services;

namespace Nhibernate.UI.Controllers
{
    public class SiteController : Controller
    {
        //
        // GET: /Site/

		private readonly ISiteService _siteService;

        public SiteController(ISiteService siteService)
        {
            _siteService = siteService;
        }


        public ActionResult Index()
        {
			//_siteService.DummyData();
            return View();
        }
		

		public ActionResult GetData()
		{
			var result = _siteService.GetUser("Ali");

			return Json(new { Result = Convert.ToBoolean(_siteService.Result.ResultType), Code = _siteService.Result.Code, Message = _siteService.Result.Message, data = result }, JsonRequestBehavior.AllowGet);
		}
    }
}
