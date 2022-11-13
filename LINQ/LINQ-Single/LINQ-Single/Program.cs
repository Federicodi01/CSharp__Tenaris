using System;
using System.Linq;

namespace LINQ_Single
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            // (L1) Declaramos fruit1, definimos que, en caso de solo ser una, sea una fruta con un nombre con mas de 10 caracteres. (L2) Mostramos fruit1
            string fruit1 = fruits.Single(fruit => fruit.Length > 10);
            Console.WriteLine(fruit1 + "\n");

            // (L1) Definimos fruit2 como string null. (L try catch) intentamos encontrar una fruta con un nombre con mas de 10 caracteres, si no existe lanzamos un error. (L3) mostramos el resultado
            string fruit2 = null;
            try
            {
                fruit2 = fruits.Single(fruit => fruit.Length > 15);
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine(@"The collection does not contain exactly one element whose length is greater than 15.");
            }

            Console.WriteLine(fruit2);
        }
    }
}
