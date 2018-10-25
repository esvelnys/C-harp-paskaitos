using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galutine_uzduotis
{
    public class zmogus
    {
        public string Vardas { get; set; } 
        public  int Amzius { get; set; }
        public string Profesija { get; set; }

        public zmogus (string vardas, int amzius, string profesija)
        {
            Vardas = vardas;
            Amzius = amzius;
            Profesija = profesija;
        }


    }
}
