using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Centimetro
    {
        public double cantidadCentimetros;

        public Centimetro()
        {
            this.cantidadCentimetros = 0;
        }

        public Centimetro(double centimetros)
        {
            this.cantidadCentimetros= centimetros;
        }

        public static Centimetro operator +(Centimetro centimetroUno, Metro metroUno)
        {
            Centimetro retornarCentimetro = new Centimetro();
            retornarCentimetro.cantidadCentimetros = centimetroUno.cantidadCentimetros+ (metroUno.cantidadMetros*100);
            return retornarCentimetro;
        }

        public static explicit operator double(Centimetro centimetroUno)
        {
            return centimetroUno.cantidadCentimetros;
        }

        /*public static bool operator == (Centimetro centimetroUno, Centimetro centimetroDos)
        {
            return centimetroUno.cantidadCentimetros == centimetroDos.cantidadCentimetros;
        }

        public static bool operator != (Centimetro centimetroUno, Centimetro centimetroDos)
        {
            return !(centimetroUno.cantidadCentimetros == centimetroDos.cantidadCentimetros);
        }
        */
    }
}
