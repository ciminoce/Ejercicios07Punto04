using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Ejercicios07Punto04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres=new string[10];
            nombres[0] = "Anne";
            nombres[1] = "Joseph";
            nombres[2] = "John";
            nombres[3] = "George";
            nombres[4] = "Jonathan";
            nombres[5] = "Angelina";
            nombres[6] = "Mary Anne";
            nombres[7] = "Richard";
            nombres[8] = "Christopher";
            nombres[9] = "Gandalf";

            /* listar un vector sin efectuar operación sobre los elementos
             podemos usar un for-each
             */
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"{nombre}");
            }
            ///* Suponer que quiero anteponer en el nombre alumno
            // */
            //for (int i = 0; i < nombres.Length; i++)
            //{
            //    nombres[i] = $"Pupil: {nombres[i]}";
            //}
            Console.WriteLine();
            Console.WriteLine("Nombres con cantidades de caracteres");

            foreach (var nombre in nombres)
            {
                Console.WriteLine($"{nombre} - {nombre.Length}");
            }
            /*Mostra los elementos cuyos nombres comienzan con C
             */
            Console.WriteLine();
            Console.WriteLine("Nombre que comienzan con C");
            foreach (var nombre in nombres)
            {
                if (nombre.StartsWith("C"))
                {
                    Console.WriteLine($"{nombre}");
                } 
            }
            Console.WriteLine();
            Console.WriteLine("Nombre que comienzan con C (Con Linq)");

            /*Utilizando Linq*/
            var nombresConC = nombres.Where(n => n.StartsWith("C"));
            foreach (var nombre in nombresConC)
            {
                Console.WriteLine(nombre);
            }

            /*Listar los elementos que contienen una C" */
            Console.WriteLine();
            Console.WriteLine("Nombre que contienen una C (Con Linq)");

            /*Utilizando Linq*/
            var nombresQueContienenC = nombres.Where(n => n.Contains("C") || n.Contains("c"));
            foreach (var nombre in nombresQueContienenC)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine();
            Console.WriteLine("Nombre con su cantidad de Vocales");
            foreach (var nombre in nombres)
            {
                var cantidadVocales = CantidadVocales(nombre);
                var cantidadCaracteres = nombre.Length;
                var cantidadConsonantes = cantidadCaracteres - cantidadVocales;
                Console.WriteLine($"{nombre} -{cantidadCaracteres} - {cantidadVocales} - {cantidadConsonantes}");
            }
            Console.WriteLine();
            Console.WriteLine("Reemplazar a o A por X");
            for (int i = 0; i < nombres.Length; i++)
            {
                nombres[i] =ReemplazarAxX(nombres[i]);
            }

            foreach (var nombre in nombres)
            {
                Console.WriteLine($"{nombre}");
            }

        }

        private static string ReemplazarAxX(string nombre)
        {

            var reemplazo=nombre.Replace('a', 'X');
            reemplazo = reemplazo.Replace('A', 'x');
            return reemplazo;
        }

        private static int CantidadVocales(string nombre)
        {
            var cantidadVocales = 0;
            var caracteres = nombre.ToCharArray();//Devuelve un array con las letras de cada nombre en cada posicion
            var vocales = "aeiouAEIOU";
            foreach (var caracter in caracteres)
            {
                if (vocales.Contains(caracter))
                {
                    cantidadVocales++;
                }
            }

            return cantidadVocales;
        }

    }
}
