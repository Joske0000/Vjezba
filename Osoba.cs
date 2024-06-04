using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
 
   public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string OIB { get; set; }

        public Osoba(string ime, string prezime, string oib)
        {
            Ime = ime;
            Prezime = prezime;
            OIB = oib;
        }

  
        public void IspisiPodatke()
        {
            Console.WriteLine($"Ime: {Ime}");
            Console.WriteLine($"Prezime: {Prezime}");
            Console.WriteLine($"OIB: {OIB}");
        }

        public abstract int IzracunajRadniStaz();
    }
}
