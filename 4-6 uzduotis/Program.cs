using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Irasykite sveikaji skaiciu");

        var sveikasis_skaicius = Convert.ToInt32(Console.ReadLine());
        var kvardatas = sveikasis_skaicius * sveikasis_skaicius;

        Console.WriteLine("sveikojo skaiciaus kvardatas " + kvardatas);
        


        }
    }
}
