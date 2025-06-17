using Microsoft.AspNetCore.Mvc;

namespace primerEjemplo.Controllers
{
    [Route("param")]
    public class ParametrosController : Controller
    {
        [Route("Inicio")]
        [Route("Home")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("eje2/{name}")]
        public IActionResult ejemplo2(string name)
        {
            ViewBag.name = name;
            return View("pasandoParametros");
        }

        [Route("eje3/{name}/edad/{edad}")]
        public IActionResult ejemplo3(string name,int edad )
        {
            ViewBag.name = name;
            ViewBag.edad = edad;
            return View("pasandoParametros");
        }
        [Route("eje4")]
        public IActionResult ejemplo4([FromQuery(Name = "name")] string name)
        {
            ViewBag.name = name;
            return View("pasandoParametros");
        }

        [Route("eje5")]
        public IActionResult ejemplo5([FromQuery(Name = "name")]  string name, [FromQuery(Name = "edad")] int edad)
        {
            ViewBag.name = name;
            ViewBag.edad = edad;
            return View("pasandoParametros");
        }

    }
}
