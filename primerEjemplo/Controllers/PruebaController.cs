using Microsoft.AspNetCore.Mvc;
using primerEjemplo.Models;

namespace primerEjemplo.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PasandoDatos()
        {   
            ViewBag.edad = 25;
            ViewBag.nombre = "Juan Perez";
            ViewBag.casado = true;
            ViewBag.peso = 75.5;
            ViewBag.fechaNacimiento = new DateTime(1998, 5, 15);
            return View();
        }

        public IActionResult PasandoObjetos() 
        {
            Producto producto = new Producto()
            {
                Id = 1,
                Nombre = "Queso",
                Foto = "queso.jpg",
                Precio = 15.5,
                Cantidad = 10
            };
            ViewBag.producto = producto;
            return View("PasandoDatos");
        }

        public IActionResult PasandoListasObjetos()
        {
            List<Producto> productos = new List<Producto>
            {
                new Producto(1, "Queso", "queso.jpg", 15.5, 10),
                new Producto(2, "Manzana", "manzana.jpg", 5.0, 20),
                new Producto(3, "Leche", "leche.jpg", 12.0, 15)
            };
            ViewBag.productos = productos;
            return View("PasandoDatos");
        }
    }
}
