using System;
using System.Linq;

namespace LINQ_SingleOrDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            // SingleOrDefault<TSource>(IEnumerable<TSource>, Func<TSource,Boolean>)

            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            string fruitQuery = fruits.SingleOrDefault(fruit => fruit.Length > 10);

            Console.WriteLine(string.IsNullOrEmpty(fruitQuery)? "No such Fruits" : fruitQuery);

        }
    }
}
