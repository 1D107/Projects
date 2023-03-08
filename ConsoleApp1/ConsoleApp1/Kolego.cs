using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kolego
    {
        public string typ;
        public int sila;
        public int wiara;
        // Konstruktor
        public Kolego()
        {
            typ = "";
            sila = 0;
            wiara = 0;
        }
        public class KolegaZWyborcem : Kolego
        {
            // Metoda umożliwiająca wybór zestawu wartości zmiennych
            public void WybierzZestaw()
            {
                Console.WriteLine("Wybierz kolegę: 1 - normik, 2 - hipsterek, 3 - emoś, 4 - *lepiej pozostać w niewiedzy*");
                int numer = int.Parse(Console.ReadLine());
                switch (numer)
                {
                    case 1:
                        typ = "normik";
                        sila = 5;
                        wiara = 5;
                        break;
                    case 2:
                        typ = "hipsterek";
                        sila = 2;
                        wiara = 10;
                        break;
                    case 3:
                        typ = "emoś";
                        sila = 3;
                        wiara = 6;
                        break;
                    case 4:
                        typ = "nie";
                        sila = 1;
                        wiara = 5;
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego zestawu!");
                        break;
                }
            }

            // Metoda zwiększająca wartość wybranej zmiennej o 1
            public void Zwieksz(string zmienna)
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
            // Metoda Wypisująca
            public void WypiszKolege()
            {
                Console.WriteLine($"Kolega - Typ {typ} Sila {sila} Wiara {wiara}");
            }
        }

    }
}
