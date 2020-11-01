using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class EstudianteController : Controller
    {
        public ActionResult notas()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult notas(calculo obCalculo)
        {
            double resultado = (obCalculo.nota1+obCalculo.nota2 + obCalculo.nota3)/3;
            if (resultado >= 7 & resultado < 10)
            {
                ViewBag.resultado = resultado + " Aprobado";
            }
            else if (resultado == 10)
            {
                ViewBag.resultado = resultado + " Felicitaciones";
            }
            else if (resultado <= 4)
            {
                ViewBag.resultado = resultado + " Reprobado Visite a un tutor urgente";
            }
            else
                ViewBag.resultado = resultado;
            return View(obCalculo);

        }


    }
}