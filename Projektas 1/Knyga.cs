using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_1
{
    class Knyga
    {
        public string Pavadinimas { get; private set; }
        public string Autorius { get; private set; }
        public int Puslapiai { get; private set; }
        public string Zanras { get; private set; }
        public double Kaina { get; private set; }
        public double Savikaina { get; private set; }
        public int Kiekis { get; private set; }


        public Knyga (string pavadinimas, string autorius, int puslapiai, string zanras, double kaina, double savikaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Puslapiai = puslapiai;
            Zanras = zanras;
            Kaina = kaina;
            Savikaina = savikaina;
            Kiekis = kiekis;
            

        }

        public void Isvedimas()

        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Autorius: " + Autorius);
            Console.WriteLine("Puslapiu skaicius: " + Puslapiai);
            Console.WriteLine("Zanras: " + Zanras);
            Console.WriteLine("Kaina: " + Kaina + " eur.");
            Console.WriteLine("Savikaina: " + Savikaina + " eur.");
            Console.WriteLine("Yra sios knygos vienetu: " + Kiekis);
            Console.WriteLine("Pardavus visus vienetus gautusi {0} eur bendro galimo pelno", Apyvarta());
            Console.WriteLine();

        }
        public double Apyvarta()
        {
            return (Kiekis * (Kaina - Savikaina));
        }
               
    }
}
