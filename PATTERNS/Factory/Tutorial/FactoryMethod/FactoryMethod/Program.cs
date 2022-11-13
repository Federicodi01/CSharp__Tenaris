using System;

namespace FactoryMethod
{
    // La clase creadora declara el "Factory Method" que debe devolver un objeto de una clase de producto. Normalmente, las subclases de la creadora proporcionan la implementación de este método.
    abstract class Creator
    {
        // La creadora también puede proporcionar cierta implementación por defecto del "Factory Method".
        public abstract IProduct FactoryMethod();

        // Observa que, a pesar de su nombre, la principal responsabilidad de la Clase Creadora no es crear productos. Normalmente contiene cierta lógica de negocio que depende
        // de los objetos de producto devueltos por el "Factory Method". Las subclases pueden cambiar indirectamente esa lógica de negocio sobrescribiendo el "Factory Method" y
        // devolviendo desde él un tipo diferente de producto.
        public string SomeOperation()
        {
            // Invoca el "Factory Method" para crear un objeto de producto.
            var product = FactoryMethod();
            // Ahora utiliza el producto.
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }

    // Los creadores concretos sobrescriben el "Factory Method" para cambiar el tipo de producto resultante.
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }

    // La interfaz de producto declara las operaciones que todos los productos concretos deben implementar.
    public interface IProduct
    {
        string Operation();
    }

    // Los productos concretos proporcionan varias implementaciones de la interfaz de producto.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }

    class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        // El "Cliente Code" funciona con una instancia de un creador concreto, aunque a través de su interfaz base. Siempre y cuando el cliente siga funcionando con el
        // creador a través de la interfaz base, puedes pasarle cualquier subclase del creador.
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class, " +
                "but it still works.\n" + creator.SomeOperation());
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
