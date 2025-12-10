
/* Hlavní program - začátek */

string again = "a";
while (again == "a")
{
    Console.Clear();

    // Metoda pro razítko - hlavičku
    razitko();

    // Načítání hodnot
    ulong a = nactiCislo("Zadejte číslo a: ");
    ulong b = nactiCislo("Zadejte číslo b: ");

    ulong NSD = spocitejNSD(a, b);
    Console.WriteLine();
    Console.WriteLine("==============================");
    Console.WriteLine("NSD čísel {0} a {1} je: {2}", a, b, NSD);
    Console.WriteLine("==============================");
    Console.WriteLine();

    ulong NSN = spocitejNSN(a, b, NSD);
    Console.WriteLine();
    Console.WriteLine("==============================");
    Console.WriteLine("NSN čísel {0} a {1} je: {2}", a, b, NSN);
    Console.WriteLine("==============================");
    Console.WriteLine();

    ZobrazitVysledky(a, b, NSD, NSN);



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();
}

/* Hlavní program - konec */

/* metoda která nic nevrací - nevrací hodnotu */
static void razitko()
{
    Console.WriteLine("****************************");
    Console.WriteLine("***** Výpočet NSD a NSN ****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Pavel Merta ********");
    Console.WriteLine("****************************");
    Console.WriteLine();
}    

/* metoda pro načtení čísel */
static ulong nactiCislo(string zprava)
{
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }

    // !!! Metoda, která vrací nějaký konkrétní datový typ, musí obsahovat následující řádek
    return cislo;
}

static ulong spocitejNSD(ulong a, ulong b)
{
    while (a != b)
    {
        if (a > b)
        {
            a = a - b;
        }
        else
        {
            b = b - a;
        }
    }

    return a;
}

static ulong spocitejNSN(ulong a, ulong b, ulong nsd)
{
    ulong nsn = (a * b) / nsd;
    return nsn;
}

static void ZobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn)
{
    Console.WriteLine("Výsledky výpočtu:");
    Console.WriteLine("----------------");
    Console.WriteLine("Zadaná čísla: a = {0}, b = {1}", a, b);
    Console.WriteLine("Největší společný dělitel (NSD): {0}", nsd);
    Console.WriteLine("Nejmenší společný násobek (NSN): {0}", nsn);
}