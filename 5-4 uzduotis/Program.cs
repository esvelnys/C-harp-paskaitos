using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite  skaciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var kvadratas = (skaicius * skaicius) / 2;
            var daugiklis = 1;

            var suma = skaicius + skaicius2;
            var sandauga = skaicius * skaicius2;

            if (skaicius % 5 == 0)

            {
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            }
                if (skaicius%2==0)
                {
                    Console.WriteLine("skaičiaus kvadratas padalintas iš 2: " + kvadratas);
                }

            if (skaicius%7!=0)

            {
                Console.WriteLine("Susikurkite kintamaji:" +skaicius2);

                /*Console.WriteLine("skaičiu suma: {0} + {1} = {5}", skaicius, skaicius2, suma);
                Console.WriteLine("skaiciu sandauga:{0} * {1} = {6}", skaicius, skaicius2, sandauga);*/
            }
                    
               
            }
        }
    }

