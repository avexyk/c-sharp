using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados1
{
    class Program
    {
        public delegate float DelegateOperacion(float val1, float val2);

        public static float Deposito(float cantidad, float monto)
        {
            return cantidad + monto;
        }

        public static float Retiro(float cantidad, float monto)
        {
            if(cantidad > monto)
            {
                Console.WriteLine("No es posible realizar el retiro");
                return 0.0f;
            }
            return monto - cantidad;
        }

        public static float EjecutarOperacion(DelegateOperacion operacion, float cantidad, float monto)
        {
            Console.WriteLine("Estamos por ejecutar una operación");
            float result = operacion(cantidad, monto);
            Console.WriteLine(result);
            Console.WriteLine("La operacion se ha ejecutado");
            return result;
        }

        static void Main(string[] args)
        {
            // Ejercicio #1 Simulación de un cajero que permita depósitos y retiros
            // Función 1: Depósito
            // Función 2: Retiro
            // Función 3: Ejecutor de operaciones
            // Las operaciones serán iguales a las funciones. Las operaciones se representan con funciones
            // Habrá una tercera función que se encargue de ejecutar la operación, esta no sabrá que operación se esta ejecutando
            // Con la tercera función se implementara los CALLBACKs

            DelegateOperacion retiro = Retiro;
            DelegateOperacion deposito = Deposito;

            // EjecutarOperacion(retiro, 10, 100);

            DelegateOperacion depositoInteres = (cantidad, monto) =>
            {
                if(cantidad > 100)
                {
                    return cantidad + monto + (cantidad * 0.02f);
                }
                return cantidad + monto;
            };

            EjecutarOperacion(depositoInteres, 101, 100);
         }
    }
}
