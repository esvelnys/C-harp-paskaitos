using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_uzduotis
{
   /* Parašykite ir iškvieskite metodą, kuris per argumentų sąrašą
    * priimtų vardą, pavardę, amžių ir profesiją.Šis metodas, turi išvesti
    * sakinį panaudojant gautus žodžius.Metodą kvieskite du kartus, jam duodant
    * skirtingus duomenis.*/

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            var vardas = "Jonas";
            var pavarde = "Jonaitis";
            var amzius = 32;
            var profesija = "programuotojas";

            var vardas2 = "Saulius";
            var pavarde2 = "Jonaitis";
            var amzius2 = 34;
            var profesija2 = "dizaineris";

            p.Informacija(vardas, pavarde, amzius, profesija);
            p.Informacija(vardas2, pavarde2, amzius2, profesija2);

                }

        public void Informacija(string vardas, string pavarde, int amzius, string profesija)

        {
            Console.WriteLine(vardas + " " + pavarde + " " + amzius + " m. " + profesija + " ");
            
        }
                               

    }
}


