using System;
using System.Linq;

namespace LINQ_Last
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 34, 65, 92, 87, 435, 3, 54, 83, 23, 87, 67, 12, 19 };
            
            // Mostramos el ultimo numero del array
            int last = numbers.Last();
            Console.WriteLine(last);

            // Mostramos el ultimo numero del array, que cumpla con la condicion indicada
            int last1 = numbers.Last(num => num > 80);
            Console.WriteLine(last1);
        }
    }
}
