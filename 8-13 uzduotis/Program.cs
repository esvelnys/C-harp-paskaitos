using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite kiek norite gauti skaicius:");
            var kiek = Convert.ToInt32(Console.ReadLine());

            var pirmas = 1;
            var antras = 1;
                int trecias;

            Console.WriteLine(pirmas);
            Console.WriteLine(antras);

            for (int i=2; i <kiek; i++)
            {
                trecias = pirmas + antras;
                pirmas = antras;
                antras = trecias;
                Console.WriteLine(trecias);

                
            }
        }
    }
}
