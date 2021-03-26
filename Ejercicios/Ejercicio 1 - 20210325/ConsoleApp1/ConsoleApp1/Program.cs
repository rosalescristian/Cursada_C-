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
            int valor = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            int promedio = 0;
            int suma = 0;
            int count = 0;

            do
            {
                Console.WriteLine("Ingrese un nro: ");
                if ((Int32.TryParse(Console.ReadLine(), out valor)))
                {
                    if (valor < min)
                        min = valor;
                    if (valor > max)
                        max = valor;
                    
                    suma += valor;
                    count++;
                }
            } while (count < 5); // No entiendo porque no me toma el count<6 y si el count<5
            promedio = suma / count;
            Console.WriteLine("El valor maximo es: " + max);
            Console.WriteLine("El valor minimo es: " + min);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadLine();
        }
    }
}
