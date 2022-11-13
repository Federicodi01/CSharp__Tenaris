using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // La clase Base de datos define el método `obtenerInstancia` que permite a los clientes acceder a la misma instancia de una conexión de la base de datos a través del programa.
    public sealed class Singleton
    {
        // El constructor del singleton siempre debe ser privado para evitar llamadas de construcción directas con el operador `new`.
        private Singleton() 
        {
            // Algún código de inicialización, como la propia conexión al servidor de una base de datos...
        }

        // El campo para almacenar la instancia singleton debe declararse estático.
        private static Singleton _instance;

        // El método estático que controla el acceso a la instancia singleton.
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        // Por último, cualquier singleton debe definir cierta lógica de negocio que pueda ejecutarse en su instancia. 
        public void someBusinessLogic()
        {
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // El codigo del cliente.
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
            // La variable `s1` contendrá el mismo objeto que la variable `s2`.
        }
    }
}
