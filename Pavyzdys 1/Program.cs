using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavyzdys_1
{
    class Lektuvas

    {
        public string Pavadinimas;
        public int SparnuIlgis;
        public int Vietos;
        public string Klase;
        public int VarikliuSkaicius;
        public string VariklioTipas;

        public Lektuvas() { }
        
        public Lektuvas (int sparnuIlgis, string pavadinimas, int vietos, string klase,
            int varikliuSkaicius, string variklioTipas)
        {
            this.SparnuIlgis = sparnuIlgis;
            Pavadinimas = pavadinimas;
            Vietos = vietos;
            Klase = klase;
            VarikliuSkaicius = varikliuSkaicius;
            VariklioTipas = variklioTipas;
        }


        public void Isvedimas()

        {
            Console.WriteLine("Lektuvas {0} turi {1} vietu, jo sparnu ilgis yra {2} metru",
                Pavadinimas, Vietos, SparnuIlgis);

     

            Console.WriteLine("Jis priskiriamas {0} klasei, turi {1} tipo {2} variklius", Klase, VariklioTipas, VarikliuSkaicius);
       Console.WriteLine();
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                var lektuvas1 = new Lektuvas();
                var lektuvas2 = new Lektuvas();

                lektuvas1.Pavadinimas = "Boeying";
                lektuvas1.Vietos = 600;
                lektuvas1.Klase = "TarpAtlantinis";
                lektuvas1.SparnuIlgis = 500;
                lektuvas1.VariklioTipas = "Reaktyvinis";
                lektuvas1.VarikliuSkaicius = 4;

                lektuvas2.Pavadinimas = "Naikintuvas";
                lektuvas2.Vietos = 1;
                lektuvas2.Klase = "Karinis";
                lektuvas2.SparnuIlgis = 50;
                lektuvas2.VariklioTipas = "Turbo";
                lektuvas2.VarikliuSkaicius = 2;

                //Console.WriteLine(lektuvas1.Pavadinimas);
                //Console.WriteLine(lektuvas2.SparnuIlgis);
                //Console.WriteLine(lektuvas1.Klase);
                //Console.WriteLine(lektuvas2.VariklioTipas);

            lektuvas1.Isvedimas();
            lektuvas2.Isvedimas();



            var lektuvas3 = new Lektuvas(5, "F15", 2, "Naikintuvas", 2, "Reaktyvinis");
                lektuvas3.Isvedimas();
            }
        }
    }

