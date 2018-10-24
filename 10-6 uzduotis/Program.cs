using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Susikurkite medžių pavadinimų masyvą.
             * Išveskite visus medžių pavadinimus kaip sąrašą.
             * Pavyzdžiui:
                - liepa
                - obelis
                - …*/

            var medziai = new[]
            {
                "Kriause",
                "Obelis",
                "Slyva",
                "Liepa",
                "Egle"
            };

            Console.WriteLine("-" + medziai[0]);
            Console.WriteLine("-" + medziai[1]);
            Console.WriteLine("-" + medziai[2]);
            Console.WriteLine("-" + medziai[3]);
            Console.WriteLine("-" + medziai[4]);
        }
    }
}
