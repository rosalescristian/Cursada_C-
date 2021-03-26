using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioMin;
            int anioMax;

            Console.WriteLine("Ingrese un anio inicial: ");
            Int32.TryParse(Console.ReadLine(), out anioMin);

            Console.WriteLine("\nIngrese un anio final: ");
            Int32.TryParse(Console.ReadLine(), out anioMax);
            
            for(int i = anioMin; i < anioMax+1; i++)
            {
                if (((i % 4 == 0) && (i % 100 == 0) && (i % 400 == 0)) || ((i % 4 == 0) && (i % 100 != 0)))
                {
                    Console.WriteLine("\nEl año: "+i+" es biciesto");
                }
            }
            Console.ReadLine();

        }
    }
}
