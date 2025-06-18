using Microsoft.AspNetCore.Mvc;
using primerEjemplo.Herramientas;
using primerEjemplo.Models;
using primerEjemplo.Models.ParaCarrito;

namespace primerEjemplo.Controllers
{
    public class CarritoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Agregar/{id}")]
        public IActionResult Agregar(string id) 
        {
            ProductoModel productoModel = new ProductoModel();
            if (ConversorSupremo.JsonToCsharp<List<Item>>(HttpContext.Session, "carrito") == null)
            {
                List<Item> carrito = new List<Item>();
                carrito.Add(new Item {Producto = productoModel.getById(id), Cantidad = 1 });
                ConversorSupremo.CsharpToJson(HttpContext.Session, carrito, "carrito");
            }
            else { 
                List<Item> carrito = ConversorSupremo.JsonToCsharp<List<Item>>(HttpContext.Session, "carrito");
                int indice = existe(id);
                if (indice != -1)
                    carrito[indice].Cantidad++;
                else
                    carrito.Add(new Item {Producto = productoModel.getById(id),Cantidad = 1});
                ConversorSupremo.CsharpToJson(HttpContext.Session, carrito, "carrito");
            }
            return RedirectToAction("Index");
        }

        [NonAction]
        public int existe(string id)
        {
            List<Item> carrito = ConversorSupremo.JsonToCsharp<List<Item>>(HttpContext.Session, "carrito");
            for (int i = 0; i < carrito.Count; i++)
                if (carrito[i].Producto.Id.Equals(id))
                    return i;
            return -1;
        }
    }
}
