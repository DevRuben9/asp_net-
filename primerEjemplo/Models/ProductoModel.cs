using carri = primerEjemplo.Models.ParaCarrito;

namespace primerEjemplo.Models
{
    public class ProductoModel
    {
        private List<carri::Producto> product;

        public ProductoModel()
        {
            product = new List<carri::Producto>()
            {
                new carri::Producto{
                    Id = "prod01",
                    Nombre = "Coca Cola",
                    Precio = 1.50,
                    Foto = "coca-cola.jpg",
                },
                new carri.Producto
                {
                    Id = "prod02",
                    Nombre = "Pepsi",
                    Precio = 1.50,
                    Foto = "pepsi.jpg",
                },
                new carri.Producto
                {
                    Id = "prod03",
                    Nombre = "Sprite",
                    Precio = 1.50,
                    Foto = "sprite.jpg",
                },
                new carri.Producto
                {
                    Id = "prod04",
                    Nombre = "Fanta",
                    Precio = 1.50,
                    Foto = "fanta.jpg",
                },
            };
        }

        public List<carri::Producto> getAll()
        {
            return product;
        }

        public carri::Producto getById(string id)
        {
            return product.Single(p => p.Id.Equals(id));
        }
    }
}
