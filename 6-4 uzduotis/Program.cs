using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ivveskite tris skaicius");

            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1>skaicius2 && skaicius1 > skaicius3)
            {
                Console.WriteLine("pirmas skaicius didziausias");
            }
            if (skaicius2 > skaicius1 && skaicius2 > skaicius3)
            {
                Console.WriteLine("antras skaicius didziausias");
            }
            if (skaicius3 > skaicius2 && skaicius3 > skaicius1)
            {
                Console.WriteLine("trecias skaicius didziausias");
            }
        }
    }
}
