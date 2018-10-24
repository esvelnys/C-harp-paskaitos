using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Išveskite visus skaičius nuo 25 iki 50.
             * Vietoj skaičių, kurie dalinasi iš 3 išveskite tekstą „dalinasi iš 3“.*/

            var skaicius = 25;
            while (skaicius < 50)
            {
                skaicius++;

                if (skaicius % 3 == 0)
                {
                    Console.WriteLine("dalinasi is 3");
                }
                else
                {
                    Console.WriteLine(skaicius);
                }
            }
        }
    }
}
