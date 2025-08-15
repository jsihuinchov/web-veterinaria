using Microsoft.AspNetCore.Mvc;
using web_veterinaria.Models;

namespace web_veterinaria.Controllers
{
    public class MascotaController : Controller
    {
        // Simulación de base de datos en memoria
        private static List<Mascota> mascotas = new List<Mascota>();

        // Mostrar lista
        public IActionResult Index()
        {
            return View(mascotas);
        }

        // GET: Formulario
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guardar nueva mascota
        [HttpPost]
        public IActionResult Create(Mascota nuevaMascota)
        {
            if (ModelState.IsValid)
            {
                nuevaMascota.Id = mascotas.Count + 1;
                mascotas.Add(nuevaMascota);
                return RedirectToAction("Index");
            }
            return View(nuevaMascota);
        }
    }
}
