using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [Authorize] // This ActionFilter says that user need to be log in in order to use Search action
        public ActionResult Search(string name = "french")
        {
            var message = Server.HtmlEncode(name);
            return Json(new { Message = message, name = "Ivan" }, JsonRequestBehavior.AllowGet);
        }
    }
}