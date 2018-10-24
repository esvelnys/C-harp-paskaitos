using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");

            var skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius >= 0)
            {
                Console.WriteLine("Sveikinimai!!!");
            }
            else 
            {
                Console.WriteLine("Blogai!!!");   
            }
        }
    }
}
