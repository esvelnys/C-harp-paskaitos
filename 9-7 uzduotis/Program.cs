using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            //Išvedinėkite visus skaičius nuo 1 iki tol kol pasitaikys skaičius, kuris dalinasi iš 3 ir iš 5.

            Console.WriteLine("Išvedinėkite visus skaičius nuo 1 iki tol kol pasitaikys skaičius, kuris dalinasi iš 3 ir iš 5");
            var skaicius = 1;

            while (true)
            {
                if (skaicius % 3 == 0 && skaicius % 5 == 0) 
                {
                    break;
                }
                Console.WriteLine(skaicius);
                skaicius++;



            }
        }
    }
}

