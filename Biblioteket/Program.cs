using Biblioteket;
Bibliotek biblo = new("Sønderborg bibliotek");
bool running = true;
while (running)
{
    switch (InputInt("Menu\n\n1: Vis bibloteks navn og dato\n2: Opret bruger\n3: Udskriv lånnere\n4: Afslut "))
    {
        case 1:
            Console.Clear();
            Console.WriteLine(biblo.HentBibliotek());
            Console.ReadKey();
            break;
        case 2:
            biblo.OpretLaaner(InputString("Navn: "), InputString("Email: "));
            break;
        case 3:
            Console.WriteLine(biblo.HentAlleLaanere());
            Console.ReadKey();
            break;
        case 4:
            running = false;
            break;
        default:
            break;
    }
}
static int InputInt(string text)
{
    int value;
    while (true)
    {
        Console.Clear();
        Console.Write(text);
        try
        {
            return value = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
static string InputString(string text)
{
    Console.Clear();
    Console.Write(text);
    return String.Format(Console.ReadLine());
}

