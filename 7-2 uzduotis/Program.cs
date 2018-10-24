using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite role");

            var role = Console.ReadLine();

            switch (role)

            {
                case "vartotojas":
                Console.WriteLine("Role yra vartotojas" );
                break;

                case "moderatorius":
                    Console.WriteLine("Role yra moderatorius");
                    break;

                case "administratorius":
                    Console.WriteLine("Role yra administratorius");
                        break;

                default:
                    Console.WriteLine("Klaida");
                    break;

            }
        }
    }
}
