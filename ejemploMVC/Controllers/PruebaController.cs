using ejemploMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }
     

        // GET: Prueba/Details/5
        // public ActionResult Details(int id)
        //{
        //  return View();
        //}

        // GET: Prueba/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
    
        public ActionResult Index( calculo obCalculo)
        {
            int resultado = obCalculo.numero1 + obCalculo.numero2;
            ViewBag.resultado = resultado;
            return View(obCalculo);
        }
        public ActionResult resta(calculo obCalculo)
        {
            int resultado = obCalculo.numero1 - obCalculo.numero2;
            ViewBag.resultado = resultado;
            return View(obCalculo);
        }
        //// GET: Prueba/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Prueba/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Prueba/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Prueba/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
    }
    }

