using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1- Cantidad de Alumnos aprobados
// 2- Alumnos aprobados del profesor 1
// 3- Alumnos Agrupados por nombre
// 4- Ultimo alumno de la lista
// 5- Ultimo alumno con promedio 10
// 6- Unico alumno del profesor 3
// 7- Unico alumno con promedio 10
// 8- Alumno cuyo nombre empiece con "C", tenga mas de 30 años y promedio mayor a 6

namespace Practica_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Profesor> listaProfesores = new List<Profesor>()
            {
                new Profesor {Codigo=1, Nombre="Hedlund, Magnus"},
                new Profesor {Codigo=2, Nombre="Adams, Terry"},
                new Profesor {Codigo=3, Nombre="Weiss, Charlotte"}
            };

            List<Alumno> listaAlumnos = new List<Alumno>()
            {
                new Alumno {Nombre="Svetlana", Edad=20, Notas= new List<int> {9, 9, 8}, CodigoProfe=1},
                new Alumno {Nombre="Claire", Edad=22, Notas= new List<int> {7, 8, 8}, CodigoProfe=1},
                new Alumno {Nombre="Sven", Edad=42, Notas= new List<int> {5, 5, 10}, CodigoProfe=1},
                new Alumno {Nombre="Cesar", Edad=44, Notas= new List<int> {9, 9, 6}, CodigoProfe=2},
                new Alumno {Nombre="Debra", Edad=66, Notas= new List<int> {9, 2, 8}, CodigoProfe=1},
                new Alumno {Nombre="Carlos", Edad=36, Notas= new List<int> {8, 4, 8}, CodigoProfe=2},
                new Alumno {Nombre="Hanying", Edad=19, Notas= new List<int> {2, 7, 9}, CodigoProfe=1},
                new Alumno {Nombre="Hugo", Edad=47, Notas= new List<int> {4, 5, 4}, CodigoProfe=2},
                new Alumno {Nombre="Lance", Edad=13, Notas= new List<int> {6, 7, 6}, CodigoProfe=1},
                new Alumno {Nombre="Terry", Edad=9, Notas= new List<int> {10, 7, 9}, CodigoProfe=2},
                new Alumno {Nombre="Eugene", Edad=33, Notas= new List<int> {1, 8, 1}, CodigoProfe=1},
                new Alumno {Nombre="Michael", Edad=37, Notas= new List<int> {3, 1, 6}, CodigoProfe=3}
            };

            // 1- Cantidad de Alumnos aprobados
            /*
            // Solucion 1: 
            var alumnosQuery =
                from alumnos in listaAlumnos
                select alumnos;
            Console.WriteLine($"Hay {alumnosQuery.Count()} alumnos registrados");
            Console.WriteLine();
            Console.ReadKey();

            // Solucion 2: 
            Console.WriteLine($"Hay {listaAlumnos.Count()} alumnos registrados");
            Console.ReadKey();
            */

            // 2- Alumnos aprobados del profesor 1
            /*
            // Solucion 1: 
            var alumnosQuery =
                from alumnos in listaAlumnos
                where alumnos.CodigoProfe == 1 && alumnos.Promedio >= 7
                select alumnos;
            Console.WriteLine($"Hay {alumnosQuery.Count()} alumnos del profesor '1' aprobados\n");
            foreach (var a in alumnosQuery) Console.WriteLine(a);
            Console.ReadKey();

            // Solucion 2: 
            int aprobadosProfe1 = listaAlumnos.Count(a => a.CodigoProfe == 1 && a.Promedio >= 7);
            Console.WriteLine($"Hay {aprobadosProfe1} alumnos del profesor '1' aprobados:\n");
            foreach (Alumno a in listaAlumnos)
            {
                if(a.CodigoProfe == 1 && a.Promedio >= 7)
                {
                    Console.WriteLine(a);
                }
            }
            Console.ReadKey();
            */

            // 3- Alumnos Agrupados por nombre
            /*
            // Solucion 1: 
            var query = listaAlumnos.GroupBy(
                alumno => alumno.Nombre,
                alumno => alumno.CodigoProfe,
                (Nombre, Profe) => new
                {
                    alumno = Nombre,
                    profe = Profe
                });
            foreach(var result in query)
            {
                Console.WriteLine($"Alumno: {result.alumno} \nProfesor: {result.profe}");
            }
            Console.ReadKey();
            */

            // 4- Ultimo alumno de la lista
            /*
            // Solucion 1: 
            var ultimoAlumno1 =
                from alumnos in listaAlumnos
                select alumnos;
            Console.WriteLine(ultimoAlumno1.Last());
            Console.ReadKey();

            // Solucion 2: 
            var ultimoAlumno2 = listaAlumnos.Last();
            Console.WriteLine(ultimoAlumno2);
            Console.ReadKey();

            // Solucion 3: 
            Console.WriteLine(listaAlumnos.Last());
            Console.ReadKey();
            */

            // 5- Ultimo alumno con promedio 10

            // Solucion 1:
            var alumno =
                from alumnos in listaAlumnos
                where alumnos.Promedio==10
                select alumnos;

            if (alumno.Count() == 0) Console.WriteLine("Ningun alumno tiene promedio 10");
            else Console.WriteLine(alumno.LastOrDefault());
            Console.WriteLine();

            // Solucion 2: 
            if (listaAlumnos)

            // 6- Unico alumno del profesor 3
            // 7- Unico alumno con promedio 10
            // 8- Alumno cuyo nombre empiece con "C", tenga mas de 30 años y promedio mayor a 6
            /**/
        }
    }
    class Alumno
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int CodigoProfe { get; set; }

        public List<int> Notas;

        public double Promedio { get => Math.Truncate(Notas.Average() * 10) / 10; set => Notas.Average(); }

        public override string ToString()
        {
            return $"Alumno: {Nombre} \nEdad: {Edad} \nPromedio: {Promedio} \n";
        }
    }
    class Profesor
    {
        private int codigo;
        private string nombre;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
