namespace primerEjemplo.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Descripcion { get; set; }
        public bool Disponible { get; set; }
        public List<string> Lenguajes { get; set; } // C#, Java, Python, PHP, etc.
        public string Genero { get; set; } // M,F
        public string Cargo{ get; set; } // c01, c02
    }
}
