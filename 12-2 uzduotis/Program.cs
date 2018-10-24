using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sukurkite sąrašą vardams saugoti ir jį užpildykite duomenimis.
              Išveskite pirmą ir antrą vardus.*/

            var vardai = new List<string>();

            vardai.Add("Rasa");
            vardai.Add("Dalius");
            vardai.Add("Asta");
            vardai.Add("Birute");
            vardai.Add("Vladas");

            Console.WriteLine(vardai.First());
            Console.WriteLine(vardai.Last());
        }
    }
}
