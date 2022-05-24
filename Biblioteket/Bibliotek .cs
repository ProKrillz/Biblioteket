using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    internal class Bibliotek
    {
        string _biblioteksNavn;

        public Bibliotek(string name)
        {
            _biblioteksNavn = name;
        }
        public string HentBibliotek()
        {
            return String.Format($"Velkommen til {_biblioteksNavn}\nDagens dato er: {DateTime.Today}");
        }
    }
}
