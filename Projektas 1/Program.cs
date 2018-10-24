using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var knygynas = new Knygynas("Pegasas", "Akropolis", new List<Knyga>
            {
                new Knyga ("Haris Poteris", "Rawling", 500, "vaikiska", 12.99, 30),
                new Knyga ("Dievu miskas", "B. Sruoga", 300, "romanas", 12.99, 12),
                new Knyga ("Alchemikas", "Cohelio", 00, "romanas", 14.99, 27),
                new Knyga ("Ronja plesiko dukte", "A. Lingren", 300, "romanas", 11.99, 6),
            });

            knygynas.Isvedimas();
        }
    }
}
