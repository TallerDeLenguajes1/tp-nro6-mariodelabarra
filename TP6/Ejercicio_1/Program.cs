using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(invertir(num));
        }

        static int invertir(int num)
        {
            int numAux = 0;

            if (num > 0)
            {
                while (num != 0)
                {
                    numAux = numAux * 10 + num % 10;
                    num /= 10;
                }
            }
            else
            {
                Console.WriteLine("No se puede invertir ya que el numero es menor o igual que 0.");
            }

            return numAux;
        }
    }
}
