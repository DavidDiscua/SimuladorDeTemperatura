using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimuladorTemperatura.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Simulador()
        {
            ViewBag.Message = "Simulador";

            return View();
        }
    }
}