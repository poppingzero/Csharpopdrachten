namespace csharp_opdracht6;

internal class Program
{
    static void Main(string[] args)
    {
        int geboortejaar;
        Console.WriteLine("wat is je geboortejaar?");
        geboortejaar = int.Parse(Console.ReadLine());

        int leeftijd = DateTime.Now.Year - geboortejaar;
        Console.WriteLine($"je bent {leeftijd} jaar oud");
    }
}

