﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_1
{
    class Knygynas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Knyga> Knygos { get; private set; }

        public Knygynas(string pavadinimas, string adresas, List<Knyga> knygos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Knygos = knygos;
        }
        public void Isvedimas()

        {
            Console.WriteLine("Knygyno pavadinimas: " + Pavadinimas);
            Console.WriteLine(" Jis randasi adresu: " + Adresas);
            Console.WriteLine("-----------");
            Console.WriteLine("Turimos knygos: ");
            Console.WriteLine("------------");
            foreach (var knyga in Knygos)
            {
                knyga.Isvedimas();
            }


            var brangiausia = BrangiausiaKnyga();
            brangiausia.Isvedimas();
            Console.WriteLine("----------------");
            Console.WriteLine("Brangiausia knyga");
            BrangiausiaKnyga().Isvedimas();
            Console.WriteLine("---------------");

        }
        public Knyga BrangiausiaKnyga()
        {
            var brangiausia = Knygos.First();

            foreach (var knyga in Knygos)
                if (knyga.Kaina > brangiausia.Kaina)

                {
                    brangiausia = knyga;
                }

            return brangiausia;

        }        
            

    }


          

    }

