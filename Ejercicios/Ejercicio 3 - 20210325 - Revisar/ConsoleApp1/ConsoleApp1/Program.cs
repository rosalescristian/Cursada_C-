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
            int valor = 0, resto, divisor, salirWhile = -1, contador = 0, numero = 1;

            Console.WriteLine("Ingrese un nro positivo.");
            Int32.TryParse(Console.ReadLine(), out valor);
            
            if(valor <= 0)
            {
                Console.WriteLine("Ha ingresado un nro inválido. Reingrese.\n");
            }
            else
            {
                while(contador<valor)
                {
                    divisor = 2;
                    salirWhile = 0;

                    while((divisor < numero) & (salirWhile == 0))
                    {
                        resto = numero % divisor;

                        if (resto == 0)
                            salirWhile = 1;
                        else
                            divisor = divisor++;
                    }

                }
                if(salirWhile == 0)
                {
                    Console.WriteLine(numero + " ");
                    contador = contador++;
                }
                numero = numero++;
            }
            Console.WriteLine();
        }
    }
}
