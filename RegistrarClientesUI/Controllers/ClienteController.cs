using Microsoft.AspNetCore.Mvc;
using RegistrarClientesBL;
using RegistroClientesEN;
using System.Threading.Tasks;

namespace RegistrarClientesUI.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteBL _clienteBL;

        public ClienteController(ClienteBL clienteBL)
        {
            _clienteBL = clienteBL;
        }

        // GET: ClienteController/Index
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var clientes = await _clienteBL.ObtenerClientesAsync();
            return View(clientes);
        }

        // GET: ClienteController/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var cliente = await _clienteBL.ObtenerClientePorIdAsync(id);
            if (cliente == null)
                return NotFound();
            return View(cliente);
        }

        // GET: ClienteController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Clientes cliente)
        {
            if (ModelState.IsValid)
            {
                cliente.FechaRegistro = DateTime.Now;  // Asegurarse de que se asigne la fecha de ahora
                await _clienteBL.CrearClienteAsync(cliente);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: ClienteController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var cliente = await _clienteBL.ObtenerClientePorIdAsync(id);
            if (cliente == null)
                return NotFound();
            return View(cliente);
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Clientes cliente)
        {
            if (id != cliente.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                await _clienteBL.ActualizarClienteAsync(cliente);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        // GET: ClienteController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var cliente = await _clienteBL.ObtenerClientePorIdAsync(id);
            if (cliente == null)
                return NotFound();
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _clienteBL.EliminarClienteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
