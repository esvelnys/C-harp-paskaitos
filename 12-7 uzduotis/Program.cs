using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sukurkite ir užpildykite sąrašą su šimtu atsitiktinių skaičių.
             * Išveskite visus sugeneruotus skaičius, juos atskiriant tarpu. 
             * Raskite ir išveskite:
            Paskutinis skaičius.
Atsitiktinis skaičius.
Mažiausias skaičius.
Didžiausias skaičius.
Skaičių suma.
Skaičių vidurkis.
Lyginių skaičių kiekis.*/

            var rand = new Random();
            var skaiciai = new List<int>();
            var kiek = 100;
            

            for (int i=0; i<kiek; i++)
            {
                skaiciai.Add(rand.Next(100));
            }

            for (int i = 0; i < skaiciai.Count; i++)

            {
                Console.Write("{0} " , skaiciai[i]);
            }
            Console.WriteLine();
            Console.WriteLine("paskutinis skaicius: " + skaiciai.Last());
            Console.WriteLine("maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("didziausias skaicius: " + skaiciai.Max());
            Console.WriteLine("skaiciu suma: " + skaiciai.Sum());
            Console.WriteLine("vidurkis: " + skaiciai.Average());

            var kiekis = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {

                    kiekis= i;

                }
            }
            Console.WriteLine("Lyginiu skaiciu  kiekis :" + kiekis);
        }
    }
}
