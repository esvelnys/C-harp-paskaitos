using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Darbuotojas");

           var darbuotojas = "Eimantas";
            var gimimo_metai = 1986;
            var specialybe = "teisininkas";
            var etatas = 0.15;
            var alga = 800;
            Console.WriteLine("Darbuotojas :" +  " " + darbuotojas +" "  + (2018 -gimimo_metai) + " " + specialybe +" "+  etatas + " " +" "
                + alga);



            /*Nuskaitykite iš konsolės šiuos duomenis apie darbuotoją: vardas; pavardė;
             * gimimo metai; specialybė; etatas(nuo 0 iki 1); gaunama alga. 
             * Iš turimų gimimo metų paskaičiuokite koks darbuotojo amžius. 
             * Išveskite visą šią informaciją ekrane sakinio pavidalu.Pavyzdžiui:
                Algis Algiausias(52 m.) dirba policininku 0.5 etatu ir uždirba 500 eur / mėn.*/




        }
    }
}
