using Microsoft.AspNetCore.Mvc;
using Osoby.Models;

namespace Osoby.Controllers
{
    public class OsobaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult Edit(Osoba osoba)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Osoba osoba)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Details(Osoba osoba)
        {
            return RedirectToAction("Index");
        }
    }
}
