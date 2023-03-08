using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Starydziad
    {
      
        public int sila;
        public int kruchosc;
        public int wrz;
        public Starydziad()
        {
            sila = 19;
            kruchosc = 29;
            wrz = 0;
        }

        
        public void WypiszDziad()
        {
            Console.WriteLine($"Staty Dziada - Sila {sila} Kruchosc {kruchosc}");
        }

    }
}
