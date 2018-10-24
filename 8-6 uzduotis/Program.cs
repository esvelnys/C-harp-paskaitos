using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_uzduotis
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

                if(i%2!=0 ||i%8==0)

            {
                Console.WriteLine("visi nelyginiai skaičiai arba tie, kurie dalinasi iš 8:" +" " + i );
            }
        }
    }
}
