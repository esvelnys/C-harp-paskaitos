using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var tekstas = "Fizz";
            var tekstas2 = "Buzz";
            var tekstas3 = "FizzBuzz";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(tekstas3);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(tekstas);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(tekstas2);
                }
                else
                {
                    Console.WriteLine(i);

                }
            }
           

        }
    }
}
