using System;
//using Class1

namespace ConsoleApp1
{
    class Program
    {
        /*static void Main(string[] args)
        {
            float resultado;
            float resultadoDos;
        
            //Console.WriteLine(Persona.cantidadPersonas); // lo ponemos a proposito al primer nivel
            
            //float resultadoTres;
            resultado = Calculadora.Sumar(7, 8);
            //Console.WriteLine(Calculadora.Sumar(7, 8));
            resultadoDos = Calculadora.Sumar(7, 8, 9);
            Console.WriteLine(resultado);
            Console.WriteLine(resultadoDos);

            Persona PersonaUno = new Persona("Jesus");
            
            Persona PersonaDos = new Persona("Maria", "Perez", 666);

            //Console.WriteLine(Persona.cantidadPersonas); // lo ponemos a proposito al primer nivel

            Console.WriteLine(Persona.MostrarCantidadPersonas());
            Console.ReadKey(true);
        }*/ // Comento la primera parte de la clase, despues de aca volvimos del recreo
        static void Main(string[] args)
        {

            Metro metroUno;
            Centimetro centimetroUno;

            metroUno = new Metro(10);
            centimetroUno = new Centimetro(10);

            //double sumaMetros;
            //sumaMetros = metroUno + metroUno; -- esto no va
            //Metro sumaMetros;
            Metro sumaMetros = metroUno + metroUno;
            //sumaMetros = new Metro();
            //sumaMetros.cantidadMetros = metroUno.cantidadMetros + metroUno.cantidadMetros;
            //sumaMetros = Console.WriteLine(sumaMetros.cantidadMetros); --> devuelvo el atributo de la suma de metros
            //Console.WriteLine(sumaMetros.cantidadMetros);
            //Console.WriteLine((double)sumaMetros); // --> casteo del operador de sumaMetros implicito
            /*Console.WriteLine(sumaMetros); // --> casteo del operador de sumaMetros en el metodo de casteo

            int laSuma;
            laSuma = sumaMetros;

            Console.WriteLine(sumaMetros);
            */
            Centimetro sumaCentimetro = new Centimetro();

            sumaCentimetro = centimetroUno + metroUno;
            Console.WriteLine(sumaCentimetro.cantidadCentimetros);

            centimetroUno.cantidadCentimetros = 20;
            sumaCentimetro.cantidadCentimetros = 20;

            /*if(centimetroUno == sumaCentimetro)
            {
                Console.WriteLine("Son Iguales");
            }
            if (centimetroUno != sumaCentimetro)
            {
                Console.WriteLine("Son Distintos");
            } // --> estos ifs no funcionan
            */

            Kilometro miKilometro = 100;
            Console.WriteLine(miKilometro.cantidadKilometro);
            Console.ReadKey(true);
        }
    }
}
