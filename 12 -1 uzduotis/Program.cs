using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12__1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Sukurkite sąrašą skaičiams saugoti ir jį užpildykite duomenimis.
             * Raskite ir išveskite mažiausią skaičių.*/

            var skaiciai = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Maziausias: " + skaiciai.Min());
        }
    }
}
