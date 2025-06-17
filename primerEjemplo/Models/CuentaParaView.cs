using Microsoft.AspNetCore.Mvc.Rendering;

namespace primerEjemplo.Models
{
    public class CuentaParaView
    {
        public Cuenta Cuenta { get; set; }
        public List<Lenguaje> Lenguajes { get; set; } //len01, len02, etc.
        public SelectList Cargos { get; set; } //c01, c02, //Gerente, Administrativo, Programador


    }
}
