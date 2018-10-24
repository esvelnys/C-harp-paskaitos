using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite triju egzaminu rezultatus :");

            var rezultatas1 = Convert.ToInt32(Console.ReadLine());
            var rezultatas2 = Convert.ToInt32(Console.ReadLine());
            var rezultatas3 = Convert.ToInt32(Console.ReadLine());

            var vidurkis = (rezultatas1 + rezultatas2 + rezultatas3) / 3;

            if (vidurkis>=8 && vidurkis <=10)
            {
                Console.WriteLine("Vidurkis yra [8-10]");
            }
            if (vidurkis>=5 && vidurkis<=7)
            {
                Console.WriteLine("Vidurkis yra [8-5]");
            }
            if (vidurkis< 5 )
            {
                Console.WriteLine("Vidurkis <5");
            }
        }
    }
}
