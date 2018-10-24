using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Raskite visų skaičių nuo 1 iki 10 sandaugą. Išveskite tik atsakymą, neišvedant pačių skaičių.

            var skaicius = 0;
            var sandauga = skaicius * skaicius;

            while (skaicius <= 10)
            {
                if (skaicius >= 1 || skaicius <= 0)

                    sandauga += skaicius;
                {
                    Console.WriteLine("skaiciu sandauga:'" + sandauga);
                }
            }
        }
    }
}
