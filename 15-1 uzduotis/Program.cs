﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_uzduotis
{

    /*Parašykite metodą, kuris priimtų du skaičius ir grąžintų tą kuris yra didesnis iš jų,
     * o jei skaičiai lygūs – grąžintų bet kurį iš jų.*/

    class Program
    {
        static void Main(string[] args)
        {

            var p = new Program();
            var rand = new Random();

            var skaiciai = p.GeneruotiSkaicius(rand);

        }

        public List<int> GeneruotiSkaicius(Random rand)
        {
            var skaiciai = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                skaiciai.Add(rand.Next(100));
            }

            return skaiciai;
        }

        public void Isvedimas(List<int> skaiciai)

        {
            foreach (var i in skaiciai)

            {
                Console.Write(i + " ");

            }

            Console.WriteLine();
        }
    }
}

