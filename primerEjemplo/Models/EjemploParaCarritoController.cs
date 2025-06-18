using Microsoft.AspNetCore.Mvc;

namespace primerEjemplo.Models
{
    [Route("minimarket")]
    public class EjemploParaCarritoController : Controller
    {
        [Route("index")]
        [Route("")]
        public IActionResult Index()
        {
            ProductoModel prodModel = new ProductoModel();
            ViewBag.productos = prodModel.getAll();
            return View();
        }
    }
}
