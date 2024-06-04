using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Unos podataka od korisnika
            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("Unesite OIB: ");
            string oib = Console.ReadLine();

            Console.WriteLine("Unesite ulogu: ");
            string uloga = Console.ReadLine();

            Console.WriteLine("Unesite datum zaposlenja (YYYY-MM-DD): ");
            DateTime datumZaposlenja = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);

            // Kreiranje objekta klase Zaposlenik
            Zaposlenik zaposlenik = new Zaposlenik(ime, prezime, oib, uloga, datumZaposlenja);

            // Ispis podataka na konzolu
            zaposlenik.IspisiPodatke();
        }
    }
}
