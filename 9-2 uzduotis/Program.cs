using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var kiekis = 1;
            while (kiekis<=50)

            {
                var skaicius = rand.Next(1, 50);
                Console.WriteLine(skaicius);
                if (skaicius%2==0)
                {
                    Console.Write(" lyginis");
                }
                else if (skaicius==1||skaicius%3==0)
                {
                    Console.Write("nelyginis");
                }
                Console.WriteLine();

                kiekis++;
            }

/*Išveskite visus skaičius nuo 1 iki 50.
 * Prie kiekvieno lyginio skaičiaus parašykite žodį „lyginis“,
 * o prie kiekvieno nelyginio – „nelyginis“.*/

        }
    }
}
