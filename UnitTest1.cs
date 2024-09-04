using NUnit.Framework;

namespace Proyecto_Ingenierìa_de_software
{
    public class UnitTest1
    {
        private readonly Tienda _tiendaPruebas;
        private readonly Producto? prodPruebas;

        public UnitTest1(Tienda tiendaPruebas)
        {
            tiendaPruebas = new Tienda();
        }

        [Test]
        public void AgregarProducto_WhenProductoIsNull_ShouldReturnException()
        {
            //ARRAY
            prodPruebas = null;
        }

    }
}