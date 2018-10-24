using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Iveskite reziu pradzia: ");
            var pradzia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite reziu pabaiga: ");
            var pabaiga = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skaiciai patenkantys i rezius : [{0} - {1}]", pradzia, pabaiga);

            for (int i = pradzia; i <= pabaiga; i++)

            {
                Console.WriteLine(i + " "+ i*i);
            }
           
        }
    }
}

/*Liepkite vartotojui įvesti rėžių pradžią ir pabaigą.
Patikrinkite, kad tai būtų validu (pradžia turi būti mažesnė nei pabaiga).
Jei rėžiai tinkami, tuomet vykdyti for, kuris atskirose eilutėse išvestų
kiekvieną skaičių iš tų rėžių, bei atskiriant tarpu - tų skaičių kvadratus*/
