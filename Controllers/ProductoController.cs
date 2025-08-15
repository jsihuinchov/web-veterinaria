using Microsoft.AspNetCore.Mvc;
using web_veterinaria.Models;

namespace web_veterinaria.Controllers
{
    public class ProductoController : Controller
    {
        private static List<Producto> productos = new List<Producto>();

        public IActionResult Index()
        {
            return View(productos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto nuevoProducto)
        {
            if (ModelState.IsValid)
            {
                nuevoProducto.Id = productos.Count + 1;
                productos.Add(nuevoProducto);
                return RedirectToAction("Index");
            }
            return View(nuevoProducto);
        }
    }
}
