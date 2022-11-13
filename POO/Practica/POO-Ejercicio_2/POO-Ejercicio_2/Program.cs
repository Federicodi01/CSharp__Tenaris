using System;

namespace POO_Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var libro1 = new Libro();
            libro1.Autor = "Federico Di Napoli";
            libro1.Titulo = "Un libro diferente";
            libro1.Ubicacion = "Campana";
            Console.WriteLine($"Autor: {libro1.Autor} \nTitutlo: {libro1.Titulo} \nUbicación: {libro1.Ubicacion}");
        }
    }
    class Libro
    {
        private string autor;
        private string titulo;
        private string ubicacion;

        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
    }
}
