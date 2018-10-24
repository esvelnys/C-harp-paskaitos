using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Liepkite vartotojui pasirinkti kiek studento pažymių nori suvesti į sąrašą. 
             * Tegul jis užpildo šį sąrašą duomenimis, įvedant juos per konsolę. Raskite:
didžiausią pažymį;
mažiausią pažymį;
vidurkį;
išveskite atsitiktinį skaičių iš šio sąrašo.
kiek dešimtukų yra gavęs studentas;
kiek neigiamų pažymių (žemiau nei 4) yra gavęs studentas;*/


            Console.WriteLine("Kiek dpazymiu norite suvesti ?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            var skaiciai = new List<int>[kiek];

            var suma = 0;

            for (int i = 0; i < skaiciai.Length; i++)

            {
                Console.Write("Pazymys {0} : ", i + 1);
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
