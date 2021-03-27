using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char rta = 'n';
            int num, sum = 0;
            bool validResponse = false;

            do
            {
                Console.WriteLine("Ingrese un nro: ");
                Int32.TryParse(Console.ReadLine(), out num);

                sum += num;
                
                Console.WriteLine(sum+"\n");
                Console.WriteLine("Desea continuar? s/n");
                
                rta = Console.ReadLine()[0];
                validResponse = ValidarRespuesta.ValidaS_N(rta);

            } while (validResponse == true);
            

        }
    }
}
