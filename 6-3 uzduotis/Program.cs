using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivveskite bet koki skaiciu");

            var kintamasis = Convert.ToInt32(Console.ReadLine());

            if (kintamasis%2==0 || kintamasis%5==0 || kintamasis%7==0)
            {
                Console.WriteLine("Skaicius dalinasi is 2, 5, arba 7");
            }
            else
            {
                Console.WriteLine("Skaicius nesidalina is 2,5 arba 7");
            }
        }

    }
}
