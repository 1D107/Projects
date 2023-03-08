using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pies
    {
        public string typ;
        public int sila;
        public int wiara;

        public Pies()
        {
            typ = "";
            sila = 0;
            wiara = 0;
        }


        public class Piesio : Pies
        {
            public void WybierzPsa()
            {
                Console.WriteLine("Wybierz psiaka: 1 - kundel, 2 - pitbull zosia, 3 - parówa");
                int numer = int.Parse(Console.ReadLine());
                switch (numer)
                {
                    case 1:
                        typ = "kundel";
                        sila = 5;
                        wiara = 5;
                        break;
                    case 2:
                        typ = "pitbull";
                        sila = 10;
                        wiara = 3;
                        break;
                    case 3:
                        typ = "jamnik";
                        sila = 3;
                        wiara = 10;
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego zestawu!");
                        break;
                }
            }
            public void ZwiekszPsa(string zmienna)
            {
                switch (zmienna)
                {
                    case "sila":
                        sila += 1;
                        break;
                    case "wiara":
                        wiara += 1;
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej zmiennej!");
                        break;
                }
            }
            public void WypiszPsa()
            {
                Console.WriteLine($"Pies - Typ {typ} Sila {sila} Wiara {wiara}");
            }

        }
       
    }
}
