using MVC_CSRF_AJAX.Filters;
using MVC_CSRF_AJAX.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CSRF_AJAX.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // http://kevintsengtw.blogspot.tw/2013/09/aspnet-mvc-csrf-ajax-antiforgerytoken.html
        public ActionResult AccountEdit()
        {
            return View();
        }

        [HttpPost]
        [AjaxValidateAntiForgeryToken]
        public ActionResult Edit(Account model)
        {
            JObject jo = new JObject();

            if (!ModelState.IsValid)
            {
                jo.Add("success", false);
                jo.Add("message", "欄位有空缺，請輸入完整。");
                return Content(JsonConvert.SerializeObject(jo), "application/json");
            }

            jo.Add("success", true);
            return Content(JsonConvert.SerializeObject(jo), "application/json");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AccountEdit(Account model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View(model);
        }
    }
}