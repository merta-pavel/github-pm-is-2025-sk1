using System;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("***********************************");
            Console.WriteLine("******* Vykreslování obrazců ******");
            Console.WriteLine("***********************************");
            Console.WriteLine("*********** Pavel Merta ***********");
            Console.WriteLine("***********************************");
            Console.WriteLine();

            Console.WriteLine("Vyberte obrazec, který chcete vykreslit:");
            Console.WriteLine("1 - Obdélník");
            Console.WriteLine("2 - Pravouhlý trojúhelník");
            Console.WriteLine("3 - Písmeno N");
            Console.WriteLine("4 - Obrácené písmeno N");
            Console.WriteLine("5 - Diamant");
            Console.Write("Zadejte číslo volby: ");

            int volba;
            while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 5)
            {
                Console.Write("Neplatná volba. Zadejte číslo od 1 do 5: ");
            }

            Console.WriteLine();

            switch (volba)
            {
                case 1:
                    VykresliObdelnik();
                    break;
                case 2:
                    VykresliTrojuhlenik();
                    break;
                case 3:
                    VykresliN();
                    break;
                case 4:
                    VykresliObraceneN();
                    break;
                case 5:
                    VykresliDiamant();
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a, jinak libovolnou jinou pro ukončení.");
            again = Console.ReadLine();
        }
    }

    static int NactiCislo(string text)
    {
        int cislo;
        Console.Write(text);
        while (!int.TryParse(Console.ReadLine(), out cislo) || cislo <= 0)
        {
            Console.Write("Nezadali jste platné celé číslo větší než 0. Zkuste znovu: ");
        }
        return cislo;
    }

    static void VykresliObdelnik()
    {
        int width = NactiCislo("Zadejte šířku obrazce: ");
        int height = NactiCislo("Zadejte výšku obrazce: ");

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("*");
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine();
        }
    }

    static void VykresliTrojuhlenik()
    {
        int n = NactiCislo("Zadejte velikost trojúhelníku: ");

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
                System.Threading.Thread.Sleep(30);
            }
            Console.WriteLine();
        }
    }

    static void VykresliN()
    {
        int n = NactiCislo("Zadejte velikost písmene N: ");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1 || j == i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static void VykresliObraceneN()
    {
        int n = NactiCislo("Zadejte velikost obráceného písmene N: ");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1 || j == (n - i - 1))
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static void VykresliDiamant()
    {
        int n = NactiCislo("Zadejte velikost diamantu (liché číslo, např. 7): ");
        if (n % 2 == 0) n++; // opraví na liché číslo
        int stred = n / 2;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (Math.Abs(i - stred) + Math.Abs(j - stred) == stred)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}