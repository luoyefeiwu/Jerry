using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionShared.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (this.HttpContext.Session["MySession"] == null)
            {
                this.HttpContext.Session["MySession"] = "我是Session你猜对了吗";
            }
            return View();
        }
        public ActionResult GetSession()
        {
            if (this.HttpContext.Session["MySession"] != null)
            {
                ViewBag.MySession = this.HttpContext.Session["MySession"].ToString();
                ViewBag.SessionID = this.HttpContext.Session.SessionID;
            }
            return View();
        }
    }
}