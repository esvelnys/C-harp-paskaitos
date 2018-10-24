using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite laipsnius");
            
            var laipsniai =  Convert.ToDouble(Console.ReadLine());
            var Kelvinai = laipsniai + 273.15;
            var Farenheitai = laipsniai * 1.8 + 32;


            Console.WriteLine("Kelvinai = " + Kelvinai);
            Console.WriteLine ("Farenheitai = " + Farenheitai);

            

        }
    }
}
