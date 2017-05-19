using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace a.com.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            HttpCookie cookie = new HttpCookie("currentUser");
            cookie.HttpOnly = true;
            cookie.Expires = DateTime.Now.AddYears(100);//永不过期
            ViewBag.token = Request.Cookies["currentUser"].Value;
            cookie.Value = ViewBag.token;
            //验证是否登录
            
            return View();
        }

    }
}
