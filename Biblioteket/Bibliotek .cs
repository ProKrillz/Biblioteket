using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Bibliotek
    {
        string _biblioteksNavn;
        List<Laaner> _laaners = new List<Laaner>();
        int _laanerNummer;

        public Bibliotek(string name)
        {
            _biblioteksNavn = name;
        }
        public string HentBibliotek()
        {
            return String.Format($"Velkommen til {_biblioteksNavn}\nDagens dato er: {DateTime.Today}");
        }
        public void OpretLaaner(string laanerNavn, string email)
        {
            Laaner laaner = new Laaner(++_laanerNummer, laanerNavn, email);
            _laaners.Add(laaner);
        }
        public string HentLaaner(int laanerNummer)
        {
            if (_laaners.Count > 0)
            {
                Laaner returnLaaner = _laaners.Find(x => x.laanerNummer == laanerNummer);
                return String.Format($"Lånernummer: {returnLaaner.laanerNummer}\nNavn: {returnLaaner.Name}\nEmail: {returnLaaner.Email}\nEr lånet hos: {_biblioteksNavn}");
            }
            else
                return "error";
        }
        public string HentAlleLaanere()
        {
            string laaners = "";
            if (_laaners.Count > 0)
            {
                foreach (var item in _laaners)
                    laaners += $"Lånernummer: {item.laanerNummer}\nNavn: {item.Name}\nEmail: {item.Email}\n\n";
                return laaners;
            }
            else
                return "Error: Ingen personer oprettet";
        }
    }
}
