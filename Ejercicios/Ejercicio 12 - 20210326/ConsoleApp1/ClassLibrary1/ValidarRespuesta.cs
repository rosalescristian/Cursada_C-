using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ValidarRespuesta
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool ValidaS_N(char c)
        {
            bool resultado = false;
            if (c == 's')
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
