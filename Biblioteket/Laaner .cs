using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteket
{
    public class Laaner : Person
    {
        public int laanerNummer { get; init; }

        public Laaner(int laanerNummer, string laanerNavn, string email)
        {
            this.laanerNummer = laanerNummer;
            base.Name = laanerNavn;
            base.Email = email; 
        }
    }
}
