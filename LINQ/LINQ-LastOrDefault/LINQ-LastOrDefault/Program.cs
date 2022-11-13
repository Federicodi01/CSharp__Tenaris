using System;
using System.Linq;

namespace LINQ_LastOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            // LastOrDefault<TSource>(IEnumerable<TSource>)

            string[] fruits = {"apple", "banana", "mango", "orange", "passionfruit", "grape"};

            // (L1) Creamos la consulta. (L2) Luego, si la consulta no trae nada, devolvemos "No hay frutas", y si encuentra, devolvemos el valor solicitado
            /*
            string last = fruits.LastOrDefault();
            Console.WriteLine(String.IsNullOrEmpty(last) ? "No hay frutas" : last);
            */

            // (L1) Creamo la consulta, si el array de frutas esta vacio, devolvemos "No hay frutas", si hay valores, devuelve el ultimo. (L2) Luego, escribimos lo que nos trae la consulta.
            /*
            string last2 = fruits.DefaultIfEmpty("No hay frutas").Last();
            Console.WriteLine($"La ultima fruta es: {last2}");
            */


            // LastOrDefault<TSource>(IEnumerable<TSource>, Func<TSource, Boolean>)

            double[] numbers = { 49.6, 52.3, 51.0, 49.4, 50.2, 48.3 };

            double last50 = numbers.LastOrDefault(n => Math.Round(n) == 50.0);
            Console.WriteLine("The last number that rounds to 50 is {0}.", last50);

            double last40 = numbers.LastOrDefault(n => Math.Round(n) == 40.0);
            Console.WriteLine("The last number that rounds to 40 is {0}.", last40 == 0.0 ? "<DOES NOT EXIST>" : last40.ToString());
        }
    }
}
