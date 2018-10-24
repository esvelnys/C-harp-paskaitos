using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ivveskite teigiama skaiciu");

            var kintamasis = Convert.ToInt32(Console.ReadLine());

            if (kintamasis > 0 && kintamasis%2 == 0)
            {
                Console.WriteLine("skaicius yra teigiamas ir yra lyginis");
            }
            else
            {
                Console.WriteLine("Skaicius nepatenka i salygas");
            }
            }
        }
    
}
