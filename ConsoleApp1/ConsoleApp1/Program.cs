using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Czy chcesz rozpoczac rozgrywke?");
            Czeki czeki = new Czeki();
            int wrz = 0;
            while (czeki.czy == true)
            {
                Console.WriteLine("Tak - a \t Nie - b");
                string inp = Console.ReadLine();
                if (inp == "a")
                {
                    Console.WriteLine("Czy masz ukończone 5 lat?");
                    Console.WriteLine("Tak - a \t Nie - b");
                    string inp32 = Console.ReadLine();
                    if (inp32 == "a")
                    {
                        Console.WriteLine("Cieszy mnie to ze jestes gotowy na rozgrywke");
                        Console.WriteLine("Zaczynajmy");
                    }
                    else if (inp32 == "b")
                    {
                        Console.WriteLine("Dorosnij, albo idz po rodzica aby udzielil zgody na gre w ta gre");
                        break;
                    }
                }
                else if (inp == "b")
                {
                    Console.WriteLine("Jezeli sie juz zastanowisz to wroc i zagraj a narazie milego dnia");
                    break;
                }
                
                Console.WriteLine("---------------------------------------------------");
                Kolego.KolegaZWyborcem kolega = new Kolego.KolegaZWyborcem();
                Pies.Piesio pies = new Pies.Piesio();
                
                
                while(kolega.typ == "")
                {
                    kolega.WybierzZestaw();
                }
                while (pies.typ == "")
                {
                    pies.WybierzPsa();
                }
                kolega.WypiszKolege();
                pies.WypiszPsa();

                Console.WriteLine("Idziesz przez las z psem i kolegą. Spotykasz opuszczony dom. Wchodzisz do srodka?");
                Console.WriteLine("Tak - a \t Nie - b");
                string inp1 = Console.ReadLine();
                if (inp1 == "a")
                {
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Wchodzisz do srodka");
                }
                else if (inp1 == "b")
                {
                     czeki.czywsze = true;
                     czeki.czy = false;
                     break;
                }
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("przed domem ni z gruchy ni z pietruchy wyskakuje miejsce łaski");
                kolega.WypiszKolege();
                pies.WypiszPsa();
                Console.WriteLine("Co chcesz ulepszyć u kolegi: sila - siła \t wiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                string ul1 = Console.ReadLine();
                kolega.Zwieksz(ul1);
                Console.WriteLine("Co chcesz ulepszyć u psa: sila - siła \t wiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                string ul2 = Console.ReadLine();
                pies.ZwiekszPsa(ul2);
                Console.WriteLine("---------------------------------------------------");
                Starydziad starydziad = new Starydziad();
                Console.WriteLine("Wchodzisz a tu stary dziad, zaprasza cię do swego przybytku zamykając za sobą drzwi na klucz");
                Console.WriteLine("Za jego plecami dostrzegasz 10 kilogramów czystego piorunianu rtęci i kilka nieoznaczonych worków z podejrzanie wyglądającym szarym proszkiem");
                Console.WriteLine("Czy chcesz uciec? a - tak wszystko inne - nie");
                string uciek = Console.ReadLine();
                if (uciek == "a")
                {
                    czeki.czyzg = true;
                    czeki.czy = false;
                    break;
                    
                }
                else
                {
                    starydziad.WypiszDziad();
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Dziad mówi że jest zmeczony i idzie spać");
                    bool chodzenie = true;
                    while(chodzenie)
                    {
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("W domu sa 2 pomieszczenia. Do którego idziesz?");
                        Console.WriteLine("Salon - a \t Piwnica - b \t");
                        
                        
                        if (czeki.piwnica == false & czeki.salon == false)
                        {
                            chodzenie = false;
                            break;
                        }
                        string inp2 = Console.ReadLine();
                        if (inp2 == "a" & czeki.salon == true)
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Wchodzisz do Salonu");
                            Console.WriteLine("Kolejne miejsce łaski");
                            kolega.WypiszKolege();
                            pies.WypiszPsa();
                            Console.WriteLine("Co chcesz ulepszyć u kolegi: sila - siła\twiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                            string ul3 = Console.ReadLine();
                            kolega.Zwieksz(ul3);
                            Console.WriteLine("Co chcesz ulepszyć u psa: sila - siła\twiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                            string ul4 = Console.ReadLine();
                            pies.ZwiekszPsa(ul4);
                            Console.WriteLine("Podchodzicie do obrazka klauna który was wciąga");
                            Console.WriteLine("Trafiacie do labiryntu ");
                            bool lab = true;
                            while (lab)
                            {
                                Console.WriteLine("Wybierz kierunek gdzie chcesz iść");
                                Console.WriteLine("a - prawo,prawo,prawo,prawo b - lewo, lewo, lewo, lewo c - lewo prawo lewo prawo d- lewo lewo prawo prawo");
                                string inp5 = Console.ReadLine();
                                if (inp5 == "a")
                                {
                                    Thread.Sleep(10000);
                                    Console.WriteLine("Wyszedłeś");

                                    lab = false;
                                    break;
                                }
                                else
                                {
                                    Thread.Sleep(10000);
                                    Console.WriteLine("Niepoprawny wybór, spróbuj ponownie!");
                                }
                            }
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Kolejne miejsce łaski");
                            kolega.WypiszKolege();
                            pies.WypiszPsa();
                            Console.WriteLine("Co chcesz ulepszyć u kolegi: sila - siła \t wiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                            string ul5 = Console.ReadLine();
                            kolega.Zwieksz(ul5);
                            Console.WriteLine("Co chcesz ulepszyć u psa: sila - siła \t wiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                            string ul6 = Console.ReadLine();
                            pies.ZwiekszPsa(ul6);
                            czeki.salon = false;
                            Thread.Sleep(10000);
                        }
                        if (inp2 == "b" & czeki.piwnica == true)
                        {
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Wchodzisz do Piwnicy");
                            Console.WriteLine("Kolejne miejsce łaski");
                            kolega.WypiszKolege();
                            pies.WypiszPsa();
                            Console.WriteLine("Co chcesz ulepszyć u kolegi: sila - siła \t wiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                            string ul7 = Console.ReadLine();
                            kolega.Zwieksz(ul7);
                            Console.WriteLine("Co chcesz ulepszyć u psa: sila - siła \t wiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                            string ul8 = Console.ReadLine();
                            pies.ZwiekszPsa(ul8);
                            Console.WriteLine("Spotykasz tam 4m pająka");
                            while(czeki.piwni2 == true)
                            {
                                Console.WriteLine("W jaką grę jesteś mistrzem?");
                                Console.WriteLine("a - minecraft  b - *cenzura* c - roblox");
                                string inpaj = Console.ReadLine();
                                if (inpaj == "c")
                                {
                                    Thread.Sleep(10000);
                                    Console.WriteLine("rozwalił sie pajączek");
                                    czeki.piwni2 = false;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Jeszcze raz")
                            }
                            Console.WriteLine("---------------------------------------------------");
                            Console.WriteLine("Kolejne miejsce łaski");
                            kolega.WypiszKolege();
                            pies.WypiszPsa();
                            Console.WriteLine("Co chcesz ulepszyć u kolegi: sila - siła\twiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                            string ul9 = Console.ReadLine();
                            kolega.Zwieksz(ul9);
                            Console.WriteLine("Co chcesz ulepszyć u psa: sila - siła\twiara - wiara - - Pamiętaj jeżeli nie chcesz nic ulepszać to kliknij co innego");
                            string ul10 = Console.ReadLine();
                            pies.ZwiekszPsa(ul10);
                            czeki.piwnica = false;
                        }
                        
                        if (inp2 != "a" & inp2 != "b")
                        {
                            Console.WriteLine("Coś źle");
                        }



                    }
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Spotykacie znów dziada");
                    starydziad.WypiszDziad();
                    kolega.WypiszKolege();
                    pies.WypiszPsa();
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Co robicie?");
                    Console.WriteLine($"a - klepiecie typa\tb - próbujecie go przekonać by was póścił\tinne - czekacie na jego reakcję");
                    int silawspolna = pies.sila + kolega.sila;
                    int wiarawspolna = pies.wiara + kolega.wiara;
                    string endg = Console.ReadLine();
                    if (endg == "a")
                    {
                        if (silawspolna> starydziad.sila)
                        {
                            czeki.czyzab = true;
                            czeki.czy = false;
                             
                        }
                        else
                        {
                            czeki.czyzg = true;
                            czeki.czy = false;
                        }
                    }
                    if (endg == "b")
                    {
                        if (wiarawspolna > starydziad.kruchosc)
                        {
                            czeki.czywzr = true;
                            czeki.czy = false;

                        }
                        else
                        {
                            czeki.czyzg = true;
                            czeki.czy = false;
                        }
                    }
                    else
                    {
                        wrz++;
                        czeki.czy = false;

                    }














                }

                
                

            }
            Console.WriteLine("---------------------------------------------------");
            if (czeki.czywsze == true)
            {
                Console.WriteLine("Brawo przeszedłeś grę nic nie robiąc :)");
            }
            if (czeki.czyzg == true)
            {
                Console.WriteLine("Ded cieniasie");
            }
            
            if (czeki.czyzab == true)
            {
                Console.WriteLine("Zabiłeś Dziada");
            }
            if (czeki.czywzr == true)
            {
                Console.WriteLine("Dziad się wzruszył i was wypuścił");
            }
            
            
            if (wrz>0)
            {
                Console.WriteLine("Dziad sie wkurzył i nie wiadomo co z tobą");
            }
            Console.WriteLine("Koniec gry.");
            Thread.Sleep(3000);
            Process.Start(@"C:\Users\???\Desktop\ConsoleApp1\ConsoleApp1\minecraft.mp4");
            Console.ReadKey();
        }
    }
}
