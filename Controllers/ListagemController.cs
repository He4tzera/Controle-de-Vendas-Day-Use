using Controle.data;
using Controle.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Controllers
{
    public class ListagemController : Controller
    {
        readonly private ApplicationDbContext _db;
        public ListagemController(ApplicationDbContext db)
        {
            _db = db;
            
        }
        public IActionResult Index()
        {
            IEnumerable<DayuseModel>dayuse = _db.Dayuse;

            return View(dayuse);
        }
    }
}
