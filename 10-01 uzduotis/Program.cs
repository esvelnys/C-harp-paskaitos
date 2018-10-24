using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 1, 2, 3, 4, 5};
            Console.WriteLine("["+skaiciai[0]+"]");
            Console.WriteLine("[" + skaiciai[1] + "]");
            Console.WriteLine(skaiciai[2]);
            Console.WriteLine(skaiciai[3]);
            Console.WriteLine("[" + skaiciai[4] + "]");
        }
    }
}
