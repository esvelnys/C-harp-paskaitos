using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pasirinkimo numeri");

            var skaicius = Convert.ToInt32(Console.ReadLine());
            switch (skaicius)

            {
                case 1:
                Console.WriteLine("Vanduo");
                break;

                case 2:
                    Console.WriteLine("Limonadas");
                    break;
                case 3:
                    Console.WriteLine("Arbata");
                    break;
                case 4:
                    Console.WriteLine("Kava");
                    break;
                default:
                    Console.WriteLine("Nera pasirinkimo");
                    break;
            }
        }
    }
}
