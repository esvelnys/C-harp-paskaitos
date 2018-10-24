using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duomenys apie studenta :");

            var vardas = "Eimantas";
            var pavarde = "Švelnys";
            var grupe = "45B";
            var mokykla = "Mykolo Romerio Universitetas";
            
            Console.WriteLine("Studentas:" + vardas + " " + pavarde + " " + grupe + " " + mokykla);
            Console.WriteLine("Pazymiai :");

            var pazymys = Convert.ToInt32(Console.ReadLine());
            var pazymys2 = Convert.ToInt32(Console.ReadLine());
            var pazymys3 = Convert.ToInt32(Console.ReadLine());
            var vidurkis = (pazymys + pazymys2 + pazymys3) / 3;

            Console.WriteLine("Pazymiu vidurkis :" + vidurkis);


            /*Nuskaitykite iš konsolės šiuos duomenis apie studentą: vardas; pavardė; grupės kodas;
             * aukštosios mokyklos pavadinimas; norimą kiekį pažymių (pavyzdžiui 3 pažymius). 
             * Raskite vidurkį iš turimų pažymių. Visą informaciją norima forma išveskite ekrane.*/
        }
    }
}
