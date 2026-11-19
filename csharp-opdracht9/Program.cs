namespace csharp_opdracht9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kies 1:Small, 2:Medium of 3:Large");
        int keuze = int.Parse(Console.ReadLine());

        switch (keuze)
        {
            case 1:
            Console.WriteLine("small is gekozen, de prijs is $2,00");
            break;
            case 2:
            Console.WriteLine("medium is gekozen, de prijs is $2,50");
            break;
            case 3:
                Console.WriteLine("Large is gekozen, de prijs is $3,00");
                break;
            default:
                Console.WriteLine("Ongeldige keuze");
                break;
        }
    }
}
