using DataAccess.Context;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebUI.Models;
using WebUI.Models.Dtos;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

       

        public IActionResult Index(int id)
        {
            var model = _context.AgriHastaBakimPlanlari
                .Include(a => a.Hasta)
                .Include(a => a.Hemsire)
                .Include(a => a.Girisimler)
                .Include(a => a.Nedenler) 
                .Include(a => a.TaniOlculeriList) 
                .Include(a => a.Amaclar) 
                .Include(a => a.Degerlendirmeler) 
                .FirstOrDefault(a => a.Id == id);



            if (model == null)
            {
                return NotFound();
            }

            //if (model.Degerlendirmeler == null)
            //{
            //    model.Degerlendirmeler = new List<CheckboxItem>();
            //}

            if (model.Sonuclar == null)
            {
                model.Sonuclar = new List<Sonuc>();
            }

            ViewBag.Girisimler = _context.Girisimler.Where(g => g.Id == id).ToList();

            return View(model);
        }

        public IActionResult YeniHasta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HastaEkle(Hasta yeniHasta)
        {
            if (ModelState.IsValid)
            {
                _context.Hastalar.Add(yeniHasta);
                _context.SaveChanges();
                return RedirectToAction("Index", new { id = yeniHasta.Id });
            }
            return View("YeniHasta", yeniHasta);
        }

        [HttpPost]
        public IActionResult EkleGirisim(int id, string girisim)
        {
            var yeniGirisim = new Girisim
            {
                AgriHastaBakimPlaniId = id,
                Description = girisim
            };

            _context.Girisimler.Add(yeniGirisim);
            _context.SaveChanges();

            return RedirectToAction("Index", new { id = id });
        }

        [HttpPost]
        public IActionResult NedenAddDetails(int id, string NedenDescription)
        {
            if (!string.IsNullOrWhiteSpace(NedenDescription))
            {
                var agriHastaBakimPlani = _context.AgriHastaBakimPlanlari.FirstOrDefault(a => a.Id == id);
                if (agriHastaBakimPlani != null)
                {
                    var neden = new Neden
                    {
                        Description = NedenDescription,
                        AgriHastaBakimPlaniId = agriHastaBakimPlani.Id
                    };

                    _context.Nedenler.Add(neden);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index", new { id });
        }

        [HttpPost]
        public IActionResult TaniAddDetails(int id, string TaniDescription)
        {
            if (!string.IsNullOrWhiteSpace(TaniDescription))
            {
                var agriHastaBakimPlani = _context.AgriHastaBakimPlanlari.FirstOrDefault(a => a.Id == id);
                if (agriHastaBakimPlani != null)
                {
                    var tani = new TaniOlculeri
                    {
                        Description = TaniDescription,
                        AgriHastaBakimPlaniId = agriHastaBakimPlani.Id
                    };

                    _context.TaniOlculeriList.Add(tani);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index", new { id });
        }

        [HttpPost]
        public IActionResult AmacAddDetails(int id, string AmacDescription)
        {
            if (!string.IsNullOrWhiteSpace(AmacDescription))
            {
                var agriHastaBakimPlani = _context.AgriHastaBakimPlanlari.FirstOrDefault(a => a.Id == id);
                if (agriHastaBakimPlani != null)
                {
                    var amac = new Amac
                    {
                        Description = AmacDescription,
                        AgriHastaBakimPlaniId = agriHastaBakimPlani.Id
                    };

                    _context.Amaclar.Add(amac);
                    _context.SaveChanges();
                }
            }



            return RedirectToAction("Index", new { id });
        }
        [HttpPost]
        public IActionResult DegerlendirmeAddDetails1(int id, string tarih1, string saat1, string degerlendirme1, string Not1)
        {
            try
            {
                var hasta = _context.Hastalar.Find(id);
                if (hasta == null)
                {
                    return Json(new { success = false, message = $"{id} id li Hasta bulunamadı" });
                }

                var degerlendirme = new Degerlendirme
                {
                    HastaId = id,
                    Tarih = tarih1,
                    Saat = saat1,
                    DegerlendirmeDurumu = degerlendirme1,
                    Not = Not1
                };

                _context.Degerlendirmeler.Add(degerlendirme);
                _context.SaveChanges();

                return Json(new { success = true, not = degerlendirme.Not });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult DegerlendirmeAddDetails2(int id, string tarih2, string saat2, string degerlendirme2, string Not2)
        {
            try
            {
                var hasta = _context.Hastalar.Find(id);
                if (hasta == null)
                {
                    return Json(new { success = false, message = $"{id} id li Hasta bulunamadı" });
                }

                var degerlendirme = new Degerlendirme
                {
                    HastaId = id,
                    Tarih = tarih2,
                    Saat = saat2,
                    DegerlendirmeDurumu = degerlendirme2,
                    Not = Not2
                };

                _context.Degerlendirmeler.Add(degerlendirme);
                _context.SaveChanges();

                return Json(new { success = true, not = degerlendirme.Not });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult DegerlendirmeAddDetails3(int id, string tarih3, string saat3, string degerlendirme3, string Not3)
        {

            try
            {
                var hasta = _context.Hastalar.Find(id);
                if (hasta == null)
                {
                    return Json(new { success = false, message = $"{id} id li Hasta bulunamadı" });
                }

                var degerlendirme = new Degerlendirme
                {
                    HastaId = id,
                    Tarih = tarih3,
                    Saat = saat3,
                    DegerlendirmeDurumu = degerlendirme3,
                    Not = Not3
                };

                _context.Degerlendirmeler.Add(degerlendirme);
                _context.SaveChanges();

                return Json(new { success = true, not = degerlendirme.Not });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult DegerlendirmeAddDetails4(int id, string tarih4, string saat4, string degerlendirme4, string Not4)
        {

            try
            {
                var hasta = _context.Hastalar.Find(id);
                if (hasta == null)
                {
                    return Json(new { success = false, message = $"{id} id li Hasta bulunamadı" });
                }

                var degerlendirme = new Degerlendirme
                {
                    HastaId = id,
                    Tarih = tarih4,
                    Saat = saat4,
                    DegerlendirmeDurumu = degerlendirme4,
                    Not = Not4
                };

                _context.Degerlendirmeler.Add(degerlendirme);
                _context.SaveChanges();

                return Json(new { success = true, not = degerlendirme.Not });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
        public IActionResult HastaListesi()
        {
            var hastalar = _context.Hastalar
         .Select(h => new HastaDetayDto
         {
             HastaId = h.Id,
             AgriHastaBakimPlaniId = h.AgriHastaBakimPlanlari.FirstOrDefault().Id,
             HastaAdi = h.Ad,
             HastaSoyadi = h.Soyad
         }).ToList();

            return View(hastalar);
            
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
