using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTapTH.Models;

namespace BaiTapTH.Controllers
{
    public class DemoController : Controller
    {
        GiaiPTB1 gpt = new GiaiPTB1();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GiaiPTB1 (double HesoA, double HesoB)
        {
            double x = gpt.GiaiPT(HesoA, HesoB);
            ViewBag.NghiemPT =x;
            return View();
        }

    }
}