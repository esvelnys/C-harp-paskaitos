using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite skaicius");

            var skaicius1 = Convert.ToDouble(Console.ReadLine());
            var skaicius2 = Convert.ToDouble(Console.ReadLine());
            var suma = skaicius1 + skaicius2;
            var skirtumas = skaicius1 - skaicius2;
            var dalyba = skaicius1/skaicius2;
            var daugyba = skaicius1*skaicius2;

            Console.WriteLine("{0} + {1} = {2}", skaicius1, skaicius2, suma);
            Console.WriteLine("{0} - {1} = {2}", skaicius1, skaicius2, skirtumas);
            Console.WriteLine("{0} / {1} = {2}", skaicius1, skaicius2, dalyba);
            Console.WriteLine("{0} * {1} = {2}", skaicius1, skaicius2, daugyba);
        }
    }
}
