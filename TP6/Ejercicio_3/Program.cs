using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            float resultado;

            do
            {
                Console.Clear();
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
                    case 5: ValorAbs();
                        break;
                    case 6: Cuadrado();
                        break;
                    case 7: Raiz();
                        break;
                    case 8: Seno();
                        break;
                    case 9: Coseno();
                        break;
                    case 10: ParteFloat();
                        break;
                }
                MayorMenor();
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
            Console.WriteLine("5- Valor absoluto de un numero.");
            Console.WriteLine("6- El cuadrado de un numero.");
            Console.WriteLine("7- La raiz cuadrada de un numero.");
            Console.WriteLine("8- El seno de un numero.");
            Console.WriteLine("9- El coseno de un numero.");
            Console.WriteLine("10- La parte entera de un numero flotante.");
            Console.WriteLine("0- Salir.");
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

        static void ValorAbs()
        {
            int num1;
            Console.WriteLine("Introduzca el numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El valor absoluto de " + num1 + " es : " + Math.Abs(num1));
        }

        static void Cuadrado()
        {
            int num1;
            Console.WriteLine("Introduzca el numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El cuadrado de "+ num1 + " es :" + Math.Pow(num1, 2));
        }

        static void Raiz()
        {
            int num1;
            Console.WriteLine("Introduzca el numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("La raiz cuadrada de " + num1 + " es: " + Math.Sqrt(num1));
        }
        
        static void Seno()
        {
            int num1;
            Console.WriteLine("Introduzca el numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El seno de " + num1 + " es :" + Math.Sin(num1));
        }

        static void Coseno()
        {
            int num1;
            Console.WriteLine("Introduzca el numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("El coseno de " + num1 + " es: " + Math.Cos(num1));
        }

        static void ParteFloat()
        {
            float num1;
            Console.WriteLine("Introduzca el numero:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("La parte entera de " + num1 + " es: " + Math.Truncate(num1));
        }

        static void MayorMenor()
        {
            int num1, num2;
            Console.WriteLine("| === El maximo y minimo entre 2 numeros === |");
            Console.WriteLine("Introduzca el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El maximo entre " + num1 + " y " + num2 + " es: " + Math.Max(num1, num2));
            Console.WriteLine("El minimo entre " + num1 + " y " + num2 + " es: " + Math.Min(num1, num2));
        }
    }
}
