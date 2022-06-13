using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "El mayor de dos numeros";
            int x;
            int y;
            Console.WriteLine("Digita el primer numero a comparar");
            Console.WriteLine("Entre el 1 y el 100");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita el segundo numero a comparar");
            Console.WriteLine("Entre el 1 y el 100");
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("\nEl numero {0} es mayor que {1}", x, y);
            }
            else
            {
                Console.WriteLine("\nEl numero {0} es mayor que {1}", y, x);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("\n----->Fin del programa");
            Console.ReadKey();
        }     
    }
}
