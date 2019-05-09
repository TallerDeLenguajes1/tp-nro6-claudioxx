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

        }

        static public void MENU()
        {
            int opcion = 1;
            while (opcion != 0)
            {
                Console.Write("\n1:SUMAR\n2:RESTAR\n3:MULTIPLICAR\n4:DIVIDIR\n0:SALIR\n\nQUE OPERACION DESEA REALIZAR:");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:

                        break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 0: break;
                }
            }
        }
    }
}
