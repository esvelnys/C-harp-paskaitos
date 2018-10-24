using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Kiek dienų temperatūrų  norite suvesti ?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            var skaiciai = new int[kiek];
            var suma = 0;
            var min = skaiciai[0];
            var max = skaiciai[0];
            
                        
            
            for (int i = 0; i < skaiciai.Length; i++)

            {
                Console.Write("Iveskite {0} temperatura: ", i + 1);
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                                              
            }

            foreach (var sk in skaiciai)

            {
                suma += sk;
            }

            var vidurkis = suma / skaiciai.Length;
            Console.WriteLine("Temperatūros vidurkis: " + vidurkis);
            Console.WriteLine();
            
            foreach (var sk in skaiciai)
            {
                if (sk < min)
                {
                    min = sk;
                }
            }

            Console.WriteLine("Zemiausia temperatura: " + min);
            Console.WriteLine();

            foreach (var sk in skaiciai)
            {
                if (sk > max)
                {
                    max = sk;
                }
            }
                       
            Console.WriteLine("Kuria diena buvo auksciausia temperatura? " + " " + "diena" + " " + max);
            Console.WriteLine();

            

        }
        }
    }


/*Sukurkite programą ir įdėkite į žemiau esantį laukelį kodą.
Programos tikslas:
- Sukurti ir užpildyti duomenimis masyvą arba sąrašą. Atlikti reikiamus skaičiavimus. Bei išvesti gautus rezultatus.

Reikalavimai:
- Nenaudoti "greitųjų" radimo funkcijų. Tokių kaip .Min(), .Max()., Sum(), .Average() ar pan.

Įgyvendinkite šį funkcionalumą:
- Sukurkite masyvą arba sąrašą, kuriame saugotumėte dienų temperatūrų duomenis.
- Liepkite vartotojui suvesti norimą kiekį duomenų į sukurtą masyvą arba sąrašą. 
Programos pradžioje paklauskite kiek dienų temperatūrų jis nori suvesti, tuomet
įvedinėjant išveskite kelintą reikšmę jis įvedinėja ir leiskite įvesti.
- Išveskite temperatūrų duomenis, kiekvieną skaičių atskiriant kableliu, toje pačioje eilutėje.
- Raskite ir išveskite ekrane šiuos atsakymus:
-- Koks yra suvestų temperatūrų vidurkis?
-- Kokia temperatūra yra žemiausia?
-- Kurią dieną buvo aukščiausia temperatūra? Pavyzdžiui: "5-a dieną buvo aukščiausia temperatūra,
kuri siekė 32 laipsnius".
-- Kiek dienų temperatūra buvo žemesnė nei bendras visų dienų temperatūrų vidurkis?
-- Pirmą ar paskutinę dieną temperatūra buvo aukštesnė ir koks skirtumas tarp jų?
- Atrinkite į naują masyvą ar sąrašą tas temperatūras, kurios yra nutolusios nuo 
vidurkio tik per vieną padalą (tarkim vidurkis buvo 20, tai atrinkti temperatūras,
kurios pateko tarp [19-21]). Šį masyvą ar sąrašą išvesti ekrane.*/
