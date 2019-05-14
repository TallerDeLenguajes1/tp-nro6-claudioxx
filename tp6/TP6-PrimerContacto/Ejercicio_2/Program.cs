using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MENU();
        }

        static public void MENU()
        {
            int opcion=0, a=0,b=0;
            Console.Clear();
            Console.Write("1:SUMA\n2:RESTA\n3:MULTIPLICACION\n4:DIVIDISION\n5:VA,CUADRADO,RAIZ,SENO,COSENO,PARTE ENTERA,MAX y MIN\n6:EJERCICIO 6\n0:SALIR\n\nQUE OPERACION DESEA REALIZAR:");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("\t\tSUMA\n");
                    Pedir_Numeros(ref a, ref b);
                    Console.Write("\nLa suma de " + a + " y " + b + " es: " + Suma(a, b));
                    Otra_Operacion();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("\t\tRESTA\n");
                    Pedir_Numeros(ref a, ref b);
                    Console.Write("\nLa resta de " + a + " y " + b + " es: " + Resta(a, b));
                    Otra_Operacion();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("\t\tMULTIPLICACION\n");
                    Pedir_Numeros(ref a, ref b);
                    Console.Write("\nLa multiplicacion entre " + a + " y " + b + " es: " + Multiplcacion(a, b));
                    Otra_Operacion();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\t\tDIVISION\n");
                    do
                    {
                        Pedir_Numeros(ref a, ref b);
                        if (b <= 0)
                            Console.Write("\nEL DIVISOR DEBE SER MAYOR A 0 (CERO)\n\n");
                    } while (b <= 0);
                    Console.Write("\nLa division entre " + a + " y " + b + " es: " + Division(a, b));
                    Otra_Operacion();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("\t\tVA,CUADRADO,RAIZ,SENO,COSENO,PARTE ENTERA,MAX y MIN\n");
                    Valores();
                    Otra_Operacion();
                    break;
                case 6:
                    string text;
                    Console.Clear();
                    Console.Write("\t\tEJERCICIO 6\n\nINGRESAR UN TEXTO: ");
                    text = Console.ReadLine();
                    Letras_cadena(text);
                    Longitud(text);
                    //LUEGO DE CONCATENAR, DEBERIA GUARDAR LA CADENA COMBINADA???
                    Concatenar(ref text);
                    Subcadena(text);
                    Recorrer_cadena(text);
                    Ocurrencias(text);
                    Bloq_Mayus(text);
                    Comparar(text);
                    separar();
                    Otra_Operacion();
                    break;
                case 0:
                    break;
            }
        }

        static public void Pedir_Numeros(ref int a,ref int b)
        {   
            Console.Write("INGRESAR DOS NUMEROS\n1:");
            a = int.Parse(Console.ReadLine());
            Console.Write("2:");
            b = int.Parse(Console.ReadLine());
        }

        static public int Suma (int a,int b)
        {
            int suma;
            suma = a + b;
            return suma;
        }

        static public int Resta(int a, int b)
        {
            int resta;
            resta = a - b;
            return resta;
        }
        static public int Multiplcacion(int a, int b)
        {
            int multiplicacion;
            multiplicacion = a * b;
            return multiplicacion;
        }
        static public int Division(int a, int b)
        {
            int division;
            division = a / b;
            return division;
        }

        static public void Valores()
        {
            int num,num1,num2;
            float aux;
            Console.Write("INGRESAR UN NUMERO:");
            num = int.Parse(Console.ReadLine());
            aux = (float)num;
            Console.Write("\nValor absoluto: " + Math.Abs(num) + "\nCuadrado:" + Math.Pow(num, 2) + "\nRaiz cuadrada: " + Math.Sqrt(num) + "\nSeno: " + Math.Sin(num) + "\nCoseno: " + Math.Cos(num) + "\nParte entera: " + Math.Truncate(aux) + "\n\n\t\tMAXIMO Y MINIMO\n\nINGRESAR DOS NUMEROS:\n1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("2:");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("\nENTRE "+num1+" Y "+num2+"\nMaximo:"+Math.Max(num1,num2)+"\nMinimo:"+Math.Min(num1,num2)+"\n");
        }

        static public void Letras_cadena(string cad)
        {
            int cont = 0;
            char letra;
            Random rand = new Random();
            Console.Write("\n* Algunas letras que conforman el texto: ");
            for (cont = 0; cont < rand.Next(1,cad.Length); cont++)
            {
                letra = cad[rand.Next(cad.Length)];
                if(char.IsLetter(letra))
                    Console.Write(letra+" ");
            }
        }

        static public void Longitud(string cad)
        {
            int longitud;
            longitud = cad.Length;
            Console.Write("\n* Longitud de la cadena: " + longitud);
        }

        static public void Concatenar(ref string cad)
        {
            string aux;
            Console.Write("\n\nINGRESAR OTRO TEXTO: ");
            aux = Console.ReadLine();
            //DOS MANERAS PARA CONCATENAR STRINGS.
            //cad += aux;
            cad = $"{cad} {aux}";
            Console.Write("\n* Textos concatenados: "+cad);
        }

        static public void Subcadena(string cad)
        {
            string aux;
            Random rand = new Random();
            aux = cad.Substring(rand.Next(cad.Length-1));
            Console.Write("\n* Subcadena del texto: " + aux);
        }

        static public void Recorrer_cadena(string cad)
        {
            Console.Write("\n* Texto reccorido con *FOREACH*: ");
            foreach(char letra in cad)
            {
                Console.Write(letra+" ");
            }
        }

        static public void Ocurrencias(string cad)
        {
            string aux;
            Console.Write("\n\nINGRESAR PALABRA A BUSCAR EN EL TEXTO: ");
            aux = Console.ReadLine();
            if (cad.Contains(aux))
                Console.Write("\n* La palabra (" + aux + ") si se encuentra en el texto.");
            else
                Console.Write("\n* La palabra (" + aux + ") no se encuentra en el texto.");
        }

        static public void Bloq_Mayus(string cad)
        {
            Console.Write("\n* Texto en mayuscula: " + cad.ToUpper() + "\n* Texto en minuscula: " + cad.ToLower());
        }

        static public void Comparar(string cad)
        {
            string aux;
            Console.Write("\n\nINGRESAR TEXTO A COMPARAR CON EL ORIGINAL: ");
            aux = Console.ReadLine();
            Console.Write("\n* Comparacion de textos: ");
            if (cad.CompareTo(aux) < 0)
                Console.Write("El texto ingresado es MAYOR al original.");
            else if(cad.CompareTo(aux)>0)
                Console.Write("El texto ingresado es MENOR al original.");
            else
                Console.Write("El texto ingresado es IGUAL al original.");
        }

        static public void separar()
        {
            string aux;
            char separador;
            Console.Write("\n\nINGRESAR UN TEXTO: ");
            aux = Console.ReadLine();
            Console.Write("\nINGRESAR EL CARACTER QUE SEPARARA EL TEXTO: ");
            separador = Convert.ToChar(Console.ReadLine());
            Console.Write("\n\n* Texto separado:\n");
            string[] cadenas = aux.Split(separador);
            foreach(string cad in cadenas)
            {
                Console.WriteLine(" " + cad);
            }
        }

        static public void Otra_Operacion()
        {
            string eleccion;
            Console.Write("\n\nDESEA REALIZAR OTRA OPERACION (SI/NO): ");
            eleccion = Console.ReadLine();
            eleccion = eleccion.ToLower();
            if (eleccion == "si")
                MENU();
            else if (eleccion == "no")
                return;
            else
            {
                Console.Write("OPCION INCORRECTA.\n");
                Otra_Operacion();
            }
        }

    }
}
