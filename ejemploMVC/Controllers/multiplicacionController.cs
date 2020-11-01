using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class multiplicacionController : Controller
    {
        public ActionResult multiplicacion()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult multiplicacion(calculo obCalculo)
        {
            int resultado = obCalculo.numero1 * obCalculo.numero2;
            ViewBag.resultado = resultado;
            return View(obCalculo);
        }
    }
}
