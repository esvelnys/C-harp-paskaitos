using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Iveskite skaiciu");

            var skaicius= Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var daugiklis = 1;
            var laispnis5 = Math.Pow(skaicius, 5);
            var suma = skaicius + skaicius2
            var sandauga = skaicius * skaicius2;
            
            if (skaicius%5 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 5, daugybos lentele:");
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
                Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            }
            if (skaicius%2==0)
            {
                Console.WriteLine("Skaiciaus 5 laisnis : " + laispnis5);
            
            }
            if (skaicius%4!=0)
            {
                Console.WriteLine("Iveskite antra skaiciu: " + skaicius2);
                Console.WriteLine("Pirmo ir antro skaiciu suma:" + suma );
                Console.WriteLine("Pirmo ir antro skaiciu sandauga:" + sandauga);
            }
            
        }
    }
}
