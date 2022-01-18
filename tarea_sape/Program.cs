using System;
using System.Collections.Generic;
using System.Linq;

namespace tarea_sape
{
    class Program
    {
        static void Main(string[] args)
        {
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
            };

            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla los nombres de los estudiantes
            Console.WriteLine("\nDado la siguiente coleccion de datos, utilizando expresiones Lambda:");
            Console.WriteLine("\n1. Muestre por pantalla los nombres de los estudiantes");
            details.ForEach(estudiante => Console.WriteLine(estudiante.Nombre));


            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            Console.WriteLine("\n2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor");
            var prom = details.OrderByDescending(x => x.Promedio).ToList();
            prom.ForEach(estudiante => Console.WriteLine(estudiante.Nombre + " " + estudiante.Apellido + " " + estudiante.Promedio));


            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            Console.WriteLine("\n3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente");
            var apelli2 = details.OrderBy(x => x.Apellido).ToList();
            apelli2.ForEach(estudiante => Console.WriteLine(estudiante.Apellido));


            //4. Muestre por pantalla los datos del estudiante mas joven
            Console.WriteLine("\n4. Muestre por pantalla los datos del estudiante mas joven");
            var masJoven = (from x in details select x.Edad).Min();
            var sape = (from x in details where x.Edad == masJoven select x).ToList();
            sape.ForEach(estudiante => Console.WriteLine(estudiante.Id+" "+estudiante.Nombre + " " + estudiante.Apellido + " " + estudiante.Promedio + " " + estudiante.Edad));

            

            Console.WriteLine("\n-----------------------------------------------------------------------------------------------------------------");
            
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };

            
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            Console.WriteLine("\nDado la siguiente coleccion de datos, utilizando expresiones Lambda:");
            Console.WriteLine("\n1. Muestre por pantalla el cuadrado de los números");
            var cuadra2 = list.Select(x => x * x).ToList();
            cuadra2.ForEach(num => Console.WriteLine(num));
            


            //2. Muestre por pantalla los números pares
            Console.WriteLine("\n2. Muestre por pantalla los números pares");
            //var sape = from n in list where n % 2 == 0 select n;
            var pares = list.FindAll(x => x % 2 == 0);
            pares.ForEach(num => Console.WriteLine(num));


            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            Console.WriteLine("\n3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares");
            var impares = (from n in list where (n % 2 != 0) select n*5).ToList();
            impares.ForEach(num => Console.WriteLine(num));
            

        }
    }
}
