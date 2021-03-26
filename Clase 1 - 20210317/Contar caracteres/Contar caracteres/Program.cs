using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contar_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Pedir un texto y contar cuantas A tiene"
            string cadena;
            int contadorLetras;
            char caracterBuscado;

            Console.WriteLine("Ingrese una cadena de texto: ");
            cadena = Console.ReadLine();

            Console.WriteLine("Ingrese el caracter que desea buscar: ");
            caracterBuscado = Console.ReadLine()[0];

            contadorLetras = buscarCaracteres(cadena, caracterBuscado, out contadorLetras);

            Console.WriteLine(contadorLetras);
            Console.ReadLine();

        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="caracter"></param>
        /// <param name="caracteres"></param>
        /// <returns></returns>
        private static int buscarCaracteres(string cadena, char caracter, out int caracteres)
        {
            int caracterBuscado = 0;
            /*
            //ch = variable del caracter buscado
            int counter = 0;
            for(int i=0; i<input.lenght;i++)
            {
                if(input[i].Equals(ch)) // if(input.ToCharArray[i].Equals(ch))
                {
                    counter+=;
                }
            }
            */
            foreach (char x in cadena) // foreach (char x in cadena.ToCharArray())
            {
                if(x == caracter) // if(x.Equals(caracter))
                    caracterBuscado++;
            }
            caracteres = caracterBuscado;
            return caracteres;

        }
    }
    
}
