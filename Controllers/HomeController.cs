using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonRenderingApp.Controllers
{
    public class HomeController : Controller
    {
        //GET: Json Obj
        public ActionResult JsonPage()
        {
            return Json(new { Name =  Request.QueryString["developer"], Company = "Xyz"},JsonRequestBehavior.AllowGet);
        }
    }
}