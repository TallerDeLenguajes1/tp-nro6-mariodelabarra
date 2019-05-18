using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            String cadena = Console.ReadLine();
            Console.WriteLine();

            mostrarCad(cadena);
            busquedaCad(cadena);
            separarCad();
            Console.ReadKey();
            
        }

        static int LongitudStr(String cadena)
        {
            return cadena.Length;
        }

        static String Concatena(String cadena1, String cadena2)
        {
            String cadena3 = String.Concat(cadena1, cadena2);
            return cadena3;
        }

        static String SubCadena(String cadena)
        {
            return cadena.Substring(0, 3);
        }

        static void cadenaSuma()
        {
            int num1, num2, resultado;
            String cadena;
            Console.WriteLine("Introduzca el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero:");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;

            cadena = resultado.ToString();
            Console.WriteLine("La suma entre " + num1.ToString() + " y " + num2.ToString() + " es: " + cadena);
        }

        static void mostrarCad(String cadena)
        {
            foreach (char cadena1 in cadena)
            {
                Console.WriteLine(cadena1);
            }
        }

        static void busquedaCad(String cadena)
        {
            if (cadena.IndexOf("m") >= 0) Console.WriteLine("Se encuentra la letra m en la posicion: ");
            int pos = cadena.IndexOf("m");
            Console.WriteLine(pos);
        }

        static string mayusculas(string cadena)
        {
            return cadena.ToUpper();
        }

        static string minusculas(string cadena)
        {
            return cadena.ToLower();
        }

        static void compararLong(string cadena)
        {
            string cadena1;
            Console.WriteLine("Ingrese otra frase para comparar: ");
            cadena1 = Console.ReadLine();

            if(cadena.CompareTo(cadena1)> 0)
            {
                Console.WriteLine("La primera cadena ingresada es mas larga.");
            }
            else
            {
                Console.WriteLine("La seguda cadena ingresada es mas larga.");
            }
        }

        static void separarCad()
        {
            string cadena;
            char[] delimitadores = {'.', ',', ';'};
            Console.WriteLine("Ingrese una cadena para separar: ");
            cadena = Console.ReadLine();

            string[] separada = cadena.Split(delimitadores);

            for(int i=0; i<cadena.Length; i++)
            {
                Console.WriteLine("Fragmento {0}= {1}", i, separada[i]);
            }
        }

    }
}
