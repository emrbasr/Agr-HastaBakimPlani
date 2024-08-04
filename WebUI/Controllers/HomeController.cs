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
                .Include(a => a.Sonuclar)
                .FirstOrDefault(a => a.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            ViewBag.Girisimler = _context.Girisimler.Where(g => g.Id == id).ToList();

            return View(model);
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
