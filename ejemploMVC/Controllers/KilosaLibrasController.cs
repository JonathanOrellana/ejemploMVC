using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class KilosaLibrasController : Controller
    {
        // GET: KilosaLibras
            public ActionResult KilosaLibras()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult KilosaLibras(calculo obCalculo)
        {
            double resultado = obCalculo.numero1 * 2.2046;
            ViewBag.resultado = resultado;
            return View(obCalculo);
        
    }
    }
}