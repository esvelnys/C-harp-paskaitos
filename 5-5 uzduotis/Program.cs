using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki teigiam skaiciu");

            var skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius<0)
            {
                Console.WriteLine("Aprekti!!!!!!!");
            }

            if (skaicius>0)
            {
                Console.WriteLine("Sveikinimai!!!!!");
            }
            if (skaicius%2==0)
            {
                Console.WriteLine("Skaicius lyginis");
            }
            if (skaicius%4==0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }
            if (skaicius>10)
            {
                Console.WriteLine("Skaicius didesnis uz 10");
            }
        }
    }
}
