using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
        public JsonResult GetAllCustomers(string testFromForms)
        {
            string testFromMvc = string.Concat(testFromForms, "FromMVC");
            List<string> data = new List<string>();
            data.Add(testFromForms);
            data.Add(testFromMvc);
            //  return Json(data, JsonRequestBehavior.AllowGet);
            var content = string.Format("<div id='ForSending'>Div contayner data<input id='Button1' type='button' value='button' /><input id='Button2' type='button' value='button' /></div>");
            return Json(content, JsonRequestBehavior.AllowGet);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
