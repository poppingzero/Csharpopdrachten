namespace csharp_opdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string invoer = "42";
            int getal = int.Parse(invoer);
            int resultaat = getal * 2;

            Console.WriteLine("Het dubbele is: " + resultaat);
            // het resultaat is 84, dat komt door eerst de string "42" een int te maken, daarna doe de int resultaat de int 42 * 2, waar 84 uit komt
        }
    }
}