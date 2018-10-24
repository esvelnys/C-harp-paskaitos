using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite skaičių masyvą. Suskaičiuokite skaičių sumą, vidurkį. 
             * Nenaudokite “greitųjų” radimo funkcijų (Sum() ir Average()).*/

            var skaiciai = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var suma = 0;
            foreach (var sk in skaiciai)
            {
                suma += sk;
            }

            Console.WriteLine("Suma: " + suma);

        }
    }
}
