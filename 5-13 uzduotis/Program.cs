using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius%2==0)
            {
                Console.WriteLine("dalinasi is 2");
            }
            else if (skaicius%3==0)
            {
                Console.WriteLine("dalinasi is 3");
            }
            else if (skaicius % 4 == 0)
            {
             Console.WriteLine("dalinasi is 4");
            }
            else if (skaicius % 5 == 0)
            {
                Console.WriteLine("dalinasi is 5");
            }
            else if (skaicius % 7 == 0)
            {
                Console.WriteLine("dalinasi is 7");
            }
            else
            {
                Console.WriteLine("Klaida");
            }
        }
    }
}
