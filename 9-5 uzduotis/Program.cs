using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_uzduotis
{
    class Program
    {

        /*Iš skaičių nuo 1 iki 100, raskite visų lyginių ir visų nelyginių skaičių sumas.
         * Naudokite tą patį ciklą abiems šiems veiksmams.*/


        static void Main(string[] args)
        {
            var skaicius = 1;
            var suma = 1;
            while (skaicius < 100)

            {
                skaicius++;

                if (skaicius % 2 == 0)

                {
                    suma += skaicius;
                    Console.Write(skaicius);
                }
                Console.WriteLine();
                suma++;

                
                    {
                        Console.WriteLine("Lyginiu skaiciu suma: " + suma);
                    }
                
                  
                    else if (skaicius == 1 || skaicius % 3 == 0) ;
                {
                    Console.WriteLine("Lyginiu skaiciu suma: " + suma);
                    
                }
            }
        }
    }
}




    



