using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            if (skaicius1 > skaicius2 || skaicius1 == 0)
            {
                Console.WriteLine("pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0");
            }

            if ((skaicius2 > skaicius1 || skaicius2 == 5) || (skaicius2 > skaicius1 && skaicius2 > 100))
            {
                Console.WriteLine("antras skaičius yra didesnis už pirmąjį, arba yra lygus 5," +
                    " antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");
            }

            Console.WriteLine("antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100");


            if (skaicius1 > skaicius2 && skaicius1 == 20)

            {
                Console.WriteLine("pirmas skaičius yra didesnis už antrąjį ir yra lygus 20");
            }
        }

    }



}