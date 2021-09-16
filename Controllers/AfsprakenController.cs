using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PriorityDogs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriorityDogs.Controllers
{
    public class AfsprakenController : Controller
    {
        static List<AfsprakenModel> Afspraken = new List<AfsprakenModel>();

        public ActionResult Index()
        {

            return View(Afspraken);
        }

        public ActionResult Create()
        {
            return View();
        }

            public ActionResult Details(AfsprakenModel afspraken)
        {
            Afspraken.Add(afspraken);
            return View(afspraken);
        }

        public ActionResult Edit()
        {
            
            return View();
        }


        public ActionResult Delete(AfsprakenModel AfsprakenController)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
            /*
              [HttpPost]
              [ValidateAntiForgeryToken]
              public ActionResult Create(IFormCollection collection)
              {
                  try
                  {
                      return RedirectToAction(nameof(Index));
                  }
                  catch
                  {
                      return View();
                  }
              }

              // POST: AfsprakenController/Edit/5
              [HttpPost]
              [ValidateAntiForgeryToken]
              public ActionResult Edit(int id, IFormCollection collection)
              {
                  try
                  {
                      return RedirectToAction(nameof(Index));
                  }
                  catch
                  {
                      return View();
                  }
              }

              // POST: AfsprakenController/Delete/5
              [HttpPost]
              [ValidateAntiForgeryToken]
              public ActionResult Delete(int id, IFormCollection collection)
              {
                  try
                  {
                      return RedirectToAction(nameof(Index));
                  }
                  catch
                  {
                      return View();
                  }
              }      */

