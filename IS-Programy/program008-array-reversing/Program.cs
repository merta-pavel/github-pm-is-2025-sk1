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
    Console.WriteLine("==================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2};", n, lowerBound, upperBound);
    Console.WriteLine("==================================================");

    //Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50);
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("===================================================");
    Console.WriteLine("Psudonáhodná čísla:");

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    for (int i = 0; i < n / 2; i++)
    {
        int tmp = myRandNumbs[i];
        myRandNumbs[i] = myRandNumbs[n - 1 - i];
        myRandNumbs[n - 1 - i] = tmp;
    }

    Console.WriteLine();
    Console.WriteLine("===================================================");
    Console.WriteLine("Pole po reverzi:");
    Console.WriteLine();
    
    for (int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}