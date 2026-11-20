namespace csharp_opdracht10;

class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        while (a < 10)
        {
            a++;
            if (a == 4)
            {
                continue;
            }
            Console.WriteLine(a);
        }
    }
}