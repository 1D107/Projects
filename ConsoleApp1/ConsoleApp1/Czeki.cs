using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Czeki
    {
        public bool czy;
        public bool czywsze;
        public bool czyzg;
        public bool czyzab;
        public bool czywzr;
        public bool lab;
        public bool piwni2;
        public bool piwnica;
        public bool salon;

        public Czeki()
        {
            czy = true;
            czywsze = false;
            czyzg = false;
            czyzab = false;
            czywzr = false;
            lab = false;
            piwnica = true;
            salon = true;
        }
        public void WypiszCzeki()
        {
            Console.WriteLine( $"{czy} {czywsze} {czyzg} {czyzab} {czywzr} {czyzes} {lab} ");
        }
    }
}
