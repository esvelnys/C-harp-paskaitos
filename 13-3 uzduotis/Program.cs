using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3_uzduotis
{
    class Program
    {
        /*Sukurkite ir iškvieskite metodą, kuris išvestų norimus žodžius atskirose eilutėse, 
         * prieš kiekvieną žodį parašant brūkšnį. Pavyzdžiui:
- pirmas
- antras
-...
*/

        static void Main(string[] args)

        {

            var p = new Program();
            p.isvedimas();
        }


        public void isvedimas()

        {
            var zodis1 = "pirmas";
            var zodis2 = "antrass";
            var zodis3 = "trecias";
            var zodis4= "ketvirtas";
            var zodis5 = "penktas";

            Console.WriteLine("-" + zodis1);
            Console.WriteLine("-" + zodis2);
            Console.WriteLine("-" + zodis3);
            Console.WriteLine("-" + zodis4);
            Console.WriteLine("-" + zodis5);


        }
    }
}
