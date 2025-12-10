
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