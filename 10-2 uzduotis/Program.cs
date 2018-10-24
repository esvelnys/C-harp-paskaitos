using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            var vardas = new[]
            

            {
            "Agne",
            "Tomas",
            "Paulius",
            "Darius",
            "Dovile",
        };
                       
            Console.WriteLine("Vardas: " + vardas[rand.Next(vardas.Length)]);
            
        }
    }
}
