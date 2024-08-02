using Controle.data;
using Controle.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Controllers
{
    public class EditarController : Controller
    {
        readonly private ApplicationDbContext _db;

        public EditarController(ApplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public IActionResult Index(int?Id)
        {
            if (Id == null || Id == 0) 
            {
                return NotFound();
            }
           
            DayuseModel dayuse = _db.Dayuse.FirstOrDefault(x => x.Id ==Id) ;

            if (dayuse == null) 
            {
                return NotFound();
            }

            return View(dayuse);
        }

        [HttpPost]
        public IActionResult Index(DayuseModel dayuse)
        {
            if (ModelState.IsValid)
            {
                _db.Dayuse.Update(dayuse);
                _db.SaveChanges();

                return RedirectToAction("Index", "Listagem");
            }
            return View(dayuse);

        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var dayuse = _db.Dayuse.FirstOrDefault(x => x.Id == id);

            if (dayuse == null)
            {
                return NotFound();
            }

            _db.Dayuse.Remove(dayuse);
            _db.SaveChanges();

            return RedirectToAction("Index", "Listagem");
        }
    }
}
