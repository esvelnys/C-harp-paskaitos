using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite kelis pazymius");
            var pazymys1 = Convert.ToInt32(Console.ReadLine());
            var pazymys2 = Convert.ToInt32(Console.ReadLine());
            var pazymys3 = Convert.ToInt32(Console.ReadLine());
            var pazymys4 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (pazymys1 + pazymys2 + pazymys3 + pazymys4) / 4;

            Console.WriteLine("Pazymiu vidurkis" + vidurkis);

            if (vidurkis>=5)
            {
               Console.WriteLine("Vidurkis teigiamas");
            }
            

            
        }
    }
}
