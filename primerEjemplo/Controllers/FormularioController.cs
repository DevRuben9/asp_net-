using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using primerEjemplo.Models;

namespace primerEjemplo.Controllers
{
    public class FormularioController : Controller
    {
        public IActionResult Index()
        {
            CuentaParaView cuentaParaView = new CuentaParaView();
            cuentaParaView.Cuenta = new Cuenta() {
                Id = 123,
                Disponible = true,
                Genero = "M"
            };

            cuentaParaView.Lenguajes = new List<Lenguaje>()
            {
                new Lenguaje() { Id = "len01", Nombre = "C#", Tickedo=false },
                new Lenguaje() { Id = "len02", Nombre = "Java", Tickedo=false },
                new Lenguaje() { Id = "len03", Nombre = "Python", Tickedo=false },
                new Lenguaje() { Id = "len04", Nombre = "PHP", Tickedo=false },
                new Lenguaje() { Id = "len05", Nombre = "JavaScript", Tickedo=false },
                new Lenguaje() { Id = "len06", Nombre = "Ruby", Tickedo=false },
                new Lenguaje() { Id = "len07", Nombre = "Typescript", Tickedo=false },
                new Lenguaje() { Id = "len08", Nombre = "Swift", Tickedo=false },
            };

            var cargos = new List<Cargo>()
            {
                new Cargo() { Id = "c01", Nombre = "Desarrollador" },
                new Cargo() { Id = "c02", Nombre = "Tester" },
                new Cargo() { Id = "c03", Nombre = "Administrador" },
                new Cargo() { Id = "c04", Nombre = "Gerente" }
            };

            cuentaParaView.Cargos = new SelectList(cargos, "Id", "Nombre", "c03");

            return View("Index", cuentaParaView);
        }
        [HttpPost] //action verbs (solo es alcanzable desde la peticion post)
        public IActionResult Registrar(CuentaParaView cuentaParaView, List<Lenguaje> lenguajes) {
            cuentaParaView.Cuenta.Lenguajes = new List<string>();
            foreach (var lenguaje in lenguajes)
                if (lenguaje.Tickedo)
                    cuentaParaView.Cuenta.Lenguajes.Add(lenguaje.Id);
            ViewBag.Cuenta = cuentaParaView.Cuenta;
            return View("Registrado");
        }
    }
}
