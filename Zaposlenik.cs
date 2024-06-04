using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
    public class Zaposlenik : Osoba
    {
        public string Uloga { get; set; }
        public DateTime DatumZaposlenja { get; set; }

        public Zaposlenik(string ime, string prezime, string oib, string uloga, DateTime datumZaposlenja) : base(ime, prezime, oib)
        {
            Uloga = uloga;
            DatumZaposlenja = datumZaposlenja;
        }

        public override int IzracunajRadniStaz()
        {
            TimeSpan radniStaz = DateTime.Now - DatumZaposlenja;
            double totalDays = radniStaz.TotalDays;
            int years = (int)Math.Floor(totalDays / 365.2425); 

            return years;
        }

        public override void IspisiPodatke()
        {
            base.IspisiPodatke(); 
            Console.WriteLine($"Uloga: {Uloga}");
            Console.WriteLine($"Datum zaposlenja: {DatumZaposlenja.ToShortDateString()}");
            Console.WriteLine($"Radni staž: {IzracunajRadniStaz()} godina");
        }
    }

}
