string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *******");
    Console.WriteLine("*********************************************");
    Console.WriteLine("*************** Pavel Merta *****************");
    Console.WriteLine("*********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte hodnotu generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadej dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadej horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }


    Console.WriteLine();
    Console.WriteLine("===================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2};", n, lowerBound, upperBound);
    Console.WriteLine("===================================================");

    //Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50);
    Random myRandNumb = new Random();


    Console.WriteLine();
    Console.WriteLine("===================================================");
    Console.WriteLine("Psudonáhodná čísla:");

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandNumbs[i]);

    }

    // Hlednání maxima, minima a jejich prvních pozic
    int max = myRandNumbs[0]; // předpokládáme, že první prvek v poli je maximem
    int min = myRandNumbs[0]; // předpokládáme, že první prvek v poli je minimem
    int posMax = 0;           // pozice maxima
    int posMin = 0;           // pozice minima
    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("====================================================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního minima: {posMin}");
    Console.WriteLine("====================================================================");
    Console.WriteLine();

    //Vykreslení přesýpacích hodin
    if (max >= 3)
    {
       for (int i = 0; i < max; i++)
        {
            int spaces, stars;
            if (i < max / 2)
            {
                spaces = i;
                //horní polovina - s každým dalším řádkem ubývají dvě hvězdičky
                stars = max - (2 * i);
            }
            else
            {
                spaces = max - i - 1;
                if (max % 2 == 1)
                {
                    //dolní polovina sudé maximum - s každým dalším řádkem přibývají dvě hvězdičky
                    stars = 2 * (i - max / 2) + 1;
                }
                else
                {
                    //dolní polovina liché maximum - s každým dalším řádkem přibývají dvě hvězdičky
                    stars = 2 * (i - max / 2) + 2;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.BackgroundColor = ConsoleColor.Red;
            // sp - space
            for (int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }
            
            // st - star
            for (int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
    else
    {
        Console.WriteLine($"Maximum je menší než 3.");
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");

    again = Console.ReadLine();
}