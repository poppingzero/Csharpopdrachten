namespace csharp_opdracht8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Raad het geluksword: ");
        string invoer = Console.ReadLine().ToUpper();

        string resultaat = invoer == "LUCKY" ? "Correct!" : "Fout!";

        Console.WriteLine($"Je typte {invoer} en dat is... {resultaat}");
    }
}