using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu :");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var suma = skaicius1 + skaicius2;

            Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, suma);
        }
    }
}
