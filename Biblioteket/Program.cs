using Biblioteket;

Bibliotek biblo = new ("Sønderborg bibliotek");
biblo.OpretLaaner(1, "Brian");
Console.WriteLine(biblo.HentBibliotek());
Console.WriteLine(biblo.HentLaaner(1));
