namespace csharp_opdracht13;

class Program
{
    static void Main(string[] args)
    {
        int[] getallen = new int[5];

        for (int i = 0; i < 5; i++)
        {
            int getal;
            Console.Write("Voer getal " + (i + 1) + " in: ");

            while (!int.TryParse(Console.ReadLine(), out getal))
            {
                Console.WriteLine("Dat is geen geldig getal.");
                Console.Write("Voer getal " + (i + 1) + " in: ");
            }

            getallen[i] = getal;
        }

        Console.WriteLine();
        Console.WriteLine("Je hebt deze getallen ingevoerd:");

        foreach (int getal in getallen)
        {
            Console.WriteLine(getal);
        }
    }
}