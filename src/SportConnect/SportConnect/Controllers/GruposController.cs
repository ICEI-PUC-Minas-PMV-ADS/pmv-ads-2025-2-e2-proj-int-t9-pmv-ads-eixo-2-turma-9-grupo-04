using CriarGrupo.Models;
using Microsoft.AspNetCore.Authorization;         // 👈 para [Authorize]
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportConnect.Models;
using System.Security.Claims;                     // 👈 para ler o ID do usuário do cookie

namespace CriarGrupo.Controllers
{
    [Authorize] // opcional: se quiser exigir login em TODAS as actions deste controller
    public class GruposController : Controller
    {
        private readonly AppDbContext _context;

        public GruposController(AppDbContext context)
        {
            _context = context;
        }

        // helper: pega o ID (int) do usuário logado
        private int? GetCurrentUserId()
        {
            var idClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (int.TryParse(idClaim, out var id)) return id;
            return null;
        }

        [AllowAnonymous] // listar pode ficar público se quiser
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Grupos.AsNoTracking().ToListAsync();
            return View(dados);
        }

        [AllowAnonymous] // ou remova se quiser exigir login
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Grupo grupo)
        {
            if (!ModelState.IsValid) return View(grupo);

            var userId = GetCurrentUserId();
            if (userId == null) return Challenge(); // força login se não houver cookie válido

            // vincula o grupo ao criador
            grupo.UsuarioId = userId;

            _context.Grupos.Add(grupo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var grupo = await _context.Grupos.FindAsync(id);
            if (grupo == null) return NotFound();

            // só o dono pode editar
            var userId = GetCurrentUserId();
            if (userId == null) return Challenge();
            if (grupo.UsuarioId != userId) return Forbid();

            return View(grupo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Grupo grupo)
        {
            if (id != grupo.Id) return NotFound();

            var original = await _context.Grupos.FindAsync(id);
            if (original == null) return NotFound();

            // checagem de dono novamente (segurança em profundidade)
            var userId = GetCurrentUserId();
            if (userId == null) return Challenge();
            if (original.UsuarioId != userId) return Forbid();

            if (!ModelState.IsValid) return View(original);

            // atualize apenas os campos editáveis
            original.Nome = grupo.Nome;
            original.Descricao = grupo.Descricao;
            original.NumeroMaximoParticipantes = grupo.NumeroMaximoParticipantes;
            original.ListaEspera = grupo.ListaEspera;
            original.Modalidade = grupo.Modalidade;
            original.Estado = grupo.Estado;
            original.Cidade = grupo.Cidade;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous] // visualizar pode ser público
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var dados = await _context.Grupos.AsNoTracking().FirstOrDefaultAsync(g => g.Id == id);
            if (dados == null) return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var grupo = await _context.Grupos.FindAsync(id);
            if (grupo == null) return NotFound();

            var userId = GetCurrentUserId();
            if (userId == null) return Challenge();
            if (grupo.UsuarioId != userId) return Forbid();

            return View(grupo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null) return NotFound();

            var grupo = await _context.Grupos.FindAsync(id);
            if (grupo == null) return NotFound();

            var userId = GetCurrentUserId();
            if (userId == null) return Challenge();
            if (grupo.UsuarioId != userId) return Forbid();

            _context.Grupos.Remove(grupo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
