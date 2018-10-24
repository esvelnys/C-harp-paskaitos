using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxLenght = 5;

            var name = "Eimantas";
            if (name.Length > MaxLenght)
            name = name.Substring(0, MaxLenght);
            {
                Console.WriteLine("Vardas: " + name);
            }
                 
        }
    }
}
