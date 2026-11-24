using System.Diagnostics;

namespace csharp_opdracht12 ;
using System;

class Program
{
    static void Main()
    {
        string[] namen = new string[5];

        for (int i = 0; i < namen.Length; i++)
        {
            Console.Write("Voer naam " + (i + 1) + " in: ");
            namen[i] = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Je hebt deze namen ingevoerd:");

        foreach (string naam in namen)
        {
            Console.WriteLine(naam);
        }
    }
}