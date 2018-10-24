using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Sukurkite sąrašą markių modeliams saugoti ir jį užpildykite duomenimis.
             * Išveskite visus modelius toje pačioje eilutėje, atskiriant kableliu.*/

            var modeliai = new List<string>();

            modeliai.Add("Audi A6");
            modeliai.Add("BMW 3");
            modeliai.Add("Ford Mondeo");
            modeliai.Add("MAzda 6");
            modeliai.Add("Opel Astra");
            modeliai.Add("Volvo V50");

            foreach (var modelis in modeliai)
            {
                Console.Write(modelis + " , ");
            }
            
        }
    }
}

