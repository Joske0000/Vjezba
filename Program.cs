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
          
            Console.WriteLine("Unesite ime: ");
            string ime = Console.ReadLine();

            Console.WriteLine("Unesite prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("Unesite OIB: ");
            string oib = Console.ReadLine();
            while (oib.Length != 11 || !oib.All(char.IsDigit))
                    {   
                    Console.WriteLine("Invalid OIB. OIB should be 11 digits. Please enter again:");
                    oib = Console.ReadLine();
                    }

            Console.WriteLine("Unesite ulogu: ");
            string uloga = Console.ReadLine();

            Console.WriteLine("Unesite datum zaposlenja dan-mjesec-godina: ");
            DateTime datumZaposlenja;
            while (!DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out datumZaposlenja))
            {
                Console.WriteLine("Invalid date format. Please enter again (dd-MM-yyyy):");
            }
           
            Zaposlenik zaposlenik = new Zaposlenik(ime, prezime, oib, uloga, datumZaposlenja);

            zaposlenik.IspisiPodatke();

            Console.ReadKey();
        }
    }
}
