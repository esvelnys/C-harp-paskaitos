using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavyzdys_2
{
    class Instrumentai
    {

        public string Pavadinimas;
        public string Tipas;
        public int StyguSkaicius;
        public string Medziaga;
        public int GamybosMetai;
        public string Kokybe;

        public void Isvedimas()

        {
            Console.WriteLine("Muzikos instrumentas {0} , tipas {1}, stygu skaicius {2}," +
                " jinai pagaminta is {3}, pagaminta {4} m., yra {5} kokybes"
                , Pavadinimas, Tipas, StyguSkaicius, Medziaga, GamybosMetai, Kokybe);
           
        }

        class Program
        { 
        static void Main(string[] args)
        {
                var instrumentas = new Gitara();


        }
    }
}
