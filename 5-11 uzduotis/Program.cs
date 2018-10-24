using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if(skaicius%7==0)
            {
                Console.WriteLine("Dalinasi is 7");
            }
            else
            {
                Console.WriteLine("Nesidalina is 7");
            }
        }
    }
}
