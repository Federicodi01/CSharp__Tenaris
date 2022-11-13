using System;

//Ejercicio propuesto 6.2.1: Crea una clase llamada Persona, en el fichero "persona.cs". Esta clase deberá tener un atributo "nombre", de tipo string.
//También deberá tener un método "SetNombre", de tipo void y con un parámetro string, que permita cambiar el valor del nombre.
//Finalmente, también tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido de su nombre. Crea también una clase llamada PruebaPersona.
//Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Persona, les asignará un nombre a cada uno y les pedirá que saluden.

namespace POO_Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var perso = new PruebaPersona();
        }
    }
    class Persona
    {
        private string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}.");
        }
    }

    class PruebaPersona
    {
        Persona persona1, persona2;
        public PruebaPersona()
        {
            persona1 = new Persona();
            persona1.SetNombre("Marcos");
            persona2 = new Persona();
            persona2.SetNombre("Federico");
            persona1.Saludar();
            persona2.Saludar();
        }
    }
}
