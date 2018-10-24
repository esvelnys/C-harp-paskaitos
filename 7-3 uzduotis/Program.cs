using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
         /*Liepkite vartotojui įvesti tris skaičius.Tikrinkite pirmą skaičių:
Ar pirmas skaičius lygus 1? Jei taip, išvesti visų trijų skaičių sumą.
Ar pirmas skaičius lygus 2? Jei taip, išvesti antro ir trečio skaičių sandaugą.
Ar pirmas skaičius lygus 3? Jei taip, išvesti pirmo skaičiaus kvadratą.
Jei nei vienas variantas netinka, išveskite klaidos pranešimą.*/


        {
            Console.WriteLine("Iveskite tris skaicius");

            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());
            var suma = skaicius1 + skaicius2 + skaicius3;
            var sandauga = skaicius2*skaicius3;
            var kvadratas = skaicius1 * skaicius1;


            switch (skaicius1)

            {
                case 1:

                    Console.WriteLine("skaiciu suma: {0} + {1} + {2}  = {3} ", skaicius1, skaicius2, skaicius3, suma);
                    break;

                case 2:

                    Console.WriteLine("antro ir trecio skaiciu sandauga : ", + sandauga);
                    break;

                case 3:

                    Console.WriteLine("Pirmo skaiciaus kvardatas : " + kvadratas);
                    break;

                default:

                    Console.WriteLine("nera salygos");
                    break;
            }
        }
    }
}
