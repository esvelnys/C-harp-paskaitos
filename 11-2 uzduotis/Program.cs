using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite du skaičių masyvus. Raskite kiekvieno iš jų skaičių sumas. 
             * Palyginkite, kurio masyvo skaičių suma yra didesnė. 
             * Nenaudokite sumos ieškojimo funkcijos (Sum()).*/

            var skaiciai1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var skaiciai2 = new[] { 8, 7, 6, 5, 4, 3, 2, 1 };

            var suma1 = 0;
            variable suma3 = 1;
            var suma2 = 0;
            foreach (var sk1 in skaiciai1);

            

            {
                suma1 += sk1;
                suma2 += sk2;
            }

            Console.WriteLine("Suma: " + suma1);
            Console.WriteLine("Suma: " + suma2);
        }
    }
}
