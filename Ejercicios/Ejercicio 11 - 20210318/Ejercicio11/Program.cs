using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = -100;
            int max = 100;
            int valorParseado;
            int contador = 0;
            int suma = 0;
            int valorMaximo = int.MinValue;
            int valorMinimo = int.MaxValue;
            float promedio;
            string valor;
            char rta;
            bool validado = false;

            do
            {
                Console.WriteLine("Ingrese un Nro Entero: ");
                valor = Console.ReadLine();
                int.TryParse(valor, out valorParseado);
                validado = Validacion.validar(valorParseado, min, max);
                if (validado)
                {
                    suma += valorParseado;
                    contador++;

                    if (valorParseado >= valorMaximo)
                        valorMaximo = valorParseado;
                    if (valorParseado <= valorMinimo)
                        valorMinimo = valorParseado;

                }
                else
                {
                    Console.WriteLine("Ha ingresado un nro invalido. Reingrese\n");
                }
                
                Console.WriteLine("Desea continuar? s/n");
                rta = Convert.ToChar(Console.ReadLine());
            
                if (rta == 'n')
                    break;
                            
            } while (contador < 11);

            promedio = suma / contador;
            //double decimales = (float)(Math.Round((double)f, 2); --> esto era un intento de mostrar un double con 2 decimales q no me funcionó
            Console.WriteLine("La suma de los valores es: "+suma);
            Console.WriteLine("El promedio de los valores es: "+promedio);
            Console.WriteLine("El valor Maximo es: "+valorMaximo);
            Console.WriteLine("El valor Minimo es: "+valorMinimo);
            Console.ReadLine();
        }
    }
}
