using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SportConnect.Models;
using System.Security.Claims;

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
            if (ModelState.IsValid)
            {
                if(usuario == null)
                {
                    return NotFound();
                }

                var dados = _context.Usuarios.FirstOrDefault(c => c.Email == usuario.Email || c.Cpf == usuario.Cpf);

                if(dados == null)
                {
                    usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                    _context.Usuarios.Add(usuario);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Email e/ou CPF já estão cadastrados";
                }
            }

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Usuario usuario)
        {
            if (usuario == null)
            {
                return NotFound();
            }

            var dados = _context.Usuarios.FirstOrDefault(c => c.Email == usuario.Email);

            if(dados == null)
            {
                return NotFound();
            }

            var senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaOk)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, dados.Nome),
                        new Claim(ClaimTypes.NameIdentifier, dados.Id.ToString()),
                    };

                var usuarioIdentify = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentify);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);
                
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Email e/ou senha inválidos!";
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}