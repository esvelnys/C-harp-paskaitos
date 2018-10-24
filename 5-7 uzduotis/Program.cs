using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");

            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());

            if (skaicius1>skaicius2)
            {
                Console.WriteLine("pirmas skaičius didesnis už antra");
            }
            if(skaicius3 > skaicius1)
            {
                Console.WriteLine("trecias skaičius didesnis už pirma");
            }
            if (skaicius1 == skaicius2)
            {
                Console.WriteLine("du pirmi skaiciai lygus");
            }
            if (skaicius2==skaicius3)
            {
                Console.WriteLine("du paskutiniai skaiciai lygus");
            }
        }
    }
}
