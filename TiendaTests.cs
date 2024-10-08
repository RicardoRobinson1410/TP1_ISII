﻿using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Proyecto_Ingenierìa_de_software;

[TestFixture]
public class TiendaTests
{
    private Tienda tienda_test;

    [SetUp]
    public void SetUp() 
    {
        tienda_test = new Tienda();
        tienda_test.AgregarProducto(new Producto("Producto1", Convert.ToDecimal(100), "Categoria1"));
        tienda_test.AgregarProducto(new Producto("Producto2", Convert.ToDecimal(200), "Categoria2"));
        tienda_test.AgregarProducto(new Producto("Producto3", Convert.ToDecimal(300), "Categoria3"));
    }

    [Test]
    public void AgregarProducto_DeberiaAgregarProductoALaLista()
    {
        // Crear un mock de Producto
        var mockProducto = new Mock<Producto>("Producto4", Convert.ToDecimal(600), "Limpieza");

        // Crear una instancia de Tienda
        // var tienda = new Tienda();

        // Agregar el mock de Producto a la tienda
        tienda_test.AgregarProducto(mockProducto.Object);

        // Verificar que el producto ha sido agregado correctamente
        var producto = tienda_test.BuscarProducto("Producto4");
        ClassicAssert.AreEqual(mockProducto.Object, producto);
    }

    [Test]
    public void EliminarProducto_DeberiaEliminarProductoDeLaLista()
    {
        // Crear un mock de Producto
        var mockProducto = new Mock<Producto>("Producto4", Convert.ToDecimal(600), "Limpieza");

        // Crear una instancia de Tienda
        // var tienda = new Tienda();

        // Agregar el mock de Producto y luego eliminarlo
        tienda_test.AgregarProducto(mockProducto.Object);
        tienda_test.EliminarProducto("Producto4");

        // Verificar que el producto ha sido eliminado
        var excepcion = Assert.Throws<Exception>(() => tienda_test.BuscarProducto("Producto4"));
        ClassicAssert.AreEqual("Invalid product", excepcion.Message);
    }

    /*------TEST INTEGRADOR------*/

    [Test]
    public void Calcular_Total_Carrito_DeberiaCalcularTotalCorrecto()
    {
        tienda_test.Aplicar_descuento("Producto1", 80);
        tienda_test.Aplicar_descuento("Producto2", 60);
        var carrito = new List<string> { "Producto1", "Producto2", "Producto3" };
        var total = tienda_test.Calcular_Total_Carrito(carrito);
        //Total esperado = 80 + 120 + 300 = 500
        ClassicAssert.AreEqual(500, total);
    }

    /*
    [Test]
    public void Aplicar_descuento_DeberiaCalcularCorrectamenteElNuevoPrecio()
    {
        // Crear un mock de Producto
        var mockProducto = new Mock<Producto>();
        mockProducto.SetupProperty(p => p.Precio, 100.0m); // Establecer el precio inicial en 100

        // Crear una instancia de Tienda
        var tienda = new Tienda();

        // Agregar el mock de Producto a la tienda
        tienda.Inventario.Add(mockProducto.Object);

        // Aplicar un descuento del 10%
        tienda.Aplicar_descuento("");

        // Verificar que el precio se haya reducido correctamente
        decimal precioEsperado = 90.0m; // El precio después de aplicar el 10% de descuento
        ClassicAssert.AreEqual(precioEsperado, mockProducto.Object.Precio);
    }*/
}
