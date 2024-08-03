using DataAccess.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebUI.Controllers
{
    public class AgriHastaBakimPlaniController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AgriHastaBakimPlaniController(ApplicationDbContext context)
        {
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

            return View(model);
        }
    }
}
