using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int min = -100;
            int max = 100;
            bool resultado;

            Console.WriteLine("Ingrese un nro entero: ");
            numero = Console.Read();
            Validacion.validar(numero, min, max);
            Console.WriteLine(resultado);
            Console.Read();



        }
    }
}
