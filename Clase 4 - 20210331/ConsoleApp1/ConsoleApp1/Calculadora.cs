using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculadora
    {
        //float numeroUno, numeroDos;

        public static float Sumar(float numeroUno, float numeroDos)
        {
            return numeroUno + numeroDos;
        }

        /// <summary>
        /// Primera Sobrecarga (Metodo con el mismo nombre con parametros diferentes)
        /// </summary>
        /// <param name="numeroUno">El primer parametro</param>
        /// <param name="numeroDos">El segundo parametro</param>
        /// <param name="numeroTres">El tercer parametro</param>
        /// <returns></returns>
        public static float Sumar(float numeroUno, float numeroDos, float numeroTres)
        {
            return numeroUno + numeroDos + numeroTres;
        }

    }
}
