namespace csharp_opdracht11;
using System;

class Program
{
    static void Main()
    {
        bool doorgaan = true;

        while (doorgaan)
        {
            Console.WriteLine("Kies een optie: 1, 2 of 3 (afsluiten)");

            ConsoleKeyInfo toets = Console.ReadKey(true);

            switch (toets.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("Menu 1");
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("Menu 2");
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("Programma wordt afgesloten.");
                    doorgaan = false;
                    break;

                default:
                    Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                    break;
            }

            Console.WriteLine();
        }
    }
}