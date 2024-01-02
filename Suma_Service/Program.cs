using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Suma_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            //ServiceReferenceSuma.Service_SumaClient objSuma = new ServiceReferenceSuma.Service_SumaClient();

            ServiceReferenceSuma.Service_SumaClient serviceSumaInstance = new ServiceReferenceSuma.Service_SumaClient();

            Console.WriteLine("¡Bienvenido!");
            Console.WriteLine("A continuación, te mostramos el proceso de suma de dos números.");

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Ingrese el primer número:");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Ingrese el segundo número:");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

            // Llamar al método sumarNumeros a través de la instancia de Service_Suma
            int resultadoSuma = serviceSumaInstance.sumarNumeros(num1, num2);

            Console.WriteLine("-----------------------------------------------------------------"); 

            Console.WriteLine($"La suma de los números {num1} + {num2} es: {resultadoSuma}");
            Console.ReadKey();


        }
    }
}

