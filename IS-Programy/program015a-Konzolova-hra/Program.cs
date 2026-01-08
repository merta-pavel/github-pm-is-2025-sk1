using System;

class Program
{
    static void Main()
    {
        // Pole možností pro hru
        // Index 0 = kámen, 1 = nůžky, 2 = papír
        string[] moznosti = { "kamen", "nuzky", "papir" };

        // Náhodný generátor pro tah počítače
        Random rnd = new Random();

        // Proměnné pro skóre
        int skoreHrac = 0; // body hráče
        int skorePC = 0;   // body počítače

        // Hlavní herní cyklus – hra běží, dokud hráč nezvolí 0
        while (true)
        {
            // Vyčistí konzoli pro přehledný výstup
            Console.Clear();

            // Menu hry
            Console.WriteLine("Kámen - Nůžky - Papír");
            Console.WriteLine("============================");
            Console.WriteLine("1 = Kámen");
            Console.WriteLine("2 = Nůžky");
            Console.WriteLine("3 = Papír");
            Console.WriteLine("============================");

            // Zobrazení aktuálního skóre
            Console.WriteLine($"Skóre - Hráč: {skoreHrac} | Počítač: {skorePC}");
            Console.WriteLine("============================");
            Console.WriteLine( );
            // Výzva pro hráče, aby zadal svůj tah
            Console.Write("Zadej číslo 1-3 nebo 0 pro konec: ");
            string vstup = Console.ReadLine(); // načte vstup hráče jako text

            // Pokud hráč zadá 0, hra se ukončí
            if (vstup == "0")
                break;

            // Převod vstupu na číslo
            int volba;
            // Ověření, zda je vstup platné číslo 1-3
            if (!int.TryParse(vstup, out volba) || volba < 1 || volba > 3)
            {
                Console.WriteLine("Neplatná volba! Stiskni Enter...");
                Console.ReadLine();
                continue; // přeskočí zpět na začátek cyklu
            }

            // Převedení volby hráče na text (kámen/nůžky/papír)
            // Odečítáme 1, protože pole indexuje od 0
            string hrac = moznosti[volba - 1];

            // Náhodný tah počítače
            string pc = moznosti[rnd.Next(moznosti.Length)];

            // Výpis voleb hráče a počítače
            Console.WriteLine( );
            Console.WriteLine($"Ty: {hrac}");
            Console.WriteLine($"Počítač: {pc}");
            Console.WriteLine( );

            // Vyhodnocení výsledku kola
            if (hrac == pc)
            {
                // Stejná volba = remíza
                Console.ForegroundColor = ConsoleColor.Yellow; // žlutý text pro remízu
                Console.WriteLine("Remíza!");
                Console.ResetColor(); // vrátí barvu zpět na výchozí
                Console.WriteLine( );
            }
            else if (
                // Podmínky, kdy vyhrává hráč
                (hrac == "kamen" && pc == "nuzky") ||
                (hrac == "nuzky" && pc == "papir") ||
                (hrac == "papir" && pc == "kamen")
            )
            {
                Console.ForegroundColor = ConsoleColor.Green; // zelený text pro výhru hráče
                Console.WriteLine("Vyhrál jsi!");
                skoreHrac++; // hráč získává bod
                Console.ResetColor(); // vrátí barvu zpět na výchozí
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red; // červený text pro výhru počítače
                Console.WriteLine("Prohrál jsi!");
                skorePC++; // počítač získává bod
                Console.ResetColor(); // vrátí barvu zpět na výchozí
            }

            // Zobrazení aktuálního skóre po kole
            Console.WriteLine($"Aktuální skóre → Hráč: {skoreHrac} | Počítač: {skorePC}");
            Console.WriteLine( );
            Console.WriteLine("Stiskni Enter pro další kolo...");
            Console.ReadLine(); // čeká na stisk klávesy, aby hráč viděl výsledek
        }

        // Konec hry – vypíše konečné skóre
        Console.WriteLine();
        Console.WriteLine("=== KONEC HRY ===");
        Console.WriteLine($"Konečné skóre → Hráč: {skoreHrac} | Počítač: {skorePC}");
        Console.WriteLine("Stiskni Enter pro ukončení...");
        Console.ReadLine();
    }
}