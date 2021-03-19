using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Validacion
    {
        public bool Validar(int valor, int min, int max)
        {
            bool valido;

            if(valor >= min && valor <= max)
            {
                valido = true;
            }
            else
            {
                valido = false;
            }
            return valido;
        }
    }
}
