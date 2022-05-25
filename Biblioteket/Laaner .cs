using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Laaner
    {
        public int laanerNummer { get; init; }
        public string navn { get; init; }

        public Laaner(int laanerNummer, string laanerNavn)
        {
            this.laanerNummer = laanerNummer;
            this.navn = laanerNavn;
        }
    }
}
