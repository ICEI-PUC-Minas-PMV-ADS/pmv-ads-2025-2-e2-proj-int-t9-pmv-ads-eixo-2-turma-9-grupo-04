using Microsoft.AspNetCore.Mvc;
using SportConnect.Models;

namespace SportConnect.Controllers
{
    public class UsuariosController : Controller
    {
        public readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Usuario usuario)
        {
            return View();
        }
    }
}
