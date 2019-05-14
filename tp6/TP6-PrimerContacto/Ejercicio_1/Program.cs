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
            Console.Write("INGRESE UN NUMERO: ");
            num = int.Parse(Console.ReadLine());
            Invertir_Numero(num);
            Console.ReadKey();
        }

        static public void Invertir_Numero(int num)
        {
            int numero, invert = 0;
            numero = num;
            while (numero != 0)
            {
                invert = invert * 10 + (numero % 10);
                numero = numero / 10;
            }
            Console.Write(invert);
        }
    }
}
