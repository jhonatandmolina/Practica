using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            int multiplicar = 0;

            Console.Write("Digite un numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite un numero");
            numero2 = Convert.ToInt32(Console.ReadLine());
            multiplicar = numero1 * numero2;
            Console.WriteLine($"La multiplicacion es {multiplicar}");

            Console.ReadKey();
        }
    }
}
