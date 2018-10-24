using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("+--------+---------+---------+-----+---------+---------+");
            Console.WriteLine("| Marke  | Modelis | Metai   |Turis|   Rida  | Apziura |");
            Console.WriteLine("+--------+---------+---------+-----+---------+---------+");

            var marke1 = "Audi";
            var modelis = "A4";
            var gamybos_metai = 2008;
            var turis = "2.0";
            var rida = 168000;
            var apziura = "true";

           

            Console.WriteLine("|{0,7} | {1,7} | {2,7} | {3} | {4,7} | {5,7} |", marke1, modelis, gamybos_metai, turis, rida, apziura);
            var marke2 = "ABMW";
            var modelis2 = "3";
            var gamybos_metai2 = 2009;
            var turis2 = "2.5";
            var rida2 = 288000;
            var apziura2 = "false";

            Console.WriteLine("+--------+---------+---------+-----+---------+---------+");
            Console.WriteLine("|{0,7} | {1,7} | {2,7} | {3} | {4,7} | {5,7} |", marke2, modelis2, gamybos_metai2, turis2, rida2, apziura2);

            /*Nuskaitykite iš konsolės duomenis apie du automobilius,
             kiekvieno automobilio duomenys: markė; modelis; gamybos metai;
             darbinis tūris; rida; ar yra galiojanti techninė apžiūra. 
             Iš pradžių nuskaitinėkite viską kas priklauso pirmąjam automobiliui, 
             tuomet - antrąjam. Visus nuskaitytus duomenis išveskite lentelėje. Pavyzdžiui:
             +-------+---------+---------------+-------------+---------+---------------+
            | Marke | Modelis | Gamybos metai | Darb. turis | Rida    | Techninė apž. |
             +-------+---------+---------------+-------------+---------+---------------+
            | pirm  | asdf	   | 2005          | 1.6         | 197240  | false         |
            +-------+---------+---------------+-------------+---------+---------------+
            | antr  | sgfdhfg | 2018          | 2.0         | 14974   | true          |
            +-------+---------+---------------+-------------+---------+---------------+*/


        }
    }
}
