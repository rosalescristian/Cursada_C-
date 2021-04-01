using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Metro
    {
        public double cantidadMetros;
        /// <summary>
        /// 
        /// </summary>
        public Metro()
        {
            this.cantidadMetros = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metros"></param>
        public Metro(double metros)
        {
            this.cantidadMetros = metros;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metroUno"></param>
        /// <param name="metroDos"></param>
        /// <returns></returns>
        public static Metro operator+(Metro metroUno, Metro metroDos)
        {
            Metro retornarMetro = new Metro();
            retornarMetro.cantidadMetros = metroUno.cantidadMetros + metroDos.cantidadMetros;
            return retornarMetro;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="metroUno"></param>
        public static explicit operator double(Metro metroUno)
        {
            return metroUno.cantidadMetros;
        }

        /// <summary>
        /// No hacer esto pero funciona
        /// </summary>
        /// <param name="metroUno"></param>
        public static implicit operator int(Metro metroUno)
        {
            return (int)metroUno.cantidadMetros;
        }
    }
}
