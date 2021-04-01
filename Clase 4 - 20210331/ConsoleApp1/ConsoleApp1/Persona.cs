using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        #region Atributos   
        public string apellido; // con #region creamos regiones y adentro se compacta el codigo "relacionado"
        public string nombre;
        public int dni;
        private static int cantidadPersonas;
        #endregion

        #region Constructores
        /// <summary>
        /// 
        /// </summary>
        static Persona()
        {
            //cantidadPersonas = 66; --> la primera vez lo pusimos a proposito en 66.
            Persona.cantidadPersonas = 0;
        }
        /// <summary>
        /// Constructor Persona vacia
        /// </summary>
        public Persona()
        {
            this.apellido = "sin apellido";
            this.nombre = "sin nombre";
            this.dni = -1;
            Persona.cantidadPersonas++;
        }
        /// <summary>
        /// Sobrecarga Constructor Persona
        /// </summary>
        /// <param name="apellido"></param>
        public Persona(string apellido):this()
        {
            this.apellido = apellido;
            //this.nombre = "sin nombre";
            //this.dni = -1;
        }
        /// <summary>
        /// Sobrecarga Constructor Persona
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Persona(string apellido, int dni):this(apellido)
        {
            //this.apellido = apellido;
            //this.nombre = "sin nombre";
            this.dni = dni;
        }
        /// <summary>
        /// Sobrecarga Constructor persona
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        public Persona(string apellido, string nombre, int dni):this(apellido,dni)
        {
            //this.apellido = apellido;
            this.nombre = nombre;
            //this.dni = dni;
        }
        #endregion
        
        /// <summary>
        /// Muestra cantidad Personas
        /// </summary>
        /// <returns></returns>
        public static int MostrarCantidadPersonas()
        {
            return Persona.cantidadPersonas;
        }
    }
}
