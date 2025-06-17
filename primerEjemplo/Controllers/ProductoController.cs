using Microsoft.AspNetCore.Mvc;
using primerEjemplo.Models;

namespace primerEjemplo.Controllers
{
    [Route("producto")]
    public class ProductoController : Controller
    {
        private IWebHostEnvironment webHostEnvironment;

        public ProductoController(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }
        [Route("")] //http:/localhost:5000/productos
        [Route("index")] //http:/localhost:5000/productos
        public IActionResult Index()
        {
            return View("Index", new Producto());
        }

        [HttpPost]
        public IActionResult Registrar(Producto producto, IFormFile imagen)
        {
            if (imagen != null && imagen.Length > 0)
            {
                String ruta = Path.Combine(webHostEnvironment.WebRootPath, "img", imagen.FileName);
                using (var stream = new FileStream(ruta, FileMode.Create))
                {
                    imagen.CopyToAsync(stream);
                }
                producto.Foto = imagen.FileName;
                ViewBag.prod = producto;
            }
            else {
                return Content("Imagen Necesario, Vuelva a intentarlo...");
            }
            return View("Registrado");
        }
    }
}
