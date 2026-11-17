namespace csharp_opdracht5;

internal class Program
{
    static void Main(string[] args)
    {
        string rechthoekbreedte;
        string rechthoekhoogte;
        Console.WriteLine("de hoogte van de rechthoek is ");
        rechthoekhoogte = Console.ReadLine();
        Console.WriteLine("de breedte van de rechthoek is ");
        rechthoekbreedte = Console.ReadLine();
        int oppervlakte = int.Parse(rechthoekhoogte) * int.Parse(rechthoekbreedte);
        Console.WriteLine($"de oppervlakte van de rechthoek is {oppervlakte}");
    }
}

