using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite egzamino pazymi");

            var pazymys = Convert.ToInt32(Console.ReadLine());

            if (pazymys==10)

            {
                Console.WriteLine("Puiku");
            }

            if (pazymys==9)
            {
                Console.WriteLine("Labai gerai");
                if (pazymys>=7)
                {
                    Console.WriteLine("Gerai");
                }
                if (pazymys>=5)
                {
                    Console.WriteLine("Patenkinamai");
                }
                if (pazymys<5)
                {
                    Console.WriteLine("Egzaminas neislaikytas");
                }
            }
        }
    }
}
