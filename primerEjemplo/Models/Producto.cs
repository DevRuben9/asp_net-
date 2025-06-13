namespace primerEjemplo.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Foto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }

        public Producto() { }
        public Producto(int Id, string Nombre, string Foto, double Precio, int Cantidad)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Foto = Foto;
            this.Precio = Precio;
            this.Cantidad = Cantidad;
        }
    }
}
