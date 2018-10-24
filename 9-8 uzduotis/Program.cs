using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Nekeliant į atskiras eilutes, o atskiriant kableliu išveskite 100 atsitiktinių skaičių.
             Raskite visų jų sumą ir vidurkį.*/

            Random rand = new Random();
            var kiekis = 0;
            var suma = 0;
            var vidurkis = (kiekis + kiekis) / 2;
            

            while (kiekis <= 100)

            {
                var skaicius = rand.Next(1, 100);
                Console.Write(skaicius);

                if (skaicius >= 1 || skaicius <= 100)

                {
                    suma += skaicius;
                    vidurkis += kiekis;
                }
                Console.Write(",");
                kiekis++;
            }
            Console.WriteLine();
            Console.WriteLine("skaicius suma: " + suma);
            Console.WriteLine("Skaiciu vidurkis: " + vidurkis);
        }
    }
}
