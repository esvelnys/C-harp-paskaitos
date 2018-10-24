using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");

            var skaicius1 = Convert.ToDouble(Console.ReadLine());
            var skaicius2 = Convert.ToDouble(Console.ReadLine());
            var skaicius3 = Convert.ToDouble(Console.ReadLine());

            var vidurkis = (skaicius1 + skaicius2 + skaicius3) / 3;

            Console.WriteLine("Ivestu skaiciu vidurkis : " + vidurkis);


        }
    }
}
