using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite du vardų masyvus. 
            Išveskite pirmojo masyvo pirmąjį vardą ir antrojo masyvo paskutinį vardą.*/


            var vardai1 = new[]


            {
            "Agne",
            "Tomas",
            "Paulius",
            "Darius",
            "Dovile",
            "Agnius",
            "Linas",
            "Povilas",
            "Dalius",
            "Justas",

        };
            Console.WriteLine(vardai1[0]);

            var vardai2 = new[]

            {
            "Justas",
            "Dalius",
            "Asta",
            "Vladas",
            "Rasa",
            "Birute",
            };

            Console.WriteLine(vardai2[5]);

        }
    }
}
