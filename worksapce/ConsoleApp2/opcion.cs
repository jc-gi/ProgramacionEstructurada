using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            int numero1=2;
            int numero2=3;
            int suma=0;
            Console.Title = "SWITCH CASE";
            Console.WriteLine("\n\tOPERACIONES MATEMATICAS");
            Console.WriteLine("\n\t1. SUMAR");
            Console.WriteLine("\n\t2. RESTAR");
            Console.WriteLine("\n\t3. MULTIPLICAR");
            Console.WriteLine("\n\t4. DIVIDIR");
            Console.WriteLine("\n\t5. SALIR DEL PROGRAMA");
            Console.WriteLine("\n\n\t Digite su opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    suma = numero1 + numero2;
                    Console.WriteLine("\t El resultado de la suma es: " + suma);
                    break;
                case 2:
                    Console.WriteLine("\t El resultado de la resta es: ");
                    break;
                case 3:
                    Console.WriteLine("\t El resultado de la multiplicacion es: ");
                    break;
                case 4:
                    Console.WriteLine("\t El resultado de la division es: ");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\t Opcion no definida..intente de nuevo");
                    break; 
            }
            Console.ReadKey();
        }
    }
}
    
