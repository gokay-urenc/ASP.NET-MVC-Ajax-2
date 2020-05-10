using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_34_Ajax_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Topla(int sayi1, int sayi2)
        {
            int toplamSonuc = sayi1 + sayi2;
            return Json(toplamSonuc, JsonRequestBehavior.AllowGet);
        }
    }
}