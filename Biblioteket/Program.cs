using Biblioteket;

class Program
{
    public static void Main()
    {
        Bibliotek biblo = new("Sønderborg bibliotek");
        bool running = true;
        while (running)
        {
            Console.Clear();
            switch (InputInt("Menu\n\n1: Vis bibloteks navn og dato\n2: Opret bruger\n3: Udskriv lånnere\n" +
                "4: Find låner\n5: Opret bog\n6: Vis alle bøgere\n7: Udlån bog\n8: Afslut\n\nValg: "))
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(biblo.HentBibliotek());
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(biblo.OpretLaaner(InputString("Navn: "), InputString("Email: ")));
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(biblo.HentAlleLaanere());
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine(biblo.FindLaaner(InputInt("Skriv låner id: ")));
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine(biblo.OpretBog(InputString("Bog Titel: "), 
                        InputString("Forfatter navn: "), InputString("Isbn nummer: ")));
                    Console.ReadKey();  
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine(biblo.HentAlleBogere());
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Clear();
                    if (biblo.HentAlleLaanere().Length > 30)
                    {
                        Console.WriteLine(biblo.HentAlleLaanere());
                        Person lanner = biblo.ValgPerson(InputInt("Vælg lånernummer: "));
                        if (biblo.HentAlleBogere().Length > 27)
                        {
                        Console.WriteLine(biblo.HentAlleBogere());
                        Bog bog = biblo.ValgBog(InputString("Skriv bog titel (husk stor bogstav): "));
                        Console.WriteLine(lanner.LaanBog(bog));
                        }
                        else
                            Console.WriteLine("Der er ingen bøger i systemet");                    
                    }
                    else
                        Console.WriteLine("Der er ingen lånnere oprettet i systemet");
                    Console.ReadKey();
                    break;
                case 8:
                    running = false;
                    break;
                case 11:
                    biblo.OpretBoger();
                    break;
                case 22:
                    biblo.OpretBruger();
                    break;
                default:
                    break;
            }
        }
    }
    /// <summary>
    /// Tager alle former for indput og stopper først når en int er intastet
    /// </summary>
    /// <param name="text"></param>
    /// <returns>Int</returns>
    static int InputInt(string text)
    {
        int value;
        while (true)
        {
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
    /// <summary>
    /// Tager imod alle former for indput og stopper først når der mindst en vædig intastet
    /// </summary>
    /// <param name="text"></param>
    /// <returns>string</returns>
    static string InputString(string text)
    {
        while (true)
        {
            Console.Write(text);
            string? indput = Console.ReadLine();
            if (indput.Length > 0)
                return indput;
        }

    }
}

