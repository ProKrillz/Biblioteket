namespace Biblioteket
{
    public class Bibliotek
    {
        string _biblioteksNavn;
        List<Laaner> _laaners;
        List<Bog> _boger;
        int _laanerNummer;

        public Bibliotek(string name)
        {
            _biblioteksNavn = name;
            _laaners = new List<Laaner>();
            _boger = new List<Bog>();
        }
        /// <summary>
        /// Finder bibloteksnavn og dagsdato
        /// </summary>
        /// <returns>string</returns>
        public string HentBibliotek()
        {
            return String.Format($"Velkommen til {_biblioteksNavn}\nDagens dato er: {DateOnly.FromDateTime(DateTime.Today)}");
        }
        /// <summary>
        /// Opretter lånner
        /// </summary>
        /// <param name="laanerNavn"></param>
        /// <param name="email"></param>
        /// <returns>string</returns>
        public string OpretLaaner(string laanerNavn, string email)
        {
            Laaner laaner = new Laaner(++_laanerNummer, laanerNavn, email);
            _laaners.Add(laaner);
            return String.Format($"\nLåner oprettet\nLånernummer: {laaner.laanerNummer}\nNavn: {laaner.Name}\nEmail: {laaner.Email}");
        }
        public string HentLaaner(int laanerNummer)
        {
            if (_laaners.Count > 0)
            {
                Laaner? returnLaaner = _laaners.Find(x => x.laanerNummer == laanerNummer);
                if (returnLaaner != null) 
                    return String.Format($"Lånernummer: {returnLaaner.laanerNummer}\nNavn: {returnLaaner.Name}\n" +
                        $"Email: {returnLaaner.Email}\nEr lånet hos: {_biblioteksNavn}");
                return "Ingen Bruger fundet";
            }
            else
                return "Der er ikke oprettet nogle bruger i systemet";
        }
        /// <summary>
        /// Finder oplysninger om alle lånere og de bøger de har lånt vis de har lånt
        /// </summary>
        /// <returns>string</returns>
        public string HentAlleLaanere()
        {
            string laaners = "";
            if (_laaners.Count > 0)
            {
                foreach (var item in _laaners)
                {
                    laaners += $"Lånernummer: {item.laanerNummer}\nNavn: {item.Name}\nEmail: {item.Email}\n\n";
                    if (item.Boger.Count > 0)
                    {
                        foreach (var item1 in item.Boger)
                            laaners += $"Bog lånt\nTitel: {item1.Titel}\nForfatter: {item1.Forfatter}\nIsbn nummer: {item1.IsbnNummer}\nUdlåns dato: {item1.Udlaansdato}\n\n";
                    }
                }
                return laaners;
            }
            else
                return "Error: Ingen personer oprettet";
        }
        /// <summary>
        /// Finder bruger med lånenummer og bøger de har lånt vis der er lånt nogle
        /// </summary>
        /// <param name="laanerNummer"></param>
        /// <returns>string</returns>
        public string FindLaaner(int laanerNummer)
        {
            if (_laaners.Count > 0)
            {
                Laaner? returnLaaner = _laaners.Find(x => x.laanerNummer == laanerNummer);
                if (returnLaaner != null)
                {
                    string returnTekst = $"Lånernummer: {returnLaaner.laanerNummer}\nNavn: {returnLaaner.Name}\n" +
                        $"Email: {returnLaaner.Email}\n";
                    if (returnLaaner.Boger.Count > 0)
                    {
                        foreach (var item in returnLaaner.Boger)
                        {
                            returnTekst += $"\nLånt bøger\nTitel: {item.Titel}\nForfatter: {item.Forfatter}\nIsbn nummer: {item.IsbnNummer}\nUdlåns dato: {item.Udlaansdato}";
                        }
                    }
                    return returnTekst;

                }
                return $"\nIngen bruger fundet med lånenummer {laanerNummer}";
            }
            else
                return "Der er ikke oprettet nogle bruger i systemet";
        }
        /// <summary>
        /// Dette er til at oprette hurtig bøger til fremvisning 
        /// </summary>
        public void OpretBoger()
        {
            _boger.Add(new Bog
            {
                Titel = "De blå bæster",
                Forfatter = "R.L Stine",
                IsbnNummer = "8721018707"
            });
            _boger.Add(new Bog
            {
                Titel = "Bogen om C# 9.0",
                Forfatter = "Michell Cronberg",
                IsbnNummer = "9788799338238"
            });
        }
        /// <summary>
        /// Dette er til at oprette hurtig bruger til fremvisning
        /// </summary>
        public void OpretBruger()
        {
            Laaner laaner1 = new(++_laanerNummer, "Daian", "Daiansmail@gmail.dk");
            _laaners.Add(laaner1);
            Laaner laaner2 = new(++_laanerNummer, "Brian O Cornor", "Fast@mail4u.com");
            _laaners.Add(laaner2);
        }
        /// <summary>
        /// Opretter en bruger
        /// </summary>
        /// <param name="titel"></param>
        /// <param name="forfatter"></param>
        /// <param name="isbnNummer"></param>
        /// <returns>string</returns>
        public string OpretBog(string titel, string forfatter, string isbnNummer)
        {
            _boger.Add(new Bog
            {
                Titel = titel,
                Forfatter = forfatter,
                IsbnNummer = isbnNummer
            });
            
            return "Bog oprettet";
        }
        /// <summary>
        /// Finder alle bøger i List _boger
        /// </summary>
        /// <returns>string</returns>
        public string HentAlleBogere()
        {
            string boger = "";
            if (_boger.Count > 0)
            {
                foreach (var item in _boger)
                    boger += $"Lånernummer: {item.Titel}\nNavn: {item.Forfatter}\nIsbn nummer: {item.IsbnNummer}\n\n";
                return boger;
            }
            else
                return "Error: Ingen bøger oprettet";
        }
        /// <summary>
        /// Finder person ud fra lånernummer
        /// </summary>
        /// <param name="laanerNummer"></param>
        /// <returns>Person objekt</returns>
        public Person ValgPerson(int laanerNummer)
        {
            
            if (_laaners.Count > 0)
            {
                Laaner? returnLaaner = _laaners.Find(x => x.laanerNummer == laanerNummer);
                if (returnLaaner != null)
                    return returnLaaner;
                return null;
            }
            else
                return null;
        }
        /// <summary>
        /// Finder bog info ud fra bog titel
        /// </summary>
        /// <param name="bogTitel"></param>
        /// <returns>Bog objekt</returns>
        public Bog ValgBog(string bogTitel)
        {
            if (_boger.Count > 0)
            {
                Bog? returnBog = _boger.Find(x => x.Titel == bogTitel);
                if (returnBog != null)
                    return returnBog;
                return null;
            }
            return null;
        }
    }
}
