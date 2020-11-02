using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class MetrsoaPulgadasController : Controller
    {
        public ActionResult MetrosaPulgadas()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MetrosaPulgadas(calculo obCalculo)
        {
            double resultado = obCalculo.numero1 *39.370078740158;
            ViewBag.resultado = resultado;
            return View(obCalculo);

        }
    }
}