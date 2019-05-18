using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            float resultado;

            do
            {
                Menu();
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        resultado = Suma();
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 2:
                        resultado = Resta();
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 3:
                        resultado = Producto();
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                    case 4:
                        resultado = Division();
                        Console.WriteLine("El resultado es: " + resultado);
                        break;
                }
                Console.WriteLine("¿Desea realizar otra operacion?: (1- Si, 0- No)");
                opc = int.Parse(Console.ReadLine());
            } while (opc != 0);
        }

        static void Menu()
        {
            Console.WriteLine("| === Calculadora === |");
            Console.WriteLine("1- Sumar 2 numeros.");
            Console.WriteLine("2- Restar 2 numeros.");
            Console.WriteLine("3- Producto entre 2 numeros.");
            Console.WriteLine("4- Division entre 2 numeros.");
            Console.WriteLine("Seleccione una opcion: ");
        }

        static int Suma()
        {
            int num1, num2;
            Console.WriteLine("Introduzca el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            return num1 + num2;
        }

        static int Resta()
        {
            int num1, num2;
            Console.WriteLine("Introduzca el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            return num1 - num2;
        }

        static int Producto()
        {
            int num1, num2;
            Console.WriteLine("Introduzca el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            return num1 * num2;
        }

        static float Division()
        {
            float num1, num2;
            Console.WriteLine("Introduzca el primer numero:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero:");
            num2 = float.Parse(Console.ReadLine());

            return num1 / num2;
        }
        
    }
}
