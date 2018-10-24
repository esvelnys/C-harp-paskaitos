using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite skaičių masyvą. Išveskite iš jų visus duomenis suformatuotai
             * (atskiriant kableliu, apskliaudžiant laužtiniais skliaustais ar pan.).*/

            var skaicius = new[] { 4, 6, 7, 10, 5, 6 };
            Console.Write("[" + skaicius [0] + "], ");
            Console.Write("[" + skaicius[1] + "], ");
            Console.Write("[" + skaicius[2] + "], ");
            Console.Write("[" + skaicius[3] + "], ");
            Console.Write("[" + skaicius[4] + "], ");
            Console.Write("[" + skaicius[5] + "], ");
        }
    }
}
