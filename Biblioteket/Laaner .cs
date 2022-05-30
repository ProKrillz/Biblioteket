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
