using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite tris skaičių masyvus.
             * Iš kiekvieno masyvo atrinkite po vieną atsitiktinį skaičių. 
             * Raskite kuris iš šių skaičių yra didžiausias.*/

            var skaiciai1 = new[] { 4, 6, 7, 10, 5, 6 };
            var skaiciai2 = new[] { 4, 6, 7, 8, 9, 0 };
            var skaiciai3 = new[] { 5, 6, 7, 3, 5, 2,};
            var rand = new Random();

            var skaicius1 = skaiciai1[rand.Next(skaiciai1.Length)];
            var skaicius2 = skaiciai2[rand.Next(skaiciai1.Length)];
            var skaicius3 = skaiciai3[rand.Next(skaiciai1.Length)];


            if (skaicius1 > skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("Didziausias: " + skaicius1);
            }

            if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine("Didziausias: " + skaicius2);
            }
            if (skaicius3 > skaicius2 && skaicius3 > skaicius1)

                Console.WriteLine("Didziausias: " + skaicius3);

        }
    }
}
