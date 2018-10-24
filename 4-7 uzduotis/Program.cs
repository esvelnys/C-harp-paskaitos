using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite penkis skaicius");

            var skaicius1 = Convert.ToDouble(Console.ReadLine());
            var skaicius2 = Convert.ToDouble(Console.ReadLine());
            var skaicius3 = Convert.ToDouble(Console.ReadLine());
            var skaicius4 = Convert.ToDouble(Console.ReadLine());
            var skaicius5 = Convert.ToDouble(Console.ReadLine());
            var vidurkis = (skaicius1 + skaicius2 + skaicius3 + skaicius4 + skaicius5) / 5;

            Console.WriteLine("Skaiciu vidurkis: " + vidurkis);
        }
    }
}
