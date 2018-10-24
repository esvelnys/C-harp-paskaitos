using System;

namespace _3_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius1 = 4;
            var skaicius2 = 8;
            var suma = skaicius1 + skaicius2;
            var skirtumas = skaicius1 - skaicius2;

            Console.WriteLine(skaicius1+skaicius2);
            Console.WriteLine(skaicius1-skaicius2);
            Console.WriteLine(suma * skirtumas);
            Console.WriteLine(suma%skirtumas);

        }
    }
}
