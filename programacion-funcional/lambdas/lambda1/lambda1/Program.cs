using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda1
{
    class Program
    {
        static void Main(string[] args)
        {
            // lamda = Función anónima
            // Func<tipodatoparametro, tipodatoretorno>(parametros) = El cuerpo de la función

            // Ejercicio #1 para saber si un número es par o no

            Func<int, bool> par = numero => numero % 2 == 0;
            Console.WriteLine("El número es par: " + par(9));

            // Ejercicio #2 para sumar dos números (Más de un parámetro)

            Func<int, int, int> suma = (numero1, numero2) => numero1 + numero2;
            Console.WriteLine("La suma de los dos números es: " + suma(4, 6));

            // Ejercicio #3 revisar si un correo es válido
            Func<string, bool> validador = correo =>
            {
                Console.WriteLine("Verificando correo...");
                if (!correo.EndsWith("@gmail.com", StringComparison.CurrentCulture))
                {
                    Console.WriteLine("Correo inválido");
                    return false;
                } else
                {
                    Console.WriteLine("Correo es válido");
                    return true;
                }
            };
                
            Console.WriteLine(validador("avexyk@gmail.com"));

            // Ejercicio #4 impresión de valor string obtenido por parámetro (no retorna valores)
            Action<string> saludo = mensaje => Console.WriteLine(mensaje);
            saludo("Buenos días");

        }
    }
}
