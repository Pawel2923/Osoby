using Microsoft.AspNetCore.Mvc;
using Osoby.DAL;
using Osoby.Models;
using System.Diagnostics;

namespace Osoby.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        public ActionResult Edit()
        {
            return View("Edit");
        }

        public ActionResult Delete()
        {
            return View("Delete");
        }

        private Osoba ObliczBMI(Osoba osoba)
        {
            osoba.BMI = osoba.Waga / osoba.Wzrost;
            string wskaznik = osoba.BMI switch
            {
                0 => "Brak danych",
                double b when b <= 16.9 => "Ciê¿ka niedowaga (III stopieñ szczup³oœci)",
                double b when b <= 18.49 => "Umiarkowana niedowaga (II stopieñ szczup³oœci)",
                double b when b <= 24.9 => "Prawid³owa waga u osób w wieku 18-65",
                double b when b <= 27.0 => "Œrednia po¿¹dana masa cia³a u osób starszych (65+)",
                double b when b <= 29.9 => "Nadwaga u osób w wieku 18-65",
                double b when b <= 34.9 => "Oty³oœæ I stopnia",
                double b when b <= 39.9 => "Oty³oœæ II stopnia",
                _ => "Oty³oœæ III stopnia",
            };
            osoba.WskaznikBMI = wskaznik;

            return osoba;
        }

        [HttpPost]
        public ActionResult CreateOsoba(Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", osoba);
            }
            else
            {
                OsobaContext db = new OsobaContext();
                osoba = ObliczBMI(osoba);
                Debug.WriteLine("Parametry osoby: ");
                Debug.WriteLine(osoba.Imie);
                Debug.WriteLine(osoba.Nazwisko);
                Debug.WriteLine(osoba.Wiek);
                Debug.WriteLine(osoba.Waga);
                Debug.WriteLine(osoba.BMI);
                Debug.WriteLine(osoba.WskaznikBMI);
                db.Osoby.Add(osoba);
                db.SaveChanges();
                return View("Index");
            }
        }

        [HttpPost]
        public ActionResult DeleteOsoba(int id)
        {
            OsobaContext db = new OsobaContext();
            Osoba osoba = db.Osoby.Find(id);
            db.Osoby.Remove(osoba);
            db.SaveChanges();
            return View("Index");
        }

        [HttpPost]
        public ActionResult EditOsoba(Osoba osoba)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", osoba);
            }
            else
            {
                OsobaContext db = new OsobaContext();
                Osoba osobaDoEdycji = db.Osoby.Find(osoba.OsobaId);
                osobaDoEdycji.Imie = osoba.Imie;
                osobaDoEdycji.Nazwisko = osoba.Nazwisko;
                osobaDoEdycji.Wiek = osoba.Wiek;
                osobaDoEdycji.Waga = osoba.Waga;
                osobaDoEdycji.Wzrost = osoba.Wzrost;
                Osoba osobaBMI = ObliczBMI(osobaDoEdycji);
                osobaDoEdycji.BMI = osobaBMI.BMI;
                osobaDoEdycji.WskaznikBMI = osobaBMI.WskaznikBMI;
                db.SaveChanges();
                return View("Index");
            }
        }

        public ActionResult Read()
        {
            OsobaContext db = new OsobaContext();
            List<Osoba> osoby = db.Osoby.ToList();
            return View("Read", osoby);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
