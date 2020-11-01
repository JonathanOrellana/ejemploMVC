using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class KaCController : Controller
    {
        public ActionResult KelvinaCelsius()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KelvinaCelsius(calculo obCalculo)
        {
            double resultado = obCalculo.num - 273.15;
            ViewBag.resultado = resultado;
            return View(obCalculo);
        }
    }
}
