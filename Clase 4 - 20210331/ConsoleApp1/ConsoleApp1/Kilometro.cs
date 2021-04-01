using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kilometro
    {
        public double cantidadKilometro;
        
        private Kilometro(double kilometros)
        {
            this.cantidadKilometro=kilometros;
        }

        public static implicit operator Kilometro(int kilometroUno)
        {
            Kilometro kilometroReturn = new Kilometro(kilometroUno);
            return kilometroReturn;
        }
    }
}
