using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_uzduotis

/*Parašykite ir iškvieskite metodą, kuris per argumentų sąrašą priimtų norimą žodį. 
        * Metodas gautą žodį turi išvesti jį apskliaudžiant dviem brūkšniukais iš kiekvieno šono
        * (pavyzdžiui: -- pomidoras --). 
        * Šį metodą kvieskite 5 kartus, kiekvieną kartą metodui duodant vis kitokį žodį.*/
{
    class Program
    {


        static void Main(string[] args)

        {

            var p = new Program();

            p.zodis("pomidoras");
            p.zodis("kriause");
            p.zodis("slyva");
            p.zodis("obuolys");
            p.zodis("vysnia");

        }

        public void zodis (string vaisiai)
        {
            Console.WriteLine("--" + vaisiai + "--");
           
        }

    }
}

