using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Irasykite skaiciu:");

            var skaicius = Convert.ToInt32(Console.ReadLine());
            

            if ((skaicius> 0 && skaicius<100) || skaicius%2==0)
            {
                Console.WriteLine("Skaicius patenka i [0-100] arba dalinasi is 2");
            }
            if (skaicius > 0 && (skaicius < 100 || skaicius % 2 == 0))

            {
                Console.WriteLine("Skaicius mazesnis uz 100 arba lyginis arba teigiamas");
            }
        }
    }
}
