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

            int cantidad = -1, multiplicar = 1;
            char caracter = '*';

            Console.WriteLine("Ingrese una cantidad de lineas: ");
            Int32.TryParse(Console.ReadLine(), out cantidad);
            if(cantidad > 0)
            {
                for(int i = 1;i<cantidad+1;i++)
                {
                    
                    Console.WriteLine(5*char);
                    //multiplicar = multiplicar + 2;
                    
                    
                }
            }

            Console.ReadLine();

        }
    }
}
