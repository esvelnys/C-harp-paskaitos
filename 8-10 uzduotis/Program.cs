using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 30;
            for (int i = 30; i <= 60; i++)
            {
                if (i % 3 == 0 || i ==1)
                {
                    suma += i;
                }
            }
                Console.WriteLine("visų nelyginių skaičių nuo 30 iki 60 suma: " + suma);
            }
        }
    }
