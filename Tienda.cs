namespace Proyecto_Ingenierìa_de_software
{
    public class Tienda
    {
        private List<Producto> Inventario;

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
            return Inventario.FirstOrDefault(p => p.Nombre == nombre);
        }

        public bool EliminarProducto(string nombre)
        {
            var producto = BuscarProducto(nombre);
            if (producto != null)
            {
                Inventario.Remove(producto);
                return true;
            }
            return false;
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

