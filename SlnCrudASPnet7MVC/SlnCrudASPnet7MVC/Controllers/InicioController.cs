using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SlnCrudASPnet7MVC.Datos;
using SlnCrudASPnet7MVC.Models;
using System.Diagnostics;

namespace SlnCrudASPnet7MVC.Controllers
{
    public class InicioController : Controller
    {
        // private readonly ILogger<InicioController> _logger;
        private readonly ApplicationDbContext _contexto; 

        public InicioController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
            //_logger = logger;
        }
        [HttpGet]
        public IActionResult Crear()
        {
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult>Crear(Contacto contacto)
        {
            if(ModelState.IsValid)
            {
                _contexto.Contacto.Add(contacto);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();  
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Contacto.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}