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
            int valorHora = -1, antiguedad = -1, cantidadHoras = -1, valorBruto = -1;
            double valorNeto, descuentos;
            string nombre = null;
            char cargaCompleta = 'n';

            while (cargaCompleta == 'n')
            {
                Console.WriteLine("Ingrese el valor de la hora: ");
                Int32.TryParse(Console.ReadLine(), out valorHora);

                Console.WriteLine("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad del empleado en anios: ");
                Int32.TryParse(Console.ReadLine(), out antiguedad);

                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
                Int32.TryParse(Console.ReadLine(), out cantidadHoras);

                if(valorHora > 0 && nombre != null && antiguedad > 0 && cantidadHoras > 0)
                {
                    cargaCompleta = 's';
                }
                else
                {
                    Console.WriteLine("ERROR! Ha ingresado un dato erroneo, debera reingresarlo.\n");
                }
            }

            valorBruto = (valorHora * cantidadHoras) + (antiguedad * 150);
            valorNeto = valorBruto * 0.87;
            descuentos = valorBruto * 0.13;

            Console.WriteLine("Nombre: "+nombre+ "\nAntiguedad: " + antiguedad + "\nValor Hora: " + valorHora + "\nTotal a Cobrar Bruto: " + valorBruto + "\nTotal Descuentos: " + descuentos + "\nValor Neto a Cobrar: " + valorNeto);
            Console.ReadLine();

        }


    }

}
