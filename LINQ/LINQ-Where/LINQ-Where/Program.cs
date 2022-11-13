using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Where
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ejemplo 1

            List<string> fruits = new List<string> { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };

            IEnumerable<string> query = fruits.Where(fruit => fruit.Length < 6);
            foreach (string fruit in query)
            {
                Console.WriteLine(fruit);
            }

            // Ejemplo 2
            int[] numbers = { 0, 30, 20, 15, 90, 85, 40, 75 };

            IEnumerable<int> query1 = numbers.Where((number, index) => number <= index * 10);

            foreach (int number in query1)
            {
                Console.WriteLine(number);
            }
        }
    }
}
