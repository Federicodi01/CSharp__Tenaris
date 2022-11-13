using System;
using System.Linq;

namespace LINQ_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1

            /*
            string[] fruits = { "apple", "banana", "mango", "orange", "passionfruit", "grape" };

            try // Contamos la cantidad de frutas que hay en el array y guardamos la cantidad en un Int 
            {
                int numberOfFruits = fruits.Count();
                Console.WriteLine($"There are {numberOfFruits} fruits in the collection.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The count is too large to store as an Int32.");
                Console.WriteLine("Try using the LongCount() method instead.");
            }
            */

            //Ejemplo 2

            Pet[] pets = { new Pet { Name="Barley", Vacunado=true },
                           new Pet { Name="Boots", Vacunado=false },
                           new Pet { Name="Whiskers", Vacunado=false } };

            try
            {
                int cantidadNoVacunados = pets.Count(p => p.Vacunado == false);
                Console.WriteLine($"Hay {cantidadNoVacunados} animales no vacunados");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The count is too large to store as an Int32.");
                Console.WriteLine("Try using the LongCount() method instead.");
            }
        }
    }
    class Pet
    {
        public string Name { get; set; }
        public bool Vacunado { get; set; }
    }
}
