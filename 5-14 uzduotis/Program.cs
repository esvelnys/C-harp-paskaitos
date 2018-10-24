using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite 2 skaicius");

            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1>skaicius2)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antra");
            }
            if (skaicius2 > skaicius1)
            {
                Console.WriteLine("Antras skaicius didesnis uz pirma");
            }
            if (skaicius1==skaicius2)
            {
                Console.WriteLine("Skaiciai lygus");
            }
        }
    }
}
