using Biblioteket;

Bibliotek biblo = new ("Sønderborg bibliotek");
biblo.OpretLaaner(1, "Brian");
biblo.OpretLaaner(2, "Nikolai");
biblo.OpretLaaner(3, "Adrian");
Console.WriteLine(biblo.HentBibliotek());
Console.WriteLine(biblo.HentLaaner(1));
Console.WriteLine(biblo.HentAlleLaanere());
