using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class divisionController : Controller
    {
        public ActionResult division()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult division(calculo obCalculo)
        {
            int resultado = obCalculo.numero1 / obCalculo.numero2;
            ViewBag.resultado = resultado;
            return View(obCalculo);
        }
    }
}
   
