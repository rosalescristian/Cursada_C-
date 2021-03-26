using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Validacion
    {
        public static bool validar(int valor, int min, int max)
        {
            bool resultado = false;
            if (valor >= min && valor <= max)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
