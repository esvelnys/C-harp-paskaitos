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
            var knygynas = new Knygynas("Vaga", "PC SAVAS, Savanorių pr. 346, Kaunas", new List<Knyga>
            {
                new Knyga ("Haris Poteris ir prakeiktas vaikas", "J. K. Rowling", 336, "Romanas", 12.99, 10.73, 30),
                new Knyga ("Dievų miskas", "B. Sruoga", 448, "Romanas", 12.99, 10.73, 12),
                new Knyga ("Alchemikas", "Paulo Coelho", 168, "Romanas", 14.99, 12.38, 27),
                new Knyga ("Ronja plėšiko duktė", "Astrid Lindgren", 167, "Romanas", 11.99, 9.90, 6),
                new Knyga ("Prieskoninių augalų ir jų vartojimo žinynas" , "K.Obelevičius, S.Petkevičiūtė, E.Šeinauskienė" , 120, "Enciklopedija" ,  10.99, 9.08, 10),
                new Knyga ("Žemė 9. Geografijos vadovėlis 9 kl., I d.", "R. Šalna, E. Baleišis, R. Baubinas, V. Daugirdas" , 45, "Vadovėlis", 8.99, 7.43 , 12),
                new Knyga ("LIETUVA. Fotoalbumas" , "Danguolė Kandrotienė", 84, "Fotoalbumas" , 7.18, 5.93 , 20),
            });

            knygynas.Isvedimas();
        }
    }
}
