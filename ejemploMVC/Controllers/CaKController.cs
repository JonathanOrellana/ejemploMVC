using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class CaKController : Controller
    {
        public ActionResult CelsiusaKelvin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CelsiusaKelvin(calculo obCalculo)
        {
            double resultado = obCalculo.numero1+273.15;
            ViewBag.resultado = resultado;
            return View(obCalculo);
        }

    }
}
