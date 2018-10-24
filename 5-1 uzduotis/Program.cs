using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis

/*Liepkite vartotojui įvesti tris skaičius. Parašykite šias atskiras if sąlygas:
Ar pirmas ir antras skaičiai yra lygūs?
Ar antras ir trečias skaičiai yra lygūs?
Ar pirmas skaičius yra didesnis už antrąjį?
Ar antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę (trečias skaičius padaugintas iš 2)?
Ar pirmas skaičius yra lyginis (ar dalinasi iš 2)?
Ar antras skaičius yra nelyginis (ar nesidalina iš 2)?
Ar trečias skaičius yra teigiamas (didesnis už 0)?
Ar pirmas skaičius yra neigiamas (mažesnis už 0)?
Ar antras skaičius dalinasi iš 4?
Ar trečias skaičius dalinasi iš 8?*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 skaicius");

            var skaicius1 = Convert.ToInt32(Console.ReadLine());
            var skaicius2 = Convert.ToInt32(Console.ReadLine());
            var skaicius3 = Convert.ToInt32(Console.ReadLine());


            if (skaicius1 == skaicius2)

            {
                Console.WriteLine("pirmas ir antras skaicius yra lygūs");
            }

            if (skaicius2 == skaicius3)

            {
                Console.WriteLine("antras ir trecias skaicius yra lygūs");
            }
            if (skaicius1 > skaicius2)
            {
                Console.WriteLine("pirmas didesnis uz antra");
            }
            if (skaicius2>skaicius3*skaicius3)
            {
                Console.WriteLine("antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę");
            }
            if (skaicius1%2==0)
            {
                Console.WriteLine("pirmas skaičius yra lyginis");
            }
            if (skaicius2%2!=0)
            {
                Console.WriteLine("antras skaičius yra nelyginis");
            }
            if (skaicius3>0)
            {
                Console.WriteLine("trečias skaičius yra teigiamas");
            }
            if (skaicius1<0)
            {
                Console.WriteLine("pirmas skaičius yra neigiamas");
            }
            if (skaicius2 % 4==0)
            {
                Console.WriteLine("antras skaičius dalinasi iš 4");
            }
            if (skaicius3 % 8 ==0)
            {
                Console.WriteLine("trečias skaičius dalinasi iš 8");
            }
        }
        }
}
