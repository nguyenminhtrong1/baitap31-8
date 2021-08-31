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
        public ActionResult Timgiatrix(double soA, double soB)
        {
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            double Timx = so2 / so1;
            ViewBag.nghiemcuax = Timx;
            
            return View();
        }
    }
}