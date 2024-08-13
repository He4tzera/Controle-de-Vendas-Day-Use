using Controle.data;
using Controle.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Controllers
{
    public class CadastroController : Controller
    {

        readonly private ApplicationDbContext _db;

        public CadastroController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index ()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index (DayuseModel dayuse)
        {
            if (ModelState.IsValid)
            {
                _db.Dayuse.Add(dayuse);
                _db.SaveChanges();
                TempData["Mensagem de Sucesso"] = "Cadastro Realizado com Sucesso !";

                return RedirectToAction("Index");
            }
            TempData["Mensagem de Erro"] = "Aconteceu algo de errado e não foi possivel cadastrar!";
            return View();

        }
    }
}
