using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportConnect.Models;
using System.Text.Json;

namespace SportConnect.Controllers
{
    public class EventosController : Controller
    {
        private readonly AppDbContext _context;
        
        public EventosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var dados = await _context.Eventos.ToListAsync();

            return View("Eventos", dados);
        }
        public IActionResult Eventos()
        {
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Evento evento)
        {
            if (ModelState.IsValid)
            {
                _context.Eventos.Add(evento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(evento);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.Eventos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Evento evento)
        {
            if (id != evento.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Eventos.Update(evento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Eventos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Eventos.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Eventos.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Eventos.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        private async Task<(double lat, double lng)> GetCoordinatesFromOpenCage(string address)
        {
            string apiKey = "d22bff7a5feb475e9bc22789f51e6a89";
            string url = $"https://api.opencagedata.com/geocode/v1/json?q={Uri.EscapeDataString(address)}&key={apiKey}&language=pt&countrycode=br&limit=1";

            using var client = new HttpClient();
            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return (0, 0);

            var json = await response.Content.ReadAsStringAsync();
            using var doc = JsonDocument.Parse(json);

            var results = doc.RootElement.GetProperty("results");
            if (results.GetArrayLength() == 0)
                return (0, 0);

            var geometry = results[0].GetProperty("geometry");
            double lat = geometry.GetProperty("lat").GetDouble();
            double lng = geometry.GetProperty("lng").GetDouble();

            return (lat, lng);
        }
    }
}
