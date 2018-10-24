using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius");

            var skaicius = Convert.ToDouble(Console.ReadLine());
            var skaicius1 = Convert.ToDouble(Console.ReadLine());
            var skaicius2 = Convert.ToDouble(Console.ReadLine());

            var kvardatas = skaicius * skaicius;
            var kvardatas1 = skaicius1 * skaicius1;
            var kvardatas2 = skaicius2 * skaicius2;

            
            Console.WriteLine("Kvadratas"  + " "  + kvardatas);
            Console.WriteLine("Kvadratas"  + " "  + kvardatas1);
            Console.WriteLine("Kvadratas"  + " " + kvardatas2);

            var laipsnis = skaicius * skaicius * skaicius;
            var laipsnis1 = skaicius1 * skaicius1 * skaicius1;
            var laipsnis2 = skaicius2 * skaicius2 * skaicius2;

            Console.WriteLine("3 laipsnis" + " " + laipsnis);
            Console.WriteLine("3 laipsnis" + " " + laipsnis1);
            Console.WriteLine("3 laipsnis" + " " + laipsnis2);

            var suma_padalinta = laipsnis / 2;
            var suma_padalinta1 = laipsnis1 / 2;
            var suma_padalinta2 = laipsnis2 / 2;

            Console.WriteLine("Suma padalinta is 2" + " " + suma_padalinta);
            Console.WriteLine("Suma padalinta is 2" + " " + suma_padalinta1);
            Console.WriteLine("Suma padalinta is 2" + " " + suma_padalinta2);
        }
    }
}
