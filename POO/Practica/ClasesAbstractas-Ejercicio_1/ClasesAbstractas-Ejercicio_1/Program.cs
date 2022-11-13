using System;
using System.Collections.Generic;

// Ejercicio: En una aplicación de consola, realiza una clase abstracta llamada Producto, en su constructor debe recibir el nombre, precio de compra y precio de venta,
// con un método para imprimir la información del producto. Crear 2 o más clases que hereden de Producto, en su constructor debe recibir los mismo parámetros que la clase Producto.
// Finalmente en el program instanciar sus Productos, e imprimir por pantalla sus datos utilizando el método anteriormente implementado.

namespace ClasesAbstractas_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var alimento1 = new Alimento("Carne", 200, 1000);
            var alimento2 = new Alimento("Pollo", 150, 750);
            var alimento3 = new Alimento("Fideos", 50, 250);

            var limpieza1 = new Alimento("Cif", 50, 250);
            var limpieza2 = new Alimento("Blem", 20, 100);
            var limpieza3 = new Alimento("Magistral", 70, 350);

            var listaProductos = new List<Producto>() { alimento1, alimento2, alimento3, limpieza1, limpieza2, limpieza3 };

            foreach (Producto producto in listaProductos) Console.WriteLine(producto.ToString());
        }
    }
    public abstract class Producto
    {
        private string nombre;
        private int precioCompra;
        private int precioVenta;

        public Producto(string nombre, int precioCompra, int precioVenta)
        {
            this.nombre = nombre;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre} \nPrecio de Compra: ${precioCompra} \nPrecio de Venta: ${precioVenta}\n"; 
        }
    }
    public class Alimento : Producto
    {
        private string nombre;
        private int precioCompra;
        private int precioVenta;

        public Alimento(string nombre, int precioCompra, int precioVenta) : base(nombre, precioCompra, precioVenta)
        {
            this.nombre = nombre;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
        }
    }
    public class Limpieza : Producto
    {
        private string nombre;
        private int precioCompra;
        private int precioVenta;

        public Limpieza(string nombre, int precioCompra, int precioVenta) : base(nombre, precioCompra, precioVenta)
        {
            this.nombre = nombre;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
        }
    }
}
