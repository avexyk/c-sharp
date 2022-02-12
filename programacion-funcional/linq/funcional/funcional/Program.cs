using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcional
{
    class Program
    {
        static void Main(string[] args)
        {
            var calificaciones = new List<int> { 10, 10, 5, 3, 7, 8, 9, 9, 10};
            var numeros = new List<int> { 2, 5, 8, 10, 5, 9 };
            var lista = new List<int> { 5, 6, 7, 8, 8, 10 };
            var desordenados = new List<int> { 3, 4, 5, 8, 9, 10 };
            // Ejercicio #1 Obtener las calificaciones mayores a 8
            // Ejercicio #2 Obtener la cantidad de calificaciones mayores a 8

            // Imperativo
            int contador = 0;
            foreach(var calificacion in calificaciones)
            {
                if(calificacion > 8)
                {
                    // Console.WriteLine(calificacion);
                    contador++;
                }
            }
            Console.WriteLine(contador);

            // Declarativo (Qué se debe hacer pero no como)
            var result = calificaciones.Where( calificacion => calificacion > 8 );
            //foreach (var calificacion in result)
            //    Console.WriteLine(calificacion);
            Console.WriteLine(result.Count());

            // Ejercicio #3 Obtener el cuadrado de la lista de números
            
            // Imperativo
            foreach(var numero in numeros)
            {
                Console.WriteLine(numero * numero);
            }

            // Declarativo
            var resultado = numeros.Select(numero => numero * numero);
            foreach(var numero in resultado)
            {
                Console.WriteLine(numero);
            }

            // Ejercicio #4 Obtener la suma de los elementos de la lista

            // Imperativo
            int suma = 0;
            foreach(var numero in numeros)
            {
                suma = suma + numero;
            }
            Console.WriteLine(suma);

            // Declarativo
            int sumaTotal = numeros.Aggregate((acumulador, numero) => acumulador + numero);
            Console.WriteLine(sumaTotal);

            // Ejercicio #5 Ordenar los números de forma asc.
            var ordenarNumerosASC = desordenados.OrderBy(desordenado => desordenado);
            foreach (var desordenado in ordenarNumerosASC)
                Console.WriteLine(desordenado);

            // Ejercicio #6 Ordenar los números de forma desc
            var ordenarNumerosDESC = desordenados.OrderBy(desordenado => -desordenado);
            foreach (var desordenado in ordenarNumerosDESC)
                Console.WriteLine(desordenado);

            // Ejercicio #7 Crear una lista con iteración funcional
            desordenados.OrderBy(numero => -numero).ToList().ForEach(
                numero => Console.WriteLine(numero));

            // Ejercicio #8 Encontrar elementos en una lista
            bool existeNumero = desordenados.Contains(7);
            Console.WriteLine(existeNumero);

            existeNumero = desordenados.Any(desordenado => desordenado ==10);
            Console.WriteLine(existeNumero);

            // Find: Retorna elemento si existe en caso contrario un valor
            // por default 0 si no existe
            int numEncontrado = desordenados.Find(numero => numero == 5);
            Console.WriteLine(numEncontrado);

            // Single: Retorna elemento si existe en caso contrario una
            // excepción.
            numEncontrado = desordenados.Single(numero => numero == 8);
            Console.WriteLine(numEncontrado);
            
        }
    }
}
