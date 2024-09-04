using NUnit.Framework;

namespace Proyecto_Ingenierìa_de_software
{
    [TestFixture]
    public class UnitTest1
    {
        private readonly Producto not_existingProduct = new Producto
        {
            Nombre = "Prod_NonEx",
            Categoria = "2",
            Precio = 100,
        };
        private readonly Producto product1 = new Producto
        {
            Nombre = "Prod_I",
            Categoria = "2",
            Precio = 100,
        };
        private readonly Producto product2 = new Producto
        {
            Nombre = "Prod_I",
            Categoria = "2",
            Precio = 100,
        };
        private readonly Tienda store = new Tienda
        {
            Inventario = new List<Producto>
           {
               new Producto()
               {
                   Nombre = "Prod_I",
                   Categoria = "2",
                   Precio = 100,
               },
               new Producto()
               {
                   Nombre = "Prod_I",
                   Categoria = "2",
                   Precio = 100,
               }

           }
        };
        [SetUp]
        public void SetUp()
        { }




        [Test]
        public void DeleteUnexistingProduct_ShouldThrowNotFoundException()
        {
            var tienda = new Tienda
            {
                Inventario = new List<Producto>
                {
                    product1,
                    product2
                },
            };
            Assert.Throws<Exception>(() => tienda.EliminarProducto(not_existingProduct.Nombre));
        }
        [Test]
        public void UpdatePriceToNegative_ShouldThrowException()
        {
            const string searchName = "Prod1";
            var store = new Tienda
            {
                Inventario = new List<Producto>
                {
                    product1,
                    new Producto
                    {
                        Nombre = searchName,
                    }
                }
            };
            Assert.Throws<Exception>(() => store.ActualizarPrecio(-100, searchName));
        }
    }
}