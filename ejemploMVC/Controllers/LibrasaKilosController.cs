using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class LibrasaKilosController : Controller
    {
        // GET: LibrasaKilos
        public ActionResult LibrasaKilos()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LibrasaKilos(calculo obCalculo)
        {
            double resultado = obCalculo.numero1 / 2.2046;
            ViewBag.resultado = resultado;
            return View(obCalculo);

        }
    }
}