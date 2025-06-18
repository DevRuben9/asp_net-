using Microsoft.AspNetCore.Mvc;
using primerEjemplo.Models;
using static System.Net.Mime.MediaTypeNames;

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
        public IActionResult Registrar(Producto producto, IFormFile[] imagenes)
        {
            if (imagenes != null && imagenes.Length > 0)
            {
                foreach (var imagen in imagenes)
                {
                    if (imagen.Length > 0)
                    {
                        var ruta = Path.Combine(webHostEnvironment.WebRootPath, "img", imagen.FileName);
                        using (var stream = new FileStream(ruta, FileMode.Create))
                        {
                            imagen.CopyTo(stream);
                        }
                        
                    }
                }
                producto.Foto = imagenes[0].FileName;
                ViewBag.prod = producto;
                ViewBag.imagenes = imagenes;
            }
            else {
                return Content("Imagen Necesario, Vuelva a intentarlo...");
            }
            return View("Registrado");
        }
    }
    
}
