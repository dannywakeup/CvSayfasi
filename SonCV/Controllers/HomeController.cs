using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SonCV.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Route("hakkimda")]
        public ActionResult Hakkimda()
        {
            return View();
        }
        [Route("deneyimlerim")]
        public ActionResult Deneyimlerim()
        {
            return View();
        }
        [Route("egitimim")]
        public ActionResult Egitimim()
        {
            return View();
        }
        [Route("becerilerim")]
        public ActionResult Becerilerim()
        {
            return View();
        }
        [Route("hobilerim")]
        public ActionResult Hobilerim()
        {
            return View();
        }
        [Route("kazanimlarim")]
        public ActionResult Kazanimlarim()
        {
            return View();
        }
    }
}