using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki skaiciu");

            var skaicius = Convert.ToDouble(Console.ReadLine());

            var daugiklis = 1;
           

            Console.WriteLine("{0}*{1}= {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0}*{1}= {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0}*{1}= {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0}*{1}= {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0}*{1}= {2}", skaicius, daugiklis, skaicius * daugiklis++);
        }
    }
}
