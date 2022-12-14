using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int zycie = 10;
            int sila = 10;
            int maxzycie = 10;
            int pkt = 60;
            while (zycie>0)
            {
                Console.WriteLine("Co chcesz zrobić?");
                Console.WriteLine($"Twoje życie {zycie}\tTwoja sila {sila}\t Twoje punkty{pkt}\t max{maxzycie}");
                Console.WriteLine("a - walka \t b - ulepsz coś \t cokolwiek innego - wyjdź");
                string inpu = Console.ReadLine().ToString();
                if (inpu == "a")
                {
                    Random rnd = new Random();
                    int przh = rnd.Next(1,20);
                    Random rond = new Random();
                    int prza = rond.Next(1,20);
                    Console.WriteLine($"Przeciwnik ma {przh} życia i {prza} sily");
                    Console.WriteLine("1 - atakuj \t 2 - uciekaj");
                    int iny = int.Parse(Console.ReadLine());
                    if (iny == 1)
                    {
                        zycie -= prza;
                        przh -= sila;
                        Console.WriteLine($"Masz teraz {zycie} zdrowia a przeciwnik {przh}");
                        Console.WriteLine($"Twoje życie {zycie}\tTwoja sila {sila}\t Twoje punkty{pkt}");
                        if (przh<=0)
                        {
                            Console.WriteLine("Zabiłeś przeciwnika");
                            zycie = Postac.Reg(maxzycie, zycie);
                            Console.WriteLine($"Twoje życie {zycie}\tTwoja sila {sila}\t Twoje punkty{pkt}");
                            pkt++;
                        }
                        
                    }
                    else if (iny == 2)
                    {
                        Console.WriteLine("Uciekłeś tchórzu");
                    }
                    else
                    {
                        Console.WriteLine("nieprawidłowa komenda");
                    }
                }
                if (inpu == "b")
                {
                    Console.WriteLine("a - ulepsz atak \t b - ulepsz życie \t (za punkty)");
                    string inju = Console.ReadLine().ToString();
                    if (inju == "a")
                    {
                        sila = Postac.Ula(sila);
                        pkt -= 1;
                    }
                    if (inju == "b")
                    {
                        maxzycie = Postac.Ulz(maxzycie);
                        pkt -= 1;
                    }
                    zycie = Postac.Reg(maxzycie, zycie);
                }
                else
                {
                    Console.WriteLine("przerwano");
                    break;
                }
                
            }
            Console.WriteLine("Koniec gry");
            Console.ReadKey();
        }
    }
}
