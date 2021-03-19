using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string miTexto;
            Console.Write("Ingrese un Numero: ");
            
            miTexto = Console.ReadLine(); // scanf(%s,&miTexto);
            
            int numeroParseado = int.Parse(miTexto); //Parseo a int
            
            //Console.WriteLine(miTexto); // --> comentado porque es lo que hicimos en la primera corrida, solo mostrar el nro sin la operacion matematica de +5 del paso q sigue
            
            int numeroParseadoCasteado = (int)float.Parse(miTexto); //Casteo Explicito --> para evitar perdida de datos por memoria del Float de un espacio de memoria mas grande a uno mas chico

            //double resultadoSuma = suma(numeroParseadoCasteado, 5); //Casteo Implicito --> como voy de un lugar de memoria mas chico a mas grande no voy a perder datos

            //double valor = numeroParseadoCasteadoDos;
            //double resultadoSuma = suma(ref valor, 5); // ref valor esta pasando la referencia a la variable valor (tenes que pasar referencia del mismo tipo de dato, es como en C el double &valor la direccion de memoria de la variable)
            //double resultadoSuma = suma(numeroParseadoCasteado, 5);
            
            if(int.TryParse(miTexto, out numeroParseadoCasteado))
            {
                double valor = numeroParseadoCasteado;
                double resultado;
                //casteo implicito
                double resultadoSuma = suma(valor, 5, out resultado);
            }
            else
            {
                do
                {
                    Console.Write("Error. Reingrese un numero");
                    miTexto = Console.ReadLine();

                } while (int.TryParse(miTexto, out numeroParseadoCasteado));
            }

            Console.WriteLine(numeroParseado); // Primer Vuelta
            Console.WriteLine(numeroParseadoCasteado); // Segunda Vuelta
            Console.WriteLine(numeroParseado + 5); // Primer Vuelta + 5
            Console.WriteLine(numeroParseadoCasteado + 5); // Segunda Vuelta + 5
            //Console.WriteLine(resultadoSuma); // Tercer Vuelta
            Console.WriteLine(5);
            Console.ReadLine();
        }

        //private static double suma (double sumando, double sumandoDos) // primera definicion de metodo
        private static double suma(double sumando, double sumandoDos, out double suma) // voy a asignar valor en la variable suma con el prefijo OUT. Pero no la puedo usar para operar; si o si debo asignarle el valor.
        {
            sumando = sumando + sumandoDos;
            suma = sumando;
            return sumando;
        }
        //public static
    }
}
