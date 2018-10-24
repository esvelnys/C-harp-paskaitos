using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2.uzduotis
{
    class Program
    {

        /*Sukurkite ir iškvieskite metodą, kuriame kintamuosiuose
         * būtų saugoma informacija apie policininką (vardas, pavardė,
         * amžius, alga, etatas, specializacija). Išveskite šią informaciją
         * suformatuotai (pavyzdžiui: įterpkite į sakinį, ar išveskite atskirose
         * eilutėse ar pan.).*/


        static void Main(string[] args)

        {

            var p = new Program();
            p.isvedimas();
        }


        public void isvedimas()

        {
            var vardas = "Jonas";
            var pavarde = "Jonaitis";
            var amzius = 32;
            var alga = 600;
            var specializacija = "kriminalistas";

            Console.Write("Policininkas : {0} {1} ({2} m.) alga {3} Eur. {4}", vardas, pavarde, amzius, alga, specializacija );
            Console.WriteLine();
           
        }
                     
        
        }

}

