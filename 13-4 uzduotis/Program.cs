using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Sukurkite iš iškvieskite metodą, kuris paprašytų vartotojo įvesti savo vardą.
             * Po įvedimo, metodas turi pasisveikinti su vartotoju.*/



            string vardas = Console.ReadLine();
            vardas.pasisveikinti();
        }

        public void pasisveikinti();

            Console.WriteLine("Iveskite savo varda");
            var vardas = Console.ReadLine();

            Console.WriteLine("Labas!");
        }
    }
}
