using Microsoft.AspNetCore.Routing.Constraints;

namespace Proyecto_Ingenierìa_de_software
{
    public class Tienda
    {
        public List<Producto> Inventario;

        public Tienda()
        {
            Inventario = new List<Producto>();
        }
        public Tienda(List<Producto> listaProd)
        {
            Inventario = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Inventario.Add(producto);
        }

        public Producto BuscarProducto(string nombre)
        {
            var product = Inventario.FirstOrDefault(p => p.Nombre == nombre);
            if (product == null) throw new Exception("Invalid product");
            return product;
        }

        public bool EliminarProducto(string nombre)
        {
            var producto = BuscarProducto(nombre);
            if (producto == null) throw new Exception("Invalid product");
            Inventario.Remove(producto);
            return true;
        }

        public bool ActualizarPrecio(decimal price, string nombre)
        {
            if (price < 0) throw new Exception("Negative price");
            var product = this.BuscarProducto(nombre);
            product.Precio = price;
            return true;
        }

        public List<Producto> GetInventario()
        {
            return Inventario;
        }

        public int CantProductos()
        {
            return Inventario.Count();
        }
    }
}

