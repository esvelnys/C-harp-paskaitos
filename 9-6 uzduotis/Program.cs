using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Išveskite 10 atsitiktinių skaičių, raskite jų sumą.

            Random rand = new Random();
            var kiekis = 0;
            var suma = 0;

            while (kiekis <= 10)

            {
                var skaicius = rand.Next(1,10);
                Console.Write(skaicius);

                if (skaicius >= 1 || skaicius <= 10)

                {
                    suma += skaicius;

                }
                Console.WriteLine();
                kiekis++;
            }
                Console.WriteLine("skaicius suma: " +suma);

                    
            } 

        
    }
}
