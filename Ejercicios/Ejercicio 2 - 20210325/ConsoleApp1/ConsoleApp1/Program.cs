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
            double valor = 0;
            double cubo = 1;
            double cuadrado = 1;
            int flag = 0;

            while(flag == 0)
            {
                Console.WriteLine("Ingrese un nro mayor a 0.");
                Double.TryParse(Console.ReadLine(), out valor);

                if (valor > 0)
                {
                    cubo = Math.Pow(valor, 3);
                    cuadrado = Math.Pow(valor, 2);
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar nro!\n");
                }
            }
            Console.WriteLine("El cuadrado del nro ingresado es: " + cuadrado);
            Console.WriteLine("El cubo del nro ingresado es: " + cubo);
            Console.ReadLine();

        }

    }
}
