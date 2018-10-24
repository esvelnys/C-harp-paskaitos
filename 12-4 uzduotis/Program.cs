using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sukurkite sąrašą skaičiams saugoti.
                Liepkite vartotojui įvesti 10 norimų skaičių į šį sąrašą.
                Išveskite įvestus skaičius toje pačioje eilutėje, atskiriant tarpu.*/

            Console.WriteLine("Iveskite 10 skaiciu: ");

            var skaiciai = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
            for (int i=0; i< skaiciai.Count; i++)

            {
                Console.Write(skaiciai[i] + " ");
            }
                                        

        }  
    }
}
