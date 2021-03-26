using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now, birthDate;
            int day = -1, month = -1, year = -1, dateDiff = -1, currentYear = today.Year;
            bool yearValid = false, monthValid = false, dayValid = false;

            while(yearValid == false && monthValid == false && dayValid == false)
            {
                Console.WriteLine("Ingrese su Anio de Nacimiento: ");
                Int32.TryParse(Console.ReadLine(), out year);

                if (year < currentYear-150 || year > currentYear)
                {
                    Console.WriteLine("Ingreso un Anio erroneo. Debera Reingresarlo.\n");
                    //Int32.TryParse(Console.ReadLine(), out month);
                }
                else
                    yearValid = true;

                Console.WriteLine("Ingrese su Mes de Nacimiento: ");
                Int32.TryParse(Console.ReadLine(), out month);
                
                if (month < 0 || month > 12)
                {
                    Console.WriteLine("Ingreso un mes erroneo. Debera Reingresarlo.\n");
                    //Int32.TryParse(Console.ReadLine(), out month);
                }
                else
                    monthValid = true;

                Console.WriteLine("Ingrese su Dia de Nacimiento: ");
                Int32.TryParse(Console.ReadLine(), out day);

                if (day < 0 || day > 31)
                {
                    Console.WriteLine("Ingreso un dia erroneo. Debera Reingresarlo.\n");
                    //Int32.TryParse(Console.ReadLine(), out day);
                }
                else
                    dayValid = true;
            }
            
            birthDate = new DateTime(year, month, day);
            dateDiff = (today.Subtract(birthDate)).Days;

            Console.WriteLine("Usted ha vivido " + dateDiff + " dias.\n");
            Console.ReadLine();
        }
    }
}
