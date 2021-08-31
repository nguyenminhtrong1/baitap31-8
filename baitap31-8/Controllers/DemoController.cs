using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baitap31_8.Controllers
{
    public class DemoController : Controller
    {
        public ActionResult index()
        {
            return View();
        }
        public ActionResult Timgiatrix(string soA, string soB)
        {
            int so1 = Convert.ToInt16(soA);
            int so2 = Convert.ToInt16(soB);
            int Timx = so2 / so1;
            ViewBag.nghiemcuax = Timx;
            
            return View();
        }
    }
}